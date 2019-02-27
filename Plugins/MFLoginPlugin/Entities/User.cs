using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

namespace pGina.Plugin.MFLoginPlugin.Entities
{
    class User
    {
        public ulong UID;
        public string Name;
		public String Role;
        private string Hash;
		public string WindowsPassword = ""; // REAL windows password

		public void ComputeHash() { Hash = Name + UID; } // !!!!!!!!!!!!
        public bool IsValid()
        {
            string currentHash = Hash;
            ComputeHash();
            return (currentHash == Hash);
        }
        public User(ulong uid, string name, string role="User", string password="Password") 
        { UID = uid; Name = name; Role = role; WindowsPassword = password; ComputeHash(); } //creation
        public User(ulong uid) { UID = uid;}//database item
		public User()
		{
			SQLiteCommand sqlc = new SQLiteCommand("SELECT MAX(UID) AS MAX_UID FROM USERS", DBHelper.connection);
			SQLiteDataReader r = sqlc.ExecuteReader();
			r.Read();
			try
			{
				UID = ulong.Parse(r["MAX_UID"].ToString()) + 1;
			}
			catch (Exception e) { UID = 1; }
		}

		public override string ToString() { return Name; }
		public bool FillByName(string name)
		{
			SQLiteCommand sqlc = new SQLiteCommand("SELECT * FROM USERS WHERE NAME=$NAME", DBHelper.connection);
			sqlc.Parameters.AddWithValue("$NAME", name);
			SQLiteDataReader r = sqlc.ExecuteReader();
			if (r.Read())
			{
				UID = ulong.Parse(r["UID"].ToString());
				Name = (string)r["Name"];
				Role = (string)r["Role"];
				if (r["WindowsPassword"] != System.DBNull.Value) WindowsPassword = (string)r["WindowsPassword"];
				Hash = (string)r["Hash"];
				return true;
			}
			else
				return false;
		}
		public bool Fill()
		{
			SQLiteCommand sqlc = new SQLiteCommand("SELECT * FROM USERS WHERE UID=$UID", DBHelper.connection);
			sqlc.Parameters.AddWithValue("$UID", UID);
			SQLiteDataReader r = sqlc.ExecuteReader();
			if (r.Read())
			{
				Name = (string)r["Name"];
				Role = (string)r["Role"];
				if (r["WindowsPassword"]!=System.DBNull.Value) WindowsPassword = (string)r["WindowsPassword"];
				Hash = (string)r["Hash"];
				return true;
			}
			else
				return false;
		}
		public bool Save()
		{
			SQLiteCommand sqlc = new SQLiteCommand("SELECT * FROM USERS WHERE UID=$UID", DBHelper.connection);
			sqlc.Parameters.AddWithValue("$UID", UID);
			bool exists = (sqlc.ExecuteScalar() != null);
			if (exists)
				sqlc = new SQLiteCommand("UPDATE USERS SET UID=$UID, Name=$Name,Role=$Role, WindowsPassword=$WindowsPassword, Hash=$Hash WHERE UID=$UID", DBHelper.connection);
			else
				sqlc = new SQLiteCommand("INSERT INTO USERS VALUES($UID, $Name,$Role, $WindowsPassword, $Hash)", DBHelper.connection);
			sqlc.Parameters.AddWithValue("$UID", UID);
			sqlc.Parameters.AddWithValue("$Name", Name);
			sqlc.Parameters.AddWithValue("$Role", Role);
			sqlc.Parameters.AddWithValue("$WindowsPassword", WindowsPassword);
			sqlc.Parameters.AddWithValue("$Hash", Hash);
			return (sqlc.ExecuteNonQuery() == 1);
		}
		public bool Remove()
		{
			SQLiteCommand sqlc = new SQLiteCommand("DELETE FROM USERS WHERE UID=$UID", DBHelper.connection);
			sqlc.Parameters.AddWithValue("$UID", UID);
			bool success = (sqlc.ExecuteNonQuery()==1);
			sqlc = new SQLiteCommand("DELETE FROM AUTH_METHODS WHERE UID=$UID", DBHelper.connection);
			sqlc.Parameters.AddWithValue("$UID", UID);
			return success;
		}
	}
}
