using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pGina.Plugin.MFLoginPlugin
{
    interface IKey
    {
        // each key has to provide a key creation window
        UInt64 KID();
        string[] GetInfo();
        string Type();
        void AddKey(string password); // #obsolete !!!!! for removal
        void AddKey(); // management form
        bool CheckKey(string password);
        // All _keys_ behave similarly

        //key may contain windows password
        string ReturnPassword();
    }
}
