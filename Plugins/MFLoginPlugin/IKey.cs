using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pGina.Plugin.MFLoginPlugin
{
    interface IKey
    {
        string[] GetInfo();
        string Type();
        void AddKey(string password); //entered password is given to every key just in case
        bool CheckKey(string password);
        // All _keys_ behave similarly
    }
}
