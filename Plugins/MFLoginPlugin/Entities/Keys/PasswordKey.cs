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
        public override bool AddKey(string userName = "")
        {
            PasswordManagementForm pmf = new PasswordManagementForm(userName);
            pmf.ShowDialog();
			if (!pmf.IsValid) return false;
			Password = Shared.Hashed(pmf.Password+KID+Type);
			Description = pmf.Description;
			Inverted = pmf.Inverted;
			return true;
        }
		public override bool CheckKey(string password) {
			bool success = false;
			success = (Shared.Hashed(password+KID+Type) == Password);
			if (Inverted) success = !success;
			log4net.LogManager.GetLogger("MFLoginPlugin").Info("Password "+Description+"; Inverted: "+Inverted+"; Success: "+success);
			return success;
		}
    }
}