using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using pGina.Plugin.MFLoginPlugin;
using log4net;
namespace pGina.Plugin.MFLoginPlugin.Entities.ManagementForms
{
	public partial class UserManagementForm : Form
	{
		public bool IsValid = false;
		private static ILog m_logger = LogManager.GetLogger("MFLoginPlugin");
		public UserManagementForm()
		{
			InitializeComponent();
		}

		internal User NewUser { get; set; }

		private void AddUserForm_Load(object sender, EventArgs e)
		{

		}
		private bool correct = false;
		private void addUser_button_Click(object sender, EventArgs e)
		{
			if (correct)
			{
				NewUser = new User();
				NewUser.WindowsPassword = Shared.GetUniqueKey(100); // random password for every user
				// password may be stored in key afterwards
				NewUser.Name = username_textBox.Text;
				if (user_radioButton.Checked) NewUser.Role = "User";
				else if (administrator_radioButton.Checked) NewUser.Role = "Administrator";

				bool isAdmin = ((NewUser.Role == "Administrator") ? true : false);
				bool success = false;
				if (!NewUser.ExistsInSystem()) success=NewUser.AddToSystem();
				NewUser.MakeAdmin(isAdmin);
				if (success) NewUser.Save();
				IsValid = true;
			}
			Close();
		}

		private void username_textBox_TextChanged(object sender, EventArgs e)
		{
			if (!(username_textBox.Text.All(c => char.IsLetterOrDigit(c) || c == '_')))
			{
				userNameCorrect_label.Text = "User name should contain letters, numbers or '_'";
				correct = false;
			}
			else
			{
				userNameCorrect_label.Text = "Everything looks OK";
				correct = true;
			}
		}
	}
}
