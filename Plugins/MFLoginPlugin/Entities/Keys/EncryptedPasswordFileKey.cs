using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using pGina.Plugin.MFLoginPlugin.Entities.ManagementForms;
using log4net;
using System.IO;
using System.Windows.Forms;

namespace pGina.Plugin.MFLoginPlugin.Entities.Keys
{
    class EncryptedPasswordFileKey : Key
    {
        private static ILog m_logger = LogManager.GetLogger("MFLoginPlugin");
        private bool SavePassword = false;
		private string WindowsPassword = null;
		public EncryptedPasswordFileKey(ulong kid):base(kid)
		{
			Type = "EncryptedPasswordFileKey";
			IsConfigurable = true;
		}
        public override bool AddKey(string userName) {
            EncryptedPasswordFileKeyManagementForm epfkmf = new EncryptedPasswordFileKeyManagementForm(userName);
            epfkmf.ShowDialog();
            if (!epfkmf.IsValid) return false;
            Serial = epfkmf.Path;
            Password = Shared.Hashed(epfkmf.Password);
            Description = epfkmf.Description;
            Inverted = epfkmf.Inverted;
            SavePassword = epfkmf.SavePassword;

			try
			{
				User user = new User();
				user.FillByName(userName);
				if (user.WindowsPassword == null || user.WindowsPassword == "") return false;
				FileInfo fileInfo = new FileInfo(Serial);
				string source = user.WindowsPassword + fileInfo.Name;
				fileInfo = null;
				string result = Shared.Encrypt(source, Password);
				File.WriteAllText(Serial, result);
			} catch (Exception ex){ m_logger.Error(ex.Message); return false; }
            if (!SavePassword) Password = null;
			return true;
        }

		public override bool CheckKey(string password) {
			bool success = false;

			string currentPassword="";
			if (Password == null || Password == "") currentPassword = Shared.Hashed(password); else currentPassword = Password;
			try
			{
				string source = File.ReadAllText(Serial);
				string result = Shared.Decrypt(source, currentPassword);
				// check name to make sure the file wasn't modified
				WindowsPassword = result.Substring(0, Shared.INTERNAL_USER_PASSWORD_LENGTH);
				string name = result.Substring(Shared.INTERNAL_USER_PASSWORD_LENGTH, result.Length - Shared.INTERNAL_USER_PASSWORD_LENGTH);
				if (Serial.EndsWith(name)) success = true;
			}
			catch (Exception ex) { m_logger.Error(ex.Message); success = false; }
			if (Inverted) success = !success;
			m_logger.Info("EncryptedPasswordFileKey "+Description+"; Inverted: "+Inverted+"; Success: "+success);
			return success;
		}
        public override string ReturnWindowsPassword()
        {
            return WindowsPassword;
        }

		public override void Configure()
		{
			OpenFileDialog fileDialog = new OpenFileDialog();
			fileDialog.Title = "Select new file location";
			fileDialog.ShowDialog();
			Serial = fileDialog.FileName;
		}
	}
}
