using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pGina.Plugin.MFLoginPlugin
{
    class KeySet
    {
        public UInt64 KSID;
        public UInt64 K1;
        public UInt64 K2;
        public UInt64 K3;
        public UInt64 K4;
        public UInt64 K5;
        private string Hash;
        public KeySet(UInt64 ksid, UInt64 k1=0, UInt64 k2=0, UInt64 k3=0, UInt64 k4=0, UInt64 k5=0, string hash="") 
        {
            KSID = ksid; K1 = k1; K2 = k2; K3 = k3; K4 = k4; K5 = k5; Hash = hash;
        }
        public void ComputeHash() { Hash = (KSID+K1+K2+K3+K4+K5).ToString(); } // !!!!!!!!!!!!
        public bool IsValid()
        {
            string currentHash = Hash;
            ComputeHash();
            return (currentHash == Hash);
        }
    }
}
