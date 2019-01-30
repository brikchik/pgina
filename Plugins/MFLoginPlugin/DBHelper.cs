// DBHelper class contains everything connected with storage
// while the whole database is read into entity classes on login attempt
// Plugin may use different databases

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
        public static SQLiteConnection connection; // mustn't be public !!!!
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
        public static void ConnectToRemoteDB(string path) { throw new NotImplementedException(); }
        //
        public static void AddKey(IKey ik) {
        }
        public static void UpdateKey(IKey ik) { } // Type and id must remain untouched!
        public static IKey GetKey() { return new PasswordKey(); } // !!!!!!!!
        // Keys can't be removed
        public static void AddUser(User u) {
        }
        public static void UpdateUser(User u) { } // login and id must remain untouched!
        public static User GetUser() { return new User(0, "default"); }
        public static User GetUser(string userName) { return new User(0, "UserName"); } //// !!!!!
        // Users can't be removed
        public static void AddKeySet(KeySet ks) { } // check if keys exist!
        public static void UpdateKeySet(KeySet ks) { }// Check if it's used by another user!!!!!
        public static void RemoveKeySet(KeySet ks) { }// if not used. check required
        public static KeySet GetKeySet() { return new KeySet(0); }
        //
        public static void AddAuthMethod(AuthMethod am) { }
        public static void UpdateAuthMethod(AuthMethod am) { } //use id to distinguish authMethods
        public static void RemoveAuthMethod(AuthMethod am) { } //use id to distinguish authMethods
        public static AuthMethod[] GetAuthMethods(User u) { return new AuthMethod[]{}; } // for a user
        //
        public static void WriteLogAttempt(LogEntity le) { }
        public static LogEntity ReadLogAttempt() { return new LogEntity(); } // how can this be used??????
        public static List<LogEntity> ReadLogs(DateTime start, DateTime end) { return new List<LogEntity>(); } //logs in time period
        public static List<LogEntity> ReadLogs() { return new List<LogEntity>(); } // all logs
        //
    }
}
