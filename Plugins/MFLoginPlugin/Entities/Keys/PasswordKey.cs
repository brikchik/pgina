using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SQLite;
using pGina.Plugin.MFLoginPlugin.Entities.KeyManagementForms;
namespace pGina.Plugin.MFLoginPlugin.Entities.Keys
{
    class PasswordKey: Key
    {
		public PasswordKey(ulong kid):base(kid){ Type = "Password"; } // specific key
		public PasswordKey():base(0) { Type = "Password"; } // empty key
        public new string[] GetInfo() { return new String[] { Type, Password }; }// !!!!!!!!!!
        public void AddKey(string newPassword) { Password = newPassword; }// has to be done in form
        public new void AddKey() {
            PasswordManagementForm pmf = new PasswordManagementForm();
            pmf.ShowDialog();
            Password = pmf.NewPassword;
        }
		public override bool CheckKey(string password) { return (password==Password); } // !!!!!!!!!! hash
    }
}