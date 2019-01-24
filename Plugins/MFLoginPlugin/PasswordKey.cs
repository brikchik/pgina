using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pGina.Plugin.MFLoginPlugin
{
    class PasswordKey: IKey
    {
        private string Password = "";
        private string Type = "Password";
        
        string[] IKey.GetInfo() { return new String[] { Type, Password }; }// !!!!!!!!!!
        string IKey.Type() { return Type; }
        void IKey.AddKey(string newPassword) { Password = newPassword; }// !!!!!!!!!!! has to be done in form
        
        bool IKey.CheckKey(string password) { return (password==Password); } // !!!!!!!!!!
        
    }
}
