using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pGina.Plugin.MFLoginPlugin
{
    class KeySet
    {
        public UInt64 KSID;
        public IKey[] Keys;
        private string Hash;

        public KeySet(UInt64 ksid, string hash="") // !!!!!!!!!!!
        {
            KSID = ksid; Hash = hash;
        }
        public void ComputeHash() { Hash = (KSID).ToString(); } // !!!!!!!!!!!!
        public bool IsValid()
        {
            string currentHash = Hash;
            ComputeHash();
            return (currentHash == Hash);
        }
    }
}
