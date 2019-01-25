using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pGina.Plugin.MFLoginPlugin
{
    class AuthMethod
    {
        public AuthMethod() { }
        public User u;
        public KeySet ks;
        public string description;
        public int number_of_keys;
        public string WindowsPassword; // REAL windows password
    }
}
