// DBHelper class contains everything connected with storage
// while the whole database is read into entity classes on login attempt


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pGina.Plugin.MFLoginPlugin
{
    class DBHelper // Plugin may use different databases. Those should be added with ease
    {
        // not finished yet

        public void CreateDB(string path, string password){}
        //
        public void AddKey() { }
        public void UpdateKey() { } // Type and id must remain untouched!
        public void GetKey(){}
        // Keys can't be removed
        public void AddUser() { }
        public void UpdateUser() { } // login and id must remain untouched!
        public void GetUser() { }
        // Users can't be removed
        public void AddKeySet() { }
        public void UpdateKeySet() { }// Check if it's used by another user!!!!!
        public void RemoveKeySet() { }// if not used
        public void GetKeySet() { }
        //
        public void AddAuthMethod() { }
        public void UpdateAuthMethod() { }
        public void RemoveAuthMethod() { }
        public void GetAuthMethod() { }
        //
        public void WriteLogAttempt() { }
        public void ReadLogAttempt() { }
        //
    }
}
