﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Windows.Forms;
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
		private bool correct = false;
		private void addUser_button_Click(object sender, EventArgs e)
		{
			if (correct)
			{
                // check if user exists already
                if (new User().FillByName(username_textBox.Text)) return;
				NewUser = new User();
				NewUser.WindowsPassword = Shared.GetUniqueKey(Shared.INTERNAL_USER_PASSWORD_LENGTH); // random password for every user
				// password may be stored in key afterwards
				NewUser.Name = username_textBox.Text;
				if (user_radioButton.Checked) NewUser.Role = "User";
				else if (administrator_radioButton.Checked) NewUser.Role = "Administrator";

				bool isAdmin = ((NewUser.Role == "Administrator") ? true : false);
				bool success = false;

                if (!NewUser.ExistsInSystem()) success = NewUser.AddToSystem(); else { success = true; NewUser.NewPassword(); NewUser.AddToPGina(); }
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
        private List<string> SystemUsers=new List<string>();
        private void AddUserForm_Load(object sender, EventArgs e)
        {
            ManagementObjectSearcher usersSearcher = new ManagementObjectSearcher(@"SELECT * FROM Win32_UserAccount");
            ManagementObjectCollection users = usersSearcher.Get();

            var localUsers = users.Cast<ManagementObject>().Where(
                u => (bool)u["LocalAccount"] == true &&
                     (bool)u["Disabled"] == false &&
                     (bool)u["Lockout"] == false &&
                     int.Parse(u["SIDType"].ToString()) == 1 &&
                     u["Name"].ToString() != "HomeGroupUser$");

            foreach (ManagementObject mo in localUsers)
            {
                SystemUsers.Add(mo["Name"].ToString());
            }
            systemUsers_listBox.Items.AddRange(SystemUsers.ToArray());
            pickUser_comboBox.Items.AddRange(SystemUsers.ToArray());
        }

        private void systemUsers_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (systemUsers_listBox.SelectedItem !=null) username_textBox.Text = systemUsers_listBox.SelectedItem.ToString();
        }

        private void pickUser_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pickUser_comboBox.SelectedItem != null && SystemUsers.Contains(pickUser_comboBox.SelectedItem.ToString())) username_textBox.Text = pickUser_comboBox.SelectedItem.ToString();
        }
	}
}
