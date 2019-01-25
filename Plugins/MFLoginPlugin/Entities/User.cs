using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pGina.Plugin.MFLoginPlugin
{
    class User
    {
        public UInt64 UID;
        public string Name;
        public string Hash;
        public void ComputeHash() { Hash = Name + UID; } // !!!!!!!!!!!!
        public bool IsValid()
        {
            string currentHash = Hash;
            ComputeHash();
            return (currentHash == Hash);
        }
        public User(UInt64 uid, string name) 
        { UID = uid; Name = name; ComputeHash(); } //creation
        public User(UInt64 uid, string name, string hash) 
        { UID = uid; Name = name; Hash = hash; }//database item
    }
}
