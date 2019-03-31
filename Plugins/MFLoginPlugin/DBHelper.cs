// DBHelper class contains everything connected with storage
// while the whole database is read into entity classes on login attempt
// Plugin may use different databases
// SQL Injection Protection required

using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using pGina.Plugin.MFLoginPlugin.Entities;
using pGina.Shared.Types;
using log4net;
namespace pGina.Plugin.MFLoginPlugin
{
    class DBHelper 
    {
		public static SQLiteConnection connection;
        private static ILog m_logger = LogManager.GetLogger("MFLoginPlugin");
        private const string DBCreationQuery = @"
-- Table: AUTH_METHOD
DROP TABLE IF EXISTS AUTH_METHOD;
CREATE TABLE AUTH_METHOD (AMID NUMERIC (16) UNIQUE,UID NUMERIC (16) NOT NULL REFERENCES USERS (UID), K1 NUMERIC (16), K2 NUMERIC (16), K3 NUMERIC (16), K4 NUMERIC (16), K5 NUMERIC (16), Description TEXT NOT NULL, Number_of_keys INTEGER, Hash TEXT NOT NULL);

-- Table: KEYS
DROP TABLE IF EXISTS KEYS;
CREATE TABLE KEYS (KID NUMERIC (16) PRIMARY KEY UNIQUE NOT NULL, Description TEXT NOT NULL, Inverted BOOLEAN NOT NULL, Type TEXT NOT NULL, Serial TEXT, Password TEXT, Data TEXT, Hash TEXT NOT NULL);

-- Table: LOGIN_ATTEMPTS
DROP TABLE IF EXISTS LOGIN_ATTEMPTS;
CREATE TABLE LOGIN_ATTEMPTS (LEID NUMERIC NOT NULL, UID NUMERIC (16) NOT NULL, Name TEXT, AMID NUMERIC(16) NOT NULL, AMDescription TEXT, KeysUsed TEXT, Success BOOLEAN NOT NULL, Time DATETIME NOT NULL, Hash TEXT NOT NULL);

-- Table: USERS
DROP TABLE IF EXISTS USERS;
CREATE TABLE USERS (UID NUMERIC (16) PRIMARY KEY NOT NULL UNIQUE, Name STRING (128) NOT NULL UNIQUE, ROLE STRING(128) NOT NULL, WindowsPassword STRING(128), Hash TEXT NOT NULL);
"; // wanted to read it from file but it seems to be useless
        public static bool CheckDatabase()
        {
            try
            {
                // check basic structure
                SQLiteCommand sqlc = new SQLiteCommand("SELECT COUNT(name) FROM sqlite_master WHERE type='table';", connection);
                ulong a = ulong.Parse(sqlc.ExecuteScalar().ToString());
                if (a != 4) throw new Exception();
				/*
				 * Those checks spam with excessive log entities
				 * However, this may be useful to monitor configuration menu use:
				 * each database connect has "testName user added" and "testName user removed" messages
				*/
				/*
				// check users table
                User user = new User();
				user.Name = "testName";
				user.Role = "User";
                user.Save();
                user.Remove();
                // check keys
                Key key = Key.DefineKey("Password");
                key.Save();
                key.Remove();
				*/
				
            }
            catch { return false; }
            return true;
        }
        public static BooleanResult ConnectOrCreateLocalDB(string path, string password, bool createNew=false)
        {
            if (connection!=null) connection.Close();
            if (createNew)
            {
                try
                {
                    File.Delete(path);
                }
                catch {} //we don't care if database file is deleted or not
                // db can be reset with SQL query
            }
            try
            {
                if (!File.Exists(path))
                {
                    SQLiteConnection.CreateFile(path);
                    createNew = true;
                }
            }
            catch { return new BooleanResult() { Success = false, Message = "No access to file" }; }
            
            SQLiteConnectionStringBuilder sQLiteConnectionStringBuilder = new SQLiteConnectionStringBuilder();
	    	sQLiteConnectionStringBuilder.Add("Data Source", path);
			sQLiteConnectionStringBuilder.Add("Version", 3);
			sQLiteConnectionStringBuilder.Add("Password", password);
			connection = new SQLiteConnection(sQLiteConnectionStringBuilder.ConnectionString);
			connection.Open();

            bool connectionSuccess = CheckDatabase();
            if (connectionSuccess)
            {
                if (createNew)
                {
                    using (SQLiteCommand sqlc = new SQLiteCommand(DBCreationQuery, connection))
                        sqlc.ExecuteNonQuery();
                    return new BooleanResult(){Success=true, Message="Created"};
                }
                else
                    return new BooleanResult(){Success=true, Message="Open"};
            }
            else
            {
                if (createNew)
                {
                    using (SQLiteCommand sqlc = new SQLiteCommand(DBCreationQuery, connection))
                        sqlc.ExecuteNonQuery();
                    return new BooleanResult() { Success = true, Message = "Created" };
                }
                else
                return new BooleanResult() {Success=false, Message="Try again. Wrong password or corrupted database"  };
            }
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
        
            
                try
                {
                    List<User> Users = new List<User>();
                    SQLiteCommand sqlc = new SQLiteCommand("SELECT * FROM USERS;", connection);
                    SQLiteDataReader r = sqlc.ExecuteReader();
                    while (r.Read())
                    {
                        User newUser = new User(ulong.Parse(r["UID"].ToString()));
                        newUser.Fill();
                        Users.Add(newUser);
                    }
                    return Users.ToArray();
                }
                catch (Exception ex)
                {
                    m_logger.Error(ex.Message);
                    return null;
                }
            
		}
		public static Key[] ReadKeys(string type="", AuthMethod am=null)
		{
            try{
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
            catch (Exception ex)
            {
                m_logger.Error(ex.Message);
                return null;
            }
		}
		public static AuthMethod[] ReadAuthMethods(ulong keyID=0)
		{
            try{
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
            catch (Exception ex)
            {
                m_logger.Error(ex.Message);
                return null;
            }
		}
		public static BooleanResult ConnectToRemoteDB(string path) { return new BooleanResult() { Success = false, Message = "Not implemented" }; }

		public static AuthMethod[] GetAuthMethods(User user) {
			try{
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
            catch (Exception ex)
            {
                m_logger.Error(ex.Message);
                return null;
            }
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
        public static List<LogEntity> ReadLogs(string mode="", int count=20) //mode="F100", "L100","All", etc.
        {
            try{
            List<LogEntity> logs = new List<LogEntity>();
            SQLiteCommand sqlc = new SQLiteCommand(DBHelper.connection);
            sqlc.CommandText = "SELECT LEID FROM LOGIN_ATTEMPTS";
            switch (mode)
            {
                case "All": break;
                case "F": sqlc.CommandText += " ORDER BY LEID ASC LIMIT " + count; break;
                case "L": sqlc.CommandText += " ORDER BY LEID DESC LIMIT " + count; break;
                case "Today": sqlc.CommandText += " WHERE Time >= datetime('now', 'localtime', 'start of day')"; break;
                case "This month": sqlc.CommandText += " WHERE Time >= datetime('now', 'localtime', 'start of month')"; break;
                default: break;
            }
            SQLiteDataReader r = sqlc.ExecuteReader();
            while (r.Read())
            {
                ulong leid = ulong.Parse(r["LEID"].ToString());
                LogEntity le = new LogEntity(leid);
                le.Fill();
                logs.Add(le);
            }
            return logs;
            }
            catch (Exception ex)
            {
                m_logger.Error(ex.Message);
                return null;
            }
        }
        public bool ClearLogs(DateTime border)
        {
            throw new NotImplementedException();
        }
        
    }
}
