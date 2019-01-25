// DBHelper class contains everything connected with storage
// while the whole database is read into entity classes on login attempt
// Plugin may use different databases

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using pGina.Plugin.MFLoginPlugin.Entities;
using pGina.Plugin.MFLoginPlugin.Entities.Keys;

namespace pGina.Plugin.MFLoginPlugin
{
    class DBHelper 
    {
        public void CreateLocalDB(string path, string password){}
        public void ConnectToRemoteDB(string path, string password) { }
        //
        public void AddKey(IKey ik) { }
        public void UpdateKey(IKey ik) { } // Type and id must remain untouched!
        public IKey GetKey() { return new PasswordKey(); } // !!!!!!!!
        // Keys can't be removed
        public void AddUser(User u) { }
        public void UpdateUser(User u) { } // login and id must remain untouched!
        public User GetUser() { return new User(0, "default"); }
        public User GetUser(string userName) { return new User(0, "UserName"); } //// !!!!!
        // Users can't be removed
        public void AddKeySet(KeySet ks) { } // check if keys exist!
        public void UpdateKeySet(KeySet ks) { }// Check if it's used by another user!!!!!
        public void RemoveKeySet(KeySet ks) { }// if not used. check required
        public KeySet GetKeySet() { return new KeySet(0); }
        //
        public void AddAuthMethod(AuthMethod am) { }
        public void UpdateAuthMethod(AuthMethod am) { } //use id to distinguish authMethods
        public void RemoveAuthMethod(AuthMethod am) { } //use id to distinguish authMethods
        public AuthMethod[] GetAuthMethods(User u) { return new AuthMethod[]{}; } // for a user
        //
        public void WriteLogAttempt(LogEntity le) { }
        public LogEntity ReadLogAttempt() { return new LogEntity(); } // how can this be used??????
        public List<LogEntity> ReadLogs(DateTime start, DateTime end) { return new List<LogEntity>(); } //logs in time period
        public List<LogEntity> ReadLogs() { return new List<LogEntity>(); } // all logs
        //
    }
}
