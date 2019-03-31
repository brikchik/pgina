using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using pGina.Plugin.MFLoginPlugin.Entities.Keys;
namespace pGina.Plugin.MFLoginPlugin.Entities.ManagementForms
{
    public partial class PasswordManagementForm : Form
    {
        public PasswordManagementForm(string userName)
        {
            InitializeComponent();
            description_textBox.Text += " for " + userName;
        }
		public string Password;
		public string Description;
		public bool Inverted;
		public bool IsValid = false;
        private bool validPasswords = false;
        private void checkPasswords(object sender, EventArgs e)
        {
            string pass1 = password_textBox1.Text;
            string pass2 = password_textBox2.Text;
            if (pass1 != pass2)
            {
                temp_label.Text = "Passwords don't match!";
            }
            else
            {
                validPasswords = true;
                temp_label.Text = "Passwords match";
            }
        }
        private void create_password_button_Click(object sender, EventArgs e)
        {
            if (validPasswords)
            {
                Password = password_textBox1.Text;
				Description = description_textBox.Text;
				Inverted = inverted_checkBox.Checked;
				IsValid = true;
				this.Close();
            }
        }
    }
}
