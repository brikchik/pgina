using pGina.Plugin.MFLoginPlugin.Entities.Keys;
using pGina.Plugin.MFLoginPlugin.Entities;
using pGina.Plugin.MFLoginPlugin.Entities.KeyManagementForms;
using pGina.Shared.Settings;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Security.Cryptography;
using log4net;
using System.Threading;

namespace pGina.Plugin.MFLoginPlugin
{
    public partial class LocalConfiguration : Form
    {
        dynamic m_settings = new pGinaDynamicSettings(MFLoginPlugin.SimpleUuid);
		private static ILog m_logger = LogManager.GetLogger("MFLoginPlugin");
		public LocalConfiguration()
        {
			DBHelper.ConnectLocalDB("C:\\MFLoginDB.db", "");
			InitializeComponent();
			LoadData();
			this.ShowDialog();
		}

		private void LoadData()
		{
			User[] users = DBHelper.ReadUsers();
			userListBox.Items.AddRange(users);
			bool interfaceState = false;
			if (users.Length != 0)
			{
				userListBox.SelectedIndex = 0;
				interfaceState = true;
			}
			newAuthMethod_button.Enabled = interfaceState;
			removeAuthMethod_button.Enabled = interfaceState;
			key1Button.Enabled = interfaceState;
			key2Button.Enabled = interfaceState;
			key3Button.Enabled = interfaceState;
			key4Button.Enabled = interfaceState;
			key5Button.Enabled = interfaceState;
			keysRequired_NumUpDown.Enabled = interfaceState;
			keepPassword_checkBox.Enabled = interfaceState;
			authMethods_listBox.Enabled = interfaceState;

			keysListBox.Items.AddRange(DBHelper.ReadKeys());
			/*
			PasswordKey pk = new PasswordKey(10)
			{
				Description = "pk1"
			};
			pk.Save();
			ListViewItem lvi = new ListViewItem("key1_password")
			{
				Tag = pk.KID
			};
			fastChoiceKeys_listView.Items.Add(lvi);
			ConnectedDevice usbd = new ConnectedDevice
			{
				Description = "usb1"
			};
			usbd.Save();
			lvi = new ListViewItem("key2_usbd")
			{
				Tag = usbd.KID
			};
			fastChoiceKeys_listView.Items.Add(lvi);

			lvi = new ListViewItem("type_usbd")
			{
				Tag = "ConnectedDevice"
			};
			fastChoiceTypes_listView.Items.Add(lvi);
			*/
		}

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void runSetup_button_Click(object sender, EventArgs e)
        {
            FirstRun fr = new FirstRun(true, false);
            this.Close();
        }

        private void newPassword_button_Click(object sender, EventArgs e)
        {
            Key pk = new PasswordKey();
            pk.AddKey();
        }

        private void newUSB_button_Click(object sender, EventArgs e)
        {
            Key usbd = new ConnectedDevice();
            usbd.AddKey();
        }

        private void newBluetooth_button_Click(object sender, EventArgs e)
        {

        }

        private void русскийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // !!!!! set language
        }

		private void englishToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// !!!!! set language
		}
		private void SaveAuthMethod()
		{
			try
			{
				AuthMethod am = (AuthMethod)authMethods_listBox.SelectedItem;
				am.K1 = (Key)key1Button.Tag;
				am.K2 = (Key)key2Button.Tag;
				am.K3 = (Key)key3Button.Tag;
				am.K4 = (Key)key4Button.Tag;
				am.K5 = (Key)key5Button.Tag;
			}
			catch { m_logger.Debug("Unable to save auth method"); }
		}
        /// <summary>
        /// this code creates the Drag&Drop effect for keys
        /// </summary>
        private int indexOfItemUnderMouseToDrag;
        private Rectangle dragBoxFromMouseDown;
        private Point screenOffset;
        private void DragSource_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            indexOfItemUnderMouseToDrag = fastChoiceTypes_listView.Items.IndexOf(fastChoiceTypes_listView.GetItemAt(e.X, e.Y)); //get element index
            if (indexOfItemUnderMouseToDrag != ListBox.NoMatches)
            {
                Size dragSize = SystemInformation.DragSize;// check if mouse moves far enough
                dragBoxFromMouseDown = new Rectangle(new Point(e.X - (dragSize.Width / 2), e.Y - (dragSize.Height / 2)), dragSize);
            }
            else
                dragBoxFromMouseDown = Rectangle.Empty; // ignore drag if nothing is selected
        }
        private void DragSource_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
			Cursor.Current = Cursors.Default;
            dragBoxFromMouseDown = Rectangle.Empty;// release cursor on mouse up
        }
        private void DragSource_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                // start drag case the cursor is out of source element
                if (dragBoxFromMouseDown != Rectangle.Empty &&
                    !dragBoxFromMouseDown.Contains(e.X, e.Y))
                {
					Cursor.Current = Cursors.SizeAll;
                    screenOffset = SystemInformation.WorkingArea.Location;// screenOffset служит для определения границ экрана
                    DragDropEffects dropEffect = fastChoiceTypes_listView.DoDragDrop(fastChoiceTypes_listView.Items[indexOfItemUnderMouseToDrag], DragDropEffects.All);
                }
            }
        }
        private void DragTarget_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            Object item = e.Data.GetData(typeof(System.Windows.Forms.ListViewItem));// check if object is empty
            if (e.Effect == DragDropEffects.Move)
            {
				ListViewItem lvi=(ListViewItem)item;
				string label;
				if (lvi.Tag is String) label = lvi.Tag.ToString();
				else
					label = ((Key)lvi.Tag).GetType();
				if (sender == key1Button) key1Button.Text = label;else
				if (sender == key2Button) key2Button.Text = label;else
				if (sender == key3Button) key3Button.Text = label;else
				if (sender == key4Button) key4Button.Text = label;else
				if (sender == key5Button) key5Button.Text = label;
				ulong kid = 0; // number is key ID, string is a type
				ulong.TryParse(lvi.Tag.ToString(), out kid);
				if (kid != 0) ((Button)sender).Tag = lvi.Tag;
				else
				{
					KeySelectionForm ksf = new KeySelectionForm(label);
					((Button)sender).Tag = ksf.Key;
				}
				SaveAuthMethod();
				// Chosen key class (or null) is stored in the TAG field of button.
            }
        }
		private void DragTarget_DragDropKey(object sender, System.Windows.Forms.DragEventArgs e)
		{
			Object item = e.Data.GetData(typeof(System.Windows.Forms.ListViewItem));// check if object is empty
			if (e.Effect == DragDropEffects.Move)
			{
				ListViewItem lvi = (ListViewItem)item;
				Key key = (Key)lvi.Tag;
				if (sender == key1Button) key1Button.Text = key.GetType();
				else
				if (sender == key2Button) key2Button.Text = key.GetType();
				else
				if (sender == key3Button) key3Button.Text = key.GetType();
				else
				if (sender == key4Button) key4Button.Text = key.GetType();
				else
				if (sender == key5Button) key5Button.Text = key.GetType();
				((Button)sender).Tag = key;
				SaveAuthMethod();
				// Chosen key class (or null) is stored in the TAG field of button.
			}
		}
		private void DragTarget_DragOver(object sender, System.Windows.Forms.DragEventArgs e)
        {
            if ((e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move)
            { e.Effect = DragDropEffects.Move; }
            else e.Effect = DragDropEffects.None;
        }

		private void authConfig_Enter(object sender, EventArgs e)
		{
			
		}
		private void OpenKeyConfig(object sender, EventArgs e)
		{
			((Button)sender).Tag = null;
			((Button)sender).Text = "_____";
			SaveAuthMethod();
			// is it a good idea?
			// !!!! KeySelectionForm ksf = new KeySelectionForm(((Button)sender).Text);
		}
		private void controlPanel_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		private void userListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			newAuthMethod_button.Enabled = true;
			removeAuthMethod_button.Enabled = true;
			key1Button.Enabled = true;
			key2Button.Enabled = true;
			key3Button.Enabled = true;
			key4Button.Enabled = true;
			key5Button.Enabled = true;
			keysRequired_NumUpDown.Enabled = true;
			keepPassword_checkBox.Enabled = true;
			authMethods_listBox.Enabled = true;
			try
			{

				authMethods_listBox.Items.Clear();
				User user = (User)userListBox.SelectedItem;
				userName_textBox.Text = user.Name;
				role_textBox.Text = user.Role;
				AuthMethod[] authMethods = DBHelper.GetAuthMethods(user);
				AuthMethod currentAuthMethod;
				if (authMethods.Length == 0)
				{
					currentAuthMethod = new AuthMethod();
					authMethods_listBox.Items.Add(currentAuthMethod);
				}
				else
				{
					authMethods_listBox.Items.AddRange(authMethods);
					currentAuthMethod = authMethods[0];
				}
				authMethods_listBox.SelectedIndex = 0;
				if (user.WindowsPassword != null) keepPassword_checkBox.CheckState = CheckState.Checked;
					else keepPassword_checkBox.CheckState = CheckState.Unchecked;
			}
			catch {
				newAuthMethod_button.Enabled = false;
				removeAuthMethod_button.Enabled = false;
				key1Button.Enabled = false;
				key2Button.Enabled = false;
				key3Button.Enabled = false;
				key4Button.Enabled = false;
				key5Button.Enabled = false;
				keysRequired_NumUpDown.Enabled = false;
				keepPassword_checkBox.Enabled = false;
				authMethods_listBox.Enabled = false;
			}
		}

		private void keepPassword_checkBox_Click(object sender, EventArgs e)
		{
			if (((CheckBox)sender).CheckState == CheckState.Unchecked)
			{
				DialogResult dr = MessageBox.Show("Do you want to remove password from the OS?\nYou will not be able to LOG IN if you LOSE OR ERASE YOUR KEY\n\nI KNOW WHAT I AM DOING", "Stored password removal", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
				if (dr.Equals(DialogResult.Yes))
				{
					((CheckBox)sender).CheckState = CheckState.Unchecked;
					((User)userListBox.SelectedItem).WindowsPassword = null;
				}
				else
					((CheckBox)sender).CheckState = CheckState.Checked;
			}
			else
			{
				DialogResult dr = MessageBox.Show("Do you want to create new password?\nOld keys WILL NOT WORK after this operation\n\nI KNOW WHAT I AM DOING", "New password creation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
				if (dr.Equals(DialogResult.Yes))
				{
					((CheckBox)sender).CheckState = CheckState.Checked;
					((User)userListBox.SelectedItem).WindowsPassword = Key.GetUniqueKey(128); // generate new windows password
					((User)userListBox.SelectedItem).Save();
					Shared.RunConsoleCommand("net user "+ ((User)userListBox.SelectedItem).Name+" "+ ((User)userListBox.SelectedItem).WindowsPassword);
					// !!!! not the best solution
				}
				else
					((CheckBox)sender).CheckState = CheckState.Unchecked;
			}
		}

		private void fastChoiceTypes_listView_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void authMethods_listBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				AuthMethod am = (AuthMethod)authMethods_listBox.SelectedItem;
				if (am.K1 != null) { key1Button.Tag = am.K1; key1Button.Text = am.K1.GetType() + "\n" + am.K1; } else key1Button.Text = "______";
				if (am.K2 != null) { key2Button.Tag = am.K2; key2Button.Text = am.K2.GetType() + "\n" + am.K2; } else key2Button.Text = "______";
				if (am.K3 != null) { key3Button.Tag = am.K3; key3Button.Text = am.K3.GetType() + "\n" + am.K3; } else key3Button.Text = "______";
				if (am.K4 != null) { key4Button.Tag = am.K4; key4Button.Text = am.K4.GetType() + "\n" + am.K4; } else key4Button.Text = "______";
				if (am.K5 != null) { key5Button.Tag = am.K5; key5Button.Text = am.K5.GetType() + "\n" + am.K5; } else key5Button.Text = "______";
				keysRequired_NumUpDown.Value = am.Number_of_keys;
			}
			catch { }
		}

		private void removeUser_button_Click(object sender, EventArgs e)
		{
			try
			{
				((User)userListBox.SelectedItem).Remove();
				userListBox.Items.Remove(userListBox.SelectedItem);
				if (userListBox.Items.Count > 0) userListBox.SelectedIndex = 0;
				// we don't want to remove auth_methods to make logging easier
			}
			catch { }
		}

		private void addUser_button_Click(object sender, EventArgs e)
		{

		}

		private void keysRequired_NumUpDown_ValueChanged(object sender, EventArgs e)
		{
			((AuthMethod)authMethods_listBox.SelectedItem).Number_of_keys = (int)keysRequired_NumUpDown.Value;
			((AuthMethod)authMethods_listBox.SelectedItem).Save();
		}

		private void newAuthMethod_button_Click(object sender, EventArgs e)
		{
			AddMethod();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (authMethods_listBox.Items.Count <=1)
			{
				AddMethod();
			}
			((AuthMethod)authMethods_listBox.SelectedItem).Delete();
			authMethods_listBox.Items.Remove(authMethods_listBox.SelectedItem);
			authMethods_listBox.SelectedIndex = 0;
		}
		private void AddMethod() {
			AuthMethod am = new AuthMethod((User)userListBox.SelectedItem);
			authMethods_listBox.Items.Add(am);
			am.Number_of_keys = 5;
			am.Save();
			authMethods_listBox.SelectedItem = am;
		}
	}
}