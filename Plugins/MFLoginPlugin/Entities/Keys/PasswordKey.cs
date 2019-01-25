using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using pGina.Plugin.MFLoginPlugin.Entities.KeyManagementForms;
namespace pGina.Plugin.MFLoginPlugin.Entities.Keys
{
    class PasswordKey: IKey
    {
        private string Password = "";
        private string Type = "Password";
        UInt64 IKey.KID() { return 0; }
        
        string[] IKey.GetInfo() { return new String[] { Type, Password }; }// !!!!!!!!!!
        string IKey.Type() { return Type; }
        void IKey.AddKey(string newPassword) { Password = newPassword; }// !!!!!!!!!!! has to be done in form
        void IKey.AddKey() {
            PasswordManagementForm pmf = new PasswordManagementForm();
            pmf.ShowDialog();
        }
        bool IKey.CheckKey(string password) { return (password==Password); } // !!!!!!!!!!

        string IKey.ReturnPassword() { return Password; }  // !!!!!!!!!

    }
}
