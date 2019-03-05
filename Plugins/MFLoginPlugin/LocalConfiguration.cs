using log4net;
using pGina.Plugin.MFLoginPlugin.Entities;
using pGina.Plugin.MFLoginPlugin.Entities.Keys;
using pGina.Plugin.MFLoginPlugin.Entities.ManagementForms;
using pGina.Shared.Settings;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
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
			ShowDialog();
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
			// loading keys for Keys tab in advance
			Thread keysUpdateThread = new Thread(UpdateKeyList);
			keysUpdateThread.Start();
		}

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
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
			AuthMethod am = (AuthMethod)authMethods_listBox.SelectedItem;
			try { am.K1 = Key.DefineKey((ulong)key1Button.Tag); } catch { }
			try { am.K2 = Key.DefineKey((ulong)key2Button.Tag); } catch { }
			try { am.K3 = Key.DefineKey((ulong)key3Button.Tag); } catch { }
			try { am.K4 = Key.DefineKey((ulong)key4Button.Tag); } catch { }
			try { am.K5 = Key.DefineKey((ulong)key5Button.Tag); } catch { }
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
				Key key = Key.DefineKey(lvi.Tag.ToString());
				if (key == null)
				{
					m_logger.Debug("Unable to create key of type: "+lvi.Tag.ToString());
					return;
				}
				if (!key.AddKey()) return;
				string label = key.GetType() + '\n' + key.Description;
				if (sender == key1Button) { key1Button.Text = label; key1Button.Tag = key.KID; }
				else
				if (sender == key2Button) { key2Button.Text = label; key2Button.Tag = key.KID; }
				else
				if (sender == key3Button) { key3Button.Text = label; key3Button.Tag = key.KID; }
				else
				if (sender == key4Button) { key4Button.Text = label; key4Button.Tag = key.KID; }
				else
				if (sender == key5Button) { key5Button.Text = label; key5Button.Tag = key.KID; }
				else
					MessageBox.Show("Unknown target");
				// write changes to database
				m_logger.Debug("Saving new key to DB: "+key.KID+' '+sender.GetType().ToString());
				key.Save();
				SaveAuthMethod();
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
			((Button)sender).Text = "";
			SaveAuthMethod();
			// is it a good idea?
			// !!!! KeySelectionForm ksf = new KeySelectionForm(((Button)sender).Text);
		}
		private void controlPanel_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}
		private void RefreshAuthMethods()
		{
			try
			{
				authMethods_listBox.Items.Clear();
				User user = (User)userListBox.SelectedItem;
				userName_textBox.Text = user.Name;
				role_textBox.Text = user.Role;
				AuthMethod[] authMethods = DBHelper.GetAuthMethods(user);
				if (authMethods.Length == 0)
				{
					authMethods_listBox.Items.Add(new AuthMethod(user));
				}
				else
				{
					authMethods_listBox.Items.AddRange(authMethods);
				}
				authMethods_listBox.SelectedIndex = 0;
				if (user.WindowsPassword != null) keepPassword_checkBox.CheckState = CheckState.Checked;
				else keepPassword_checkBox.CheckState = CheckState.Unchecked;
			}
			catch
			{
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
				description_textBox.Enabled = false;
				fastChoiceTypes_listView.Enabled = false;
			}
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
			description_textBox.Enabled = true;
			fastChoiceTypes_listView.Enabled = true;
			RefreshAuthMethods();
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
					((User)userListBox.SelectedItem).NewPassword();
					if (!(((User)userListBox.SelectedItem).Name.All(c => Char.IsLetterOrDigit(c) || c == '_')))
					{
						MessageBox.Show("Name has to contain letters, numbers or _");
					}
				}
				else
					((CheckBox)sender).CheckState = CheckState.Unchecked;
			}
		}

		private void fastChoiceTypes_listView_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
		private void UpdateKeys()
		{
			AuthMethod am = (AuthMethod)authMethods_listBox.SelectedItem;
			try { key1Button.Tag = am.K1; key1Button.Text = am.K1.Description; } catch { key1Button.Text = ""; }
			try { key2Button.Tag = am.K2; key2Button.Text = am.K2.Description; } catch { key2Button.Text = ""; }
			try { key3Button.Tag = am.K3; key3Button.Text = am.K3.Description; } catch { key3Button.Text = ""; }
			try { key4Button.Tag = am.K4; key4Button.Text = am.K4.Description; } catch { key4Button.Text = ""; }
			try { key5Button.Tag = am.K5; key5Button.Text = am.K5.Description; } catch { key5Button.Text = ""; }
			try { keysRequired_NumUpDown.Value = am.Number_of_keys; } catch { }// no AuthMethod chosen
			try { description_textBox.Text = am.Description; } catch { }// no AuthMethod chosen
		}
		private void authMethods_listBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateKeys();
		}

		private void removeUser_button_Click(object sender, EventArgs e)
		{
			try
			{
				User user=(User)userListBox.SelectedItem;
				if (!user.RemoveFromSystem())MessageBox.Show("Unable to remove user from system");
				user.Remove();
				userListBox.Items.Remove(userListBox.SelectedItem);
				if (userListBox.Items.Count > 0) userListBox.SelectedIndex = 0;
			}
			catch (Exception ex){ m_logger.Error(ex.Message); }
		}

		private void addUser_button_Click(object sender, EventArgs e)
		{
			UserManagementForm addUserForm = new UserManagementForm();
			addUserForm.ShowDialog();
			if (addUserForm.IsValid)
			{
				userListBox.Items.Add(addUserForm.NewUser);
				userListBox.SelectedItem = addUserForm.NewUser;
			}
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

		private void fastChoiceTypes_listView_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			// key has to be added to a free slot (1-5)
			Key key = Key.DefineKey(fastChoiceTypes_listView.SelectedItems[0].Tag.ToString());
			if (key == null)
			{
				m_logger.Debug("Unable to create key of type: " + fastChoiceTypes_listView.SelectedItems[0].Tag.ToString());
				return;
			}
			bool created = false;
			int buttonNumber = 0;
			if (key1Button.Tag == null && !created) { created = true; buttonNumber = 1; }
			if (key2Button.Tag == null && !created) { created = true; buttonNumber = 2; }
			if (key3Button.Tag == null && !created) { created = true; buttonNumber = 3; }
			if (key4Button.Tag == null && !created) { created = true; buttonNumber = 4; }
			if (key5Button.Tag == null && !created) { created = true; buttonNumber = 5; }
			if (!created)
			{
				MessageBox.Show("No free key slot.", "Key creation", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
				return;
			}
			if (!key.AddKey()) return; // key creation form
			key.Save();
			switch (buttonNumber) {
				case 1: key1Button.Text = key.Description; key1Button.Tag = key.KID; break;
				case 2: key2Button.Text = key.Description; key2Button.Tag = key.KID; break;
				case 3: key3Button.Text = key.Description; key3Button.Tag = key.KID; break;
				case 4: key4Button.Text = key.Description; key4Button.Tag = key.KID; break;
				case 5: key5Button.Text = key.Description; key5Button.Tag = key.KID; break;
			}
			SaveAuthMethod();
		}

		private void fastChoiceKeys_listView_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
		private void UpdateKeyList()
		{
			Key[] keys = DBHelper.ReadKeys();
			keysListBox.Items.Clear();
			keysListBox.Items.AddRange(keys);
		}
		private void removeUnusedKeys_button_Click(object sender, EventArgs e)
		{
			try
			{
				DBHelper.RemoveUnusedKeys();
				UpdateKeyList();
			}
			catch (Exception exception){ m_logger.Error("Unable to remove unused keys: "+exception.Message); }
		}

		private void refreshKeyList_button_Click(object sender, EventArgs e)
		{
			UpdateKeyList();
		}

		private void description_textBox_TextChanged(object sender, EventArgs e)
		{
			((AuthMethod)authMethods_listBox.SelectedItem).Description = description_textBox.Text;
			((AuthMethod)authMethods_listBox.SelectedItem).Save();
		}

		private void changeRole_contextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			((User)userListBox.SelectedItem).Role = e.ClickedItem.Text;
			((User)userListBox.SelectedItem).MakeAdmin(e.ClickedItem.Text=="Administrator");
			((User)userListBox.SelectedItem).Save();
			role_textBox.Text = e.ClickedItem.Text;
		}

		private void userListBox_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				int currentIndex = userListBox.IndexFromPoint(e.Location);
				if (currentIndex != -1)
				{
					Point p=e.Location;
					p = PointToScreen(p);
					p.Offset(0, changeRole_contextMenuStrip.Size.Height);
					changeRole_contextMenuStrip.Select();
					changeRole_contextMenuStrip.Show(p);
					userListBox.SelectedIndex = currentIndex;
				}
			}
		}

		private void key4Label_Click(object sender, EventArgs e)
		{

		}

		private void keyInfo_Enter(object sender, EventArgs e)
		{

		}

		private void keysListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			Key key = (Key)keysListBox.SelectedItem;
			keyDescription_textBox.Text = key.Description;
			keyType_label.Text = key.GetType();
			keyInverted_checkBox.Checked = key.Inverted;

			keySerial_checkBox.Checked = (key.Serial != null);
			keyPassword_checkBox.Checked = (key.Password != null);
			keyData_checkBox.Checked = (key.Data != null);
			keyConfigure_button.Enabled = key.IsConfigurable;
		}

		private void keyDescription_textBox_TextChanged(object sender, EventArgs e)
		{
			Key key = (Key)keysListBox.SelectedItem;
			key.Description = keyDescription_textBox.Text;
			key.Save();
		}

		private void keyInverted_checkBox_CheckedChanged(object sender, EventArgs e)
		{
			Key key = (Key)keysListBox.SelectedItem;
			key.Inverted = keyInverted_checkBox.Checked;
			key.Save();
		}

		private void tabPage3_Click(object sender, EventArgs e)
		{

		}

		private void keyConfigure_button_Click(object sender, EventArgs e)
		{
			((Key)keysListBox.SelectedItem).Configure();
		}

		private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
		{
		}
	}
}