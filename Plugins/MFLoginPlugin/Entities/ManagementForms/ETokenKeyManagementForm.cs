using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace pGina.Plugin.MFLoginPlugin.Entities.ManagementForms
{
    public partial class ETokenKeyManagementForm : Form
    {
		private static ILog m_logger = LogManager.GetLogger("MFLoginPlugin");
		public string Description = "eToken";
		public string Source = null; // random string
		public string Result = null; // eToken certificate sign
		public new string Name = null;
		public bool Inverted = false;
		public bool IsValid = false;
		public ETokenKeyManagementForm(string userName)
		{
			InitializeComponent();
			description_textBox.Text = Description;
			description_textBox.Text += " for " + userName;
            createdKeys_listBox.Items.AddRange(DBHelper.ReadKeys("ETokenKey"));
		}
		private void ok_button_Click(object sender, EventArgs e)
		{
			Description = description_textBox.Text;
			Inverted = inverted_checkBox.Checked;
			bool verified = false;
			try
			{
				// Initialize an RSACryptoServiceProvider object using the CspParameters object.
				CspParameters csp = new CspParameters(1, "eToken Base Cryptographic Provider")
				{
					Flags = CspProviderFlags.UseDefaultKeyContainer,
				};
				name_textBox.Text = csp.KeyContainerName;
				Name = csp.KeyContainerName;
				RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(csp);
				// Get some data to sign.
				Source = Shared.GetUniqueKey(128);
				byte[] data = Encoding.ASCII.GetBytes(Source);
				// Sign the data using the Smart Card CryptoGraphic Provider.
				byte[] sig = rsa.SignData(data, "SHA1");
				// Verify the data using the Smart Card CryptoGraphic Provider.
				verified = rsa.VerifyData(data, "SHA1", sig);
				Result = Convert.ToBase64String(sig);
			}
			catch (Exception ex) { m_logger.Debug(ex.Message); }
			if (Result != null && verified)
			{
				IsValid = true;
				Close();
			}
		}

        private void createdKeys_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Key key = ((Key)createdKeys_listBox.SelectedItem);
            name_textBox.Text = key.Serial;
            Name = key.Serial;
            inverted_checkBox.Checked = key.Inverted;
            Inverted = key.Inverted;
            description_textBox.Text = key.Description;
            Description = key.Description;
            Source = key.Password;
            Result = key.Data;
            if (Result != null)
            {
                IsValid = true;
                Close();
            }
        }
	}
}
