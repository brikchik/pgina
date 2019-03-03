using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using pGina.Plugin.MFLoginPlugin.Entities.Keys;
namespace pGina.Plugin.MFLoginPlugin.Entities.KeyManagementForms
{
    public partial class PasswordManagementForm : Form
    {
        public PasswordManagementForm(ulong kid)
        {
            InitializeComponent();
			description_textBox.Text += kid;
        }
		public string NewPassword;
		public string NewDescription;
		public bool Inverted;
		public bool IsValid = false;
        private void create_password_button_Click(object sender, EventArgs e)
        {
            string pass1 = password_textBox1.Text;
            string pass2 = password_textBox2.Text;
            if (pass1 != pass2)
            {
                temp_label.Text = "Passwords don't match!";
                password_textBox1.Focus();
            }
            else
            {
                NewPassword = password_textBox1.Text;
				NewDescription = description_textBox.Text;
				Inverted = inverted_checkBox.Checked;
				IsValid = true;
				this.Close();
            }
        }
    }
}
