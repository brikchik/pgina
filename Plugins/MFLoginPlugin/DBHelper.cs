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
using pGina.Shared.Types;

namespace pGina.Plugin.MFLoginPlugin
{
    class DBHelper 
    {
		public static SQLiteConnection connection;
        private const string DBCreationQuery = @"
-- Table: AUTH_METHOD
DROP TABLE IF EXISTS AUTH_METHOD;
CREATE TABLE AUTH_METHOD (AMID NUMERIC (16) UNIQUE,UID NUMERIC (16) NOT NULL REFERENCES USERS (UID), K1 NUMERIC (16), K2 NUMERIC (16), K3 NUMERIC (16), K4 NUMERIC (16), K5 NUMERIC (16), Description TEXT NOT NULL, Number_of_keys INTEGER, Hash TEXT NOT NULL);

-- Table: KEYS
DROP TABLE IF EXISTS KEYS;
CREATE TABLE KEYS (KID NUMERIC (16) PRIMARY KEY UNIQUE NOT NULL, Description TEXT NOT NULL, Inverted BOOLEAN NOT NULL, Type TEXT NOT NULL, Serial TEXT, Password TEXT, Data TEXT, Hash TEXT NOT NULL);

-- Table: LOGIN_ATTEMPTS
DROP TABLE IF EXISTS LOGIN_ATTEMPTS;
CREATE TABLE LOGIN_ATTEMPTS (UID NUMERIC (16) NOT NULL, User TEXT NOT NULL, Keys TEXT NOT NULL, Time DATETIME NOT NULL, Success BOOLEAN NOT NULL, Auth_method NUMERIC(16) NOT NULL,Hash TEXT NOT NULL);

-- Table: USERS
DROP TABLE IF EXISTS USERS;
CREATE TABLE USERS (UID NUMERIC (16) PRIMARY KEY NOT NULL UNIQUE, Name STRING (128) NOT NULL UNIQUE, ROLE STRING(128) NOT NULL, WindowsPassword STRING(128), Hash TEXT NOT NULL);
"; // wanted to read it from file but it seems to be useless
        public static BooleanResult CreateLocalDB(string path, string password)
        {
            try
            {
				if (File.Exists(path)) File.Delete(path);
                SQLiteConnection.CreateFile(path);
				BooleanResult connectionSuccess = ConnectLocalDB(path, password);
				if (connectionSuccess.Message == "Database corrupted")
				{
					SQLiteCommand sqlc = connection.CreateCommand();
					sqlc.CommandText = DBCreationQuery;
					sqlc.ExecuteNonQuery();
				}
				else return connectionSuccess;
            }
            catch (Exception ex){ return new BooleanResult() { Success=false, Message=ex.Message }; }
			return new BooleanResult() { Success = true };
        }
        public static BooleanResult ConnectLocalDB(string path, string password)
        {
			try
			{
				SQLiteConnectionStringBuilder sQLiteConnectionStringBuilder = new SQLiteConnectionStringBuilder();
				sQLiteConnectionStringBuilder.Add("Data Source", path);
				sQLiteConnectionStringBuilder.Add("Version", 3);
				sQLiteConnectionStringBuilder.Add("Password", password);
				connection = new SQLiteConnection(sQLiteConnectionStringBuilder.ConnectionString);
				connection.Open();
				SQLiteCommand sqlc = new SQLiteCommand("SELECT COUNT(name) FROM sqlite_master WHERE type='table';", connection);
				ulong a = ulong.Parse(sqlc.ExecuteScalar().ToString());
				if (a != 4) return new BooleanResult() { Success = false, Message="Database corrupted or the password is wrong" };
			}
			catch (Exception ex){ return new BooleanResult() { Success = false, Message=ex.Message }; }
			return new BooleanResult() { Success = true } ;
        }
        public static BooleanResult Disconnect()
        {
			try
			{
				connection.Shutdown();
				connection.Close();
				connection = null;
			}
			catch (Exception ex) { return new BooleanResult() { Success = false, Message = ex.Message }; }
			return new BooleanResult() { Success = true };
        }
		public static User[] ReadUsers()
		{
			List<User> Users = new List<User>();
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
		public static Key[] ReadKeys(string type="", AuthMethod am=null)
		{
			List<Key> Keys = new List<Key>();
			SQLiteCommand sqlc = new SQLiteCommand("SELECT * FROM KEYS;", connection);
			if (type != "")
			{
				sqlc = new SQLiteCommand("SELECT * FROM KEYS WHERE TYPE=$TYPE;", connection);
				sqlc.Parameters.AddWithValue("$TYPE", type);
			};
			if (am != null)
			{
				sqlc = new SQLiteCommand("SELECT * FROM KEYS WHERE KID=$key1 OR KID=$key2 OR KID=$key3 OR KID=$key4 OR KID=$key5;", connection);
				if (am.K1 != null) sqlc.Parameters.AddWithValue("$key1", am.K1.KID); else sqlc.Parameters.AddWithValue("$key1", 0);
				if (am.K2 != null) sqlc.Parameters.AddWithValue("$key2", am.K2.KID); else sqlc.Parameters.AddWithValue("$key2", 0);
				if (am.K3 != null) sqlc.Parameters.AddWithValue("$key3", am.K3.KID); else sqlc.Parameters.AddWithValue("$key3", 0);
				if (am.K4 != null) sqlc.Parameters.AddWithValue("$key4", am.K4.KID); else sqlc.Parameters.AddWithValue("$key4", 0);
				if (am.K5 != null) sqlc.Parameters.AddWithValue("$key5", am.K5.KID); else sqlc.Parameters.AddWithValue("$key5", 0);
			}
			SQLiteDataReader r = sqlc.ExecuteReader();
			while (r.Read())
			{
				Key newKey = Key.DefineKey(ulong.Parse(r["KID"].ToString()));
				newKey.Fill();
				Keys.Add(newKey);
			}
			return Keys.ToArray();
		}
		public static AuthMethod[] ReadAuthMethods(ulong keyID=0)
		{
			List<AuthMethod> AMs = new List<AuthMethod>();
			SQLiteCommand sqlc = new SQLiteCommand("SELECT * FROM AUTH_METHODS;", connection);
			if (keyID != 0)
			{
				sqlc.CommandText = "SELECT * FROM AUTH_METHOD WHERE K1=$key OR K2=$key OR K3=$key OR K4=$key OR K5=$key;";
				sqlc.Parameters.AddWithValue("$key", keyID);
			}
			SQLiteDataReader r = sqlc.ExecuteReader();
			while (r.Read())
			{
				AuthMethod newAM = new AuthMethod(ulong.Parse(r["AMID"].ToString()));
				newAM.Fill();
				AMs.Add(newAM);
			}
			return AMs.ToArray();
		}
		public static BooleanResult ConnectToRemoteDB(string path) { return new BooleanResult() { Success = false, Message = "Not implemented" }; }

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
        public static void CleanDB()
        {
		    foreach (User user in ReadUsers())
            {
                if (!user.ExistsInSystem()) user.Remove();
            }
            SQLiteCommand sqlc = new SQLiteCommand("DELETE FROM AUTH_METHOD WHERE UID NOT IN (SELECT UID FROM USERS);", DBHelper.connection);
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
