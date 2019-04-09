using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Management;
using log4net;
using pGina.Plugin.MFLoginPlugin.Entities.ManagementForms;
using System.Security.Cryptography;
using System.Security;

namespace pGina.Plugin.MFLoginPlugin.Entities.Keys
{
    class ETokenKey : Key
    {
        private static ILog m_logger = LogManager.GetLogger("MFLoginPlugin");
        public ETokenKey(UInt64 kid) : base(kid) { Type = "ETokenKey"; }
        public override bool AddKey(string userName = "")
        {
            ETokenKeyManagementForm umf = new ETokenKeyManagementForm(userName);
            umf.ShowDialog();
            if (!umf.IsValid) return false;
            Serial = umf.Name;
			Password = umf.Source; //text
			Data = umf.Result;  // signature
            Description = umf.Description;
            Inverted = umf.Inverted;
            return true;
        }
        public override bool CheckKey(string password)
        {
            bool success = false;
			try
			{
				CspParameters csp = new CspParameters(1, "eToken Base Cryptographic Provider")
				{
					Flags = CspProviderFlags.UseDefaultKeyContainer,
				};
				RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(csp);
				byte[] sig = Convert.FromBase64String(Data);
				byte[] data = Encoding.UTF8.GetBytes(Password);
				// Verify the data using the Smart Card CryptoGraphic Provider.
				success = rsa.VerifyData(data, "SHA1", sig);
			}catch(Exception ex) { m_logger.Error(ex.Message); }
			if (Inverted) success = !success;
            m_logger.Info("ETokenKey " + Description + "; Inverted: " + Inverted + "; Success: " + success);
            return success;
        }
    }
}
