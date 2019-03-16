using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SQLite;
using pGina.Plugin.MFLoginPlugin.Entities.ManagementForms;
namespace pGina.Plugin.MFLoginPlugin.Entities.Keys
{
    class PasswordKey: Key
    {
		public PasswordKey(ulong kid):base(kid){ Type = "Password"; } // specific key
		public PasswordKey():base(0) { Type = "Password"; } // empty key
        public override bool AddKey() {
            PasswordManagementForm pmf = new PasswordManagementForm(KID);
            pmf.ShowDialog();
			if (!pmf.IsValid) return false;
            Password = pmf.NewPassword;
			Description = pmf.NewDescription;
			Inverted = pmf.Inverted;
			return true;
        }
		public override bool CheckKey(string password) {
			bool success = false;
			success = (password == Password);
			if (Inverted) success = !success;
			log4net.LogManager.GetLogger("MFLoginPlugin").Debug("Password "+Description+"; Inverted: "+Inverted+"; Success: "+success);
			return success;
		} // !!!!
    }
}