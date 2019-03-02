// DBHelper class contains everything connected with storage
// while the whole database is read into entity classes on login attempt
// Plugin may use different databases
// SQL Injection Protection required

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using System.Data.SQLite;
using pGina.Plugin.MFLoginPlugin.Entities;
using pGina.Plugin.MFLoginPlugin.Entities.Keys;

namespace pGina.Plugin.MFLoginPlugin
{
    class DBHelper 
    {
		public static SQLiteConnection connection;
        public static void CreateLocalDB(string path, string password)
        {
            SQLiteConnection.CreateFile(path);
            ConnectLocalDB(path, password);
            SQLiteCommand sqlc = connection.CreateCommand();
            sqlc.CommandText = File.ReadAllText("create_db.sql");
            sqlc.ExecuteNonQuery();
        }
        public static void ConnectLocalDB(string path, string password)
        {
            SQLiteConnectionStringBuilder sQLiteConnectionStringBuilder = new SQLiteConnectionStringBuilder();
            sQLiteConnectionStringBuilder.Add("Data Source", path);
            sQLiteConnectionStringBuilder.Add("Version", 3);
            sQLiteConnectionStringBuilder.Add("Password", password);
            connection = new SQLiteConnection(sQLiteConnectionStringBuilder.ConnectionString);
            connection.Open();
        }
        public static void Disconnect()
        {
            connection.Close();
            connection.Dispose();
        }
		public static User[] ReadUsers()
		{
			List<User> Users = new List<User>();
			if (connection.State != System.Data.ConnectionState.Open) return null;
			SQLiteCommand sqlc = new SQLiteCommand("SELECT * FROM USERS;", connection);
			SQLiteDataReader r = sqlc.ExecuteReader();
			while (r.Read())
			{
				User newUser=new User(ulong.Parse(r["UID"].ToString()));
				newUser.Fill();
				Users.Add(newUser);
			}
			return Users.ToArray();
		}
		public static Key[] ReadKeys()
		{
			List<Key> Keys = new List<Key>();
			if (connection.State != System.Data.ConnectionState.Open) return null;
			SQLiteCommand sqlc = new SQLiteCommand("SELECT * FROM KEYS;", connection);
			SQLiteDataReader r = sqlc.ExecuteReader();
			while (r.Read())
			{
				Key newKey = Key.DefineKey(ulong.Parse(r["KID"].ToString()));
				newKey.Fill();
				Keys.Add(newKey);
			}
			return Keys.ToArray();
		}
		public static AuthMethod[] ReadAuthMethods()
		{
			List<AuthMethod> AMs = new List<AuthMethod>();
			if (connection.State != System.Data.ConnectionState.Open) return null;
			SQLiteCommand sqlc = new SQLiteCommand("SELECT * FROM AUTH_METHODS;", connection);
			SQLiteDataReader r = sqlc.ExecuteReader();
			while (r.Read())
			{
				AuthMethod newAM = new AuthMethod(ulong.Parse(r["AMID"].ToString()));
				newAM.Fill();
				AMs.Add(newAM);
			}
			return AMs.ToArray();
		}
		public static void ConnectToRemoteDB(string path) { throw new NotImplementedException(); }

		public static AuthMethod[] GetAuthMethods(User user) {
			List<AuthMethod> authMethods=new List<AuthMethod>();
			SQLiteCommand sqlc = new SQLiteCommand("SELECT * FROM AUTH_METHOD WHERE UID=$UID", DBHelper.connection);
			sqlc.Parameters.AddWithValue("$UID", user.UID);
			SQLiteDataReader r = sqlc.ExecuteReader();
			while (r.Read())
			{
				ulong amid = ulong.Parse(r["AMID"].ToString());
				AuthMethod am = new AuthMethod(amid);
				am.Fill();
				authMethods.Add(am);
			}
			return authMethods.ToArray();
		}
		public static void RemoveUnusedKeys()
		{
			SQLiteCommand sqlc = new SQLiteCommand("DELETE FROM KEYS WHERE KEYS.KID not in (SELECT K1 FROM AUTH_METHOD UNION SELECT K2 FROM AUTH_METHOD UNION SELECT K3 FROM AUTH_METHOD UNION SELECT K4 FROM AUTH_METHOD UNION SELECT K5 FROM AUTH_METHOD);", DBHelper.connection);
			sqlc.ExecuteScalar();
		}
        /*
        public static void WriteLogAttempt(LogEntity le) { }
        public static LogEntity ReadLogAttempt() { return new LogEntity(); } // how can this be used??????
        public static List<LogEntity> ReadLogs(DateTime start, DateTime end) { return new List<LogEntity>(); } //logs in time period
        public static List<LogEntity> ReadLogs() { return new List<LogEntity>(); } // all logs
        //
		*/
    }
}
