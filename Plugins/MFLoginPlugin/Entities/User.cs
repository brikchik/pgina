using System;
using System.Data.SQLite;
using System.DirectoryServices;
using log4net;
namespace pGina.Plugin.MFLoginPlugin.Entities
{
    class User
    {
        public ulong UID;
        public string Name;
		public String Role;
        private string Hash="";
		public string WindowsPassword=null; // REAL windows password
		private static ILog m_logger = LogManager.GetLogger("MFLoginPlugin");
		public void ComputeHash() { Hash = Shared.Hashed(Name + UID + Role + WindowsPassword); }
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
                catch { UID = 1; }
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
                    if (!IsValid()) return false;
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
                    if (r["WindowsPassword"] != System.DBNull.Value) WindowsPassword = (string)r["WindowsPassword"];
                    Hash = (string)r["Hash"];
                    if (!IsValid()) return false;
                    return true;
                }
                else
                    return false;
		}
		public bool Save()
		{
                try
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
                    ComputeHash();
                    sqlc.Parameters.AddWithValue("$Hash", Hash);
                    return (sqlc.ExecuteNonQuery() == 1);
                }
                catch (Exception ex)
                {
                    m_logger.Error(ex.Message);
                    return false;
                }
            
		}
		public bool Remove()
		{
			SQLiteCommand sqlc = new SQLiteCommand("DELETE FROM USERS WHERE UID=$UID", DBHelper.connection);
			sqlc.Parameters.AddWithValue("$UID", UID);
			bool success = (sqlc.ExecuteNonQuery()==1);
			sqlc = new SQLiteCommand("DELETE FROM AUTH_METHODS WHERE UID=$UID", DBHelper.connection);
			sqlc.Parameters.AddWithValue("$UID", UID);

                LogEntity le = new LogEntity(this, "Removed from MFLogin", true);
                le.Save();
            
			return success;
		}

		public bool ExistsInSystem()
		{
			try
			{
				DirectoryEntry directoryEntry = new DirectoryEntry("WinNT://" + Environment.MachineName + ",computer");
				DirectoryEntry currentUser = directoryEntry.Children.Find(Name, "user");
			}
			catch (Exception) { return false; }
			return true;
		}
		public bool AddToSystem()
		{
			try
			{
				DirectoryEntry directoryEntry = new DirectoryEntry("WinNT://" + Environment.MachineName + ",computer");
				DirectoryEntry newUser = directoryEntry.Children.Add(Name, "user");
				newUser.Invoke("SetPassword", new Object[] { WindowsPassword });
				newUser.Invoke("Put", new object[] { "Description", "pGina created" });
				newUser.CommitChanges();
				DirectoryEntry grp = null; ;
				try { grp = directoryEntry.Children.Find("Users", "group"); } catch { }
				if (grp != null) grp.Invoke("Add", new object[] { newUser.Path.ToString() });
				try { grp = directoryEntry.Children.Find("Пользователи", "group"); } catch { }
				if (grp != null) grp.Invoke("Add", new object[] { newUser.Path.ToString() });
                    LogEntity le = new LogEntity(this, "Created", true);
                    le.Save();
			}
			catch (Exception e) { m_logger.Error(e.Message); return false; }
			return true;
		}
        public bool AddToPGina()
        {
            try
            {
                DirectoryEntry directoryEntry = new DirectoryEntry("WinNT://" + Environment.MachineName + ",computer");
                DirectoryEntry user = directoryEntry.Children.Find(Name, "user");
                user.Invoke("Put", new object[] { "Description", "pGina created" });
                user.CommitChanges();
            }
            catch (Exception e) { m_logger.Error(e.Message); return false; }
                LogEntity le = new LogEntity(this, "Added to MFLogin", true);
                le.Save();
            
            return true;
        }
		public bool NewPassword()
		{
			try
			{
				WindowsPassword = Shared.GetUniqueKey(Shared.INTERNAL_USER_PASSWORD_LENGTH);
				DirectoryEntry directoryEntry = new DirectoryEntry("WinNT://" + Environment.MachineName + ",computer");
				DirectoryEntry user = directoryEntry.Children.Find(Name, "user");
				user.Invoke("SetPassword", new Object[] { WindowsPassword });
				user.CommitChanges();
				Save();
			}
			catch (Exception e) { m_logger.Error(e.Message); return false; }
                LogEntity le = new LogEntity(this, "Got a new internal password", true);
                le.Save();
			return true;
		}
		public bool RemoveFromSystem()
		{
			try
			{
				DirectoryEntry directoryEntry = new DirectoryEntry("WinNT://" + Environment.MachineName + ",computer");
				DirectoryEntry currentUser = directoryEntry.Children.Find(Name, "user");
				currentUser.InvokeGet("Description");
				if (currentUser.InvokeGet("Description").ToString() == "pGina created")
				{
					directoryEntry.Children.Remove(currentUser);

                        LogEntity le = new LogEntity(this, "Removed from Windows", true);
                        le.Save();
                    
				}
				else throw new Exception(message: "User is not created by pGina: "+Name);
			}
			catch (Exception e) { m_logger.Error(e.Message); return false; }
			return true;
		}
		public bool MakeAdmin(bool admin)
		{
			String action = admin?"Add":"Remove";
			DirectoryEntry directoryEntry = new DirectoryEntry("WinNT://" + Environment.MachineName + ",computer");
			DirectoryEntry currentUser = directoryEntry.Children.Find(Name, "user");
			try
			{
				DirectoryEntry grp = directoryEntry.Children.Find("Administrators", "group");
				if (grp != null) grp.Invoke(action, new object[] { currentUser.Path.ToString() });
			}
			catch (Exception e) { m_logger.Error("Administrators... " + e.Message); }
			try
			{
				DirectoryEntry grp = directoryEntry.Children.Find("Администраторы", "group");
				if (grp != null) grp.Invoke(action, new object[] { currentUser.Path.ToString() });
			}
			catch (Exception e) { m_logger.Error("Администраторы... " + e.Message); }

                LogEntity le = new LogEntity(this, "Is administrator", admin);
                le.Save();
			return true;
		}
	}
}
