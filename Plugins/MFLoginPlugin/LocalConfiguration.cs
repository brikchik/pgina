using System;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using log4net;
using pGina.Plugin.MFLoginPlugin.Entities;
using pGina.Plugin.MFLoginPlugin.Entities.ManagementForms;
using pGina.Shared.Settings;
using pGina.Shared.Types;
using System.Threading;

namespace pGina.Plugin.MFLoginPlugin
{
    public partial class LocalConfiguration : Form
    {
        dynamic m_settings = new pGinaDynamicSettings(MFLoginPlugin.SimpleUuid);
        private static ILog m_logger = LogManager.GetLogger("MFLoginPlugin");
        private bool databaseLoaded = false;
        public LocalConfiguration()
        {
            InitializeComponent();
            database_label.Text = @"Please use the setup dialog to change database path.
Current database path: ";
            database_label.Text += (string)m_settings.LocalDatabasePath;
            string DBPassword = Encoding.ASCII.GetString(ProtectedData.Unprotect((byte[])m_settings.DBPassword, (byte[])m_settings.DBPasswordSalt, DataProtectionScope.LocalMachine));
            DBHelper.ConnectOrCreateLocalDB((string)m_settings.LocalDatabasePath, DBPassword);
            bool connectionSuccess = DBHelper.CheckDatabase();
            if (connectionSuccess) databaseLoaded = true;
            else
            {
                databaseLoaded = false;
                advancedSettings_tabPage.Text = "PROBLEMS WITH DATABASE";
                tabControl.SelectTab(advancedSettings_tabPage);
            }
            ShowDialog();
        }
        private void UpdateUserList()
        {
            successPictureBox.Visible = false;
            if (!databaseLoaded) return;
            user_ListBox.Items.Clear();
            User[] users = DBHelper.ReadUsers();
            user_ListBox.Items.AddRange(users);
            if (users.Length != 0)
            {
                user_ListBox.SelectedIndex = 0;
                switchUserInfoInterface(true);
            }
            else
                switchUserInfoInterface(false);
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void runSetup_button_Click(object sender, EventArgs e)
        {
            FirstRun fr = new FirstRun();
            Close();
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
                successPictureBox.Visible = false;
                ListViewItem lvi = (ListViewItem)item;
                Key key = Key.DefineKey(lvi.Tag.ToString());
                if (key == null)
                {
                    m_logger.Debug("Unable to create key of type: " + lvi.Tag.ToString());
                    return;
                }
                try
                {
                    if (!key.AddKey(userName_textBox.Text)) return;
                }
                catch (Exception ex){ m_logger.Error("unable to create key: "+ex.Message); return; }
                key.Save();
                string label = key.ToString();
                AuthMethod am = (AuthMethod)authMethods_listBox.SelectedItem;
                if (key1Button == sender) { key1Button.Text = label; key1Button.Tag = key.KID; am.K1 = Key.DefineKey(key.KID); }
                else
                    if (key2Button == sender) { key2Button.Text = label; key2Button.Tag = key.KID; am.K2 = Key.DefineKey(key.KID); }
                    else
                        if (key3Button == sender) { key3Button.Text = label; key3Button.Tag = key.KID; am.K3 = Key.DefineKey(key.KID); }
                        else
                            if (key4Button == sender) { key4Button.Text = label; key4Button.Tag = key.KID; am.K4 = Key.DefineKey(key.KID); }
                            else
                                if (key5Button == sender) { key5Button.Text = label; key5Button.Tag = key.KID; am.K5 = Key.DefineKey(key.KID); };
                // write changes
                m_logger.Debug("Saving new key to DB: " + key.KID);
                if (keysRequired_NumUpDown.Value < 5) keysRequired_NumUpDown.Value++;
                am.Save();
            }
        }
        private void DragTarget_DragOver(object sender, System.Windows.Forms.DragEventArgs e)
        {
            if ((e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move)
            { e.Effect = DragDropEffects.Move; }
            else e.Effect = DragDropEffects.None;
        }
        /* Interface interactions
         */
        private void ClearKey(object sender, EventArgs e)
        {
            if (!databaseLoaded) return;
            successPictureBox.Visible = false;
            bool isEmpty = (((Button)sender).Tag == null);
            ((Button)sender).Tag = null;
            ((Button)sender).Text = "";
            AuthMethod am = (AuthMethod)authMethods_listBox.SelectedItem;
            if (sender == key1Button) { am.K1 = null; }
            else if (sender == key2Button) { am.K2 = null; }
            else if (sender == key3Button) { am.K3 = null; }
            else if (sender == key4Button) { am.K4 = null; }
            else if (sender == key5Button) { am.K5 = null; };
            if (keysRequired_NumUpDown.Value > 0 && !isEmpty) keysRequired_NumUpDown.Value--;
            am.Save();
            // is it a good idea to clear the key in authentication method on click?
        }
        private void switchUserInfoInterface(bool value)
        {
            newAuthMethod_button.Enabled = value;
            removeAuthMethod_button.Enabled = value;
            key1Button.Enabled = value;
            key2Button.Enabled = value;
            key3Button.Enabled = value;
            key4Button.Enabled = value;
            key5Button.Enabled = value;
            keysRequired_NumUpDown.Enabled = value;
            keepPassword_checkBox.Enabled = value;
            authMethods_listBox.Enabled = value;
            description_textBox.Enabled = value;
            fastChoiceTypes_listView.Enabled = value;
            if (!value)
            {
                userName_textBox.Text = "";
                role_textBox.Text = "";
            }
        }
        private void RefreshAuthMethods()
        {
            if (!databaseLoaded) return;
            try
            {
                authMethods_listBox.Items.Clear();
                User user = (User)user_ListBox.SelectedItem;
                userName_textBox.Text = user.Name;
                role_textBox.Text = user.Role;
                AuthMethod[] authMethods = DBHelper.GetAuthMethods(user);
                if (authMethods.Length == 0)
                {
                    AuthMethod firstAM = new AuthMethod(user);
                    firstAM.Save();
                    authMethods_listBox.Items.Add(firstAM);
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
                switchUserInfoInterface(false);
            }
        }
        private void userListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            successPictureBox.Visible = false;
            if (user_ListBox.SelectedItems.Count > 1)
            {
                switchUserInfoInterface(false);
            }
            else
            {
                switchUserInfoInterface(true);
                RefreshAuthMethods();
            }
        }
        private void keepPassword_checkBox_Click(object sender, EventArgs e)
        {
            if (!databaseLoaded) return;
            if (((CheckBox)sender).CheckState == CheckState.Unchecked)
            {
                DialogResult dr = MessageBox.Show("Do you want to remove password from the OS?\nYou will not be able to LOG IN if you LOSE OR ERASE YOUR KEY\n\nI KNOW WHAT I AM DOING", "Stored password removal", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                if (dr.Equals(DialogResult.Yes))
                {
                    ((CheckBox)sender).CheckState = CheckState.Unchecked;
                    ((User)user_ListBox.SelectedItem).WindowsPassword = null;
					((User)user_ListBox.SelectedItem).Save();

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
                    ((User)user_ListBox.SelectedItem).NewPassword();
                    if (!(((User)user_ListBox.SelectedItem).Name.All(c => Char.IsLetterOrDigit(c) || c == '_')))
                    {
                        MessageBox.Show("Name has to contain letters, numbers or _");
                    }
                }
                else
                    ((CheckBox)sender).CheckState = CheckState.Unchecked;
            }
        }
        private void UpdateKeys()
        {
            if (!databaseLoaded) return;
            successPictureBox.Visible = false;
            AuthMethod am;
            try
            {
                am = (AuthMethod)authMethods_listBox.SelectedItem;
				if (am == null) throw new Exception("Empty auth method chosen");
            }
            catch (Exception ex) { m_logger.Debug(ex.Message); return; }
            if (am.K1 != null) { key1Button.Tag = am.K1; key1Button.Text = am.K1.Description; }
            else { key1Button.Text = ""; }
            if (am.K2 != null) { key2Button.Tag = am.K2; key2Button.Text = am.K2.Description; }
            else { key2Button.Text = ""; }
            if (am.K3 != null) { key3Button.Tag = am.K3; key3Button.Text = am.K3.Description; }
            else { key3Button.Text = ""; }
            if (am.K4 != null) { key4Button.Tag = am.K4; key4Button.Text = am.K4.Description; }
            else { key4Button.Text = ""; }
            if (am.K5 != null) { key5Button.Tag = am.K5; key5Button.Text = am.K5.Description; }
            else { key5Button.Text = ""; }
            keysRequired_NumUpDown.Value = (decimal)am.Number_of_keys;
            description_textBox.Text = am.Description;
        }
        private void authMethods_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateKeys();
        }
        private void removeUser_button_Click(object sender, EventArgs e)
        {
            if (!databaseLoaded) return;
            DialogResult accepted = MessageBox.Show("Are you sure?", "User removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (accepted == DialogResult.No) return;
            foreach (User user in user_ListBox.SelectedItems)
            {
                try
                {
                    if (removeWindowsUser_checkBox.Checked)
                    {
                        if (!user.RemoveFromSystem()) MessageBox.Show("Unable to remove user from system");
                    }
                    user.Remove();
                }
                catch (Exception ex) { m_logger.Error(ex.Message); }
            }
            UpdateUserList();
        }
        private void addUser_button_Click(object sender, EventArgs e)
        {
            if (!databaseLoaded) return;
            UserManagementForm addUserForm = new UserManagementForm();
            addUserForm.ShowDialog();
            if (addUserForm.IsValid)
            {
                user_ListBox.Items.Add(addUserForm.NewUser);
                user_ListBox.ClearSelected();
                user_ListBox.SelectedItem = addUserForm.NewUser;
            }
        }
        private void keysRequired_NumUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!databaseLoaded) return;
            successPictureBox.Visible = false;
            ((AuthMethod)authMethods_listBox.SelectedItem).Number_of_keys = (int)keysRequired_NumUpDown.Value;
            ((AuthMethod)authMethods_listBox.SelectedItem).Save();
        }
        private void newAuthMethod_button_Click(object sender, EventArgs e)
        {
            AddMethod();
        }
        private void AddMethod()
        {
            if (!databaseLoaded) return;
            successPictureBox.Visible = false;
            AuthMethod am = new AuthMethod((User)user_ListBox.SelectedItem);
            authMethods_listBox.Items.Add(am);
            am.Save();
            authMethods_listBox.SelectedItem = am;
        }
        private void fastChoiceTypes_listView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!databaseLoaded) return;
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
            try
            {
                if (!key.AddKey(userName_textBox.Text)) return;
            }
            catch (Exception ex) { m_logger.Error("unable to create key: " + ex.Message); return; }
            AuthMethod am = (AuthMethod)authMethods_listBox.SelectedItem;
            key.Save();
            switch (buttonNumber)
            {
                case 1: key1Button.Text = key.Description; key1Button.Tag = key.KID; am.K1 = Key.DefineKey((ulong)key1Button.Tag); break;
                case 2: key2Button.Text = key.Description; key2Button.Tag = key.KID; am.K2 = Key.DefineKey((ulong)key2Button.Tag); break;
                case 3: key3Button.Text = key.Description; key3Button.Tag = key.KID; am.K3 = Key.DefineKey((ulong)key3Button.Tag); break;
                case 4: key4Button.Text = key.Description; key4Button.Tag = key.KID; am.K4 = Key.DefineKey((ulong)key4Button.Tag); break;
                case 5: key5Button.Text = key.Description; key5Button.Tag = key.KID; am.K5 = Key.DefineKey((ulong)key5Button.Tag); break;
            }
            if (keysRequired_NumUpDown.Value < 5) keysRequired_NumUpDown.Value++;
            am.Save();
        }
        private void UpdateKeyList()
        {
            if (!databaseLoaded) return;
            Key[] keys = DBHelper.ReadKeys();
            keysListBox.Items.Clear();
            if (keys != null)
            {
                keysListBox.Items.AddRange(keys);
            }
        }
        private void removeUnusedKeys_button_Click(object sender, EventArgs e)
        {
            if (!databaseLoaded) return;
            try
            {
                DBHelper.RemoveUnusedKeys();
            }
            catch (Exception ex) { m_logger.Error("Unable to remove unused keys: " + ex.Message); }
        }
        private void description_textBox_TextChanged(object sender, EventArgs e)
        {
            if (!databaseLoaded) return;
            ((AuthMethod)authMethods_listBox.SelectedItem).Description = description_textBox.Text;
            ((AuthMethod)authMethods_listBox.SelectedItem).Save();
        }
        private void changeRole_contextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (!databaseLoaded) return;
            ((User)user_ListBox.SelectedItem).Role = e.ClickedItem.Text;
            ((User)user_ListBox.SelectedItem).MakeAdmin(e.ClickedItem.Text == "Administrator");
            ((User)user_ListBox.SelectedItem).Save();
            role_textBox.Text = e.ClickedItem.Text;
        }
        private void userListBox_MouseDown(object sender, MouseEventArgs e)
        {
            // opens the role change menu
            if (e.Button == MouseButtons.Right)
            {
                int currentIndex = user_ListBox.IndexFromPoint(e.Location);
                if (currentIndex != -1)
                {
                    Point p = e.Location;
                    p = PointToScreen(p);
                    p.Offset(0, changeRole_contextMenuStrip.Size.Height);
                    changeRole_contextMenuStrip.Select();
                    changeRole_contextMenuStrip.Show(p);
                    user_ListBox.SelectedIndex = currentIndex;
                }
            }
        }
        private void switchKeyInfoInterface(bool value)
        {
            keyInfo_groupBox.Enabled = value;
            checkKey_groupBox.Enabled = value;
        }
        private void keysListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkKeyResult_button.BackColor = Color.White;
            if (keysListBox.SelectedItems.Count != 1)
            {
                switchKeyInfoInterface(false);
                keySerial_textBox.Enabled = false;
            }
            else
                try
                {
                    switchKeyInfoInterface(true);
                    Key key = (Key)keysListBox.SelectedItem;
                    keyDescription_textBox.Text = key.Description;
                    keyType_label.Text = key.GetType();
                    keyInverted_checkBox.Checked = key.Inverted;

                    keySerial_checkBox.Checked = (key.Serial != null);
                    keySerial_textBox.Enabled = false;
                    if (key.Serial != null)
                    {
                        keySerial_textBox.Enabled = true;
                        keySerial_textBox.Text = key.Serial;
                    }
                    keyPassword_checkBox.Checked = (key.Password != null);
                    keyData_checkBox.Checked = (key.Data != null);
                    keyConfigure_button.Enabled = key.IsConfigurable;

                    // auto check if enabled in settings
                    if ((bool)m_settings.AlwaysCheckSelectedKey) checkKey();
                }
                catch (Exception ex) { m_logger.Debug(ex.Message); }
        }
        private void keyDescription_textBox_TextChanged(object sender, EventArgs e)
        {
            if (!databaseLoaded) return;
            Key key = (Key)keysListBox.SelectedItem;
            key.Description = keyDescription_textBox.Text;
            key.Save();
        }
        private void keyInverted_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!databaseLoaded) return;
			Key key = null;
			try { key = (Key)keysListBox.SelectedItem; } catch { };
            key.Inverted = keyInverted_checkBox.Checked;
            key.Save();
        }
        private void keyConfigure_button_Click(object sender, EventArgs e)
        {
			try { ((Key)keysListBox.SelectedItem).Configure(); } catch { } 
			// catch a strange bug of "nothing" being the selected item in listBox
        }
        private void removeAuthMethod_button_Click(object sender, EventArgs e)
        {
            if (!databaseLoaded) return;
			AuthMethod am = null;
			try { am = ((AuthMethod)authMethods_listBox.SelectedItem); } catch { }
            if (am == null) return;
            am.Delete();
            if (authMethods_listBox.Items.Count <= 1)
            {
                AddMethod();
            }
            authMethods_listBox.Items.Remove(am);
            authMethods_listBox.SelectedIndex = 0;
        }
        private void deleteKey_button_Click(object sender, EventArgs e)
        {
            if (!databaseLoaded) return;
            if (keyRemoval_checkBox.Checked)
            {
                if (keysListBox.SelectedItems.Count == 0) return;
                String result = "";
                foreach (object keyObject in keysListBox.SelectedItems)
                {
                    Key key = (Key)keyObject;
                    AuthMethod[] harmedAuthMethods = DBHelper.ReadAuthMethods(key.KID);
                    result += "Key " + key.ToString() + " removed.\n";
                    if (harmedAuthMethods.Count() > 0)
                    {
                        result += "Broken auth methods:\n";
                        foreach (AuthMethod am in harmedAuthMethods)
                        {
                            if (am.K1 == key) am.K1 = null;
                            if (am.K2 == key) am.K2 = null;
                            if (am.K3 == key) am.K3 = null;
                            if (am.K4 == key) am.K4 = null;
                            if (am.K5 == key) am.K5 = null;
                            User user = new User(am.UID);
                            user.Fill();
                            result += am.ToString() + " for user: " + user.Name + "\n";
                            user = null;
                        }
                    }
                    key.Remove();
                    result += "\n";
                }
                UpdateKeyList();
                MessageBox.Show(result, "key removal", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                if (keysListBox.SelectedIndex > 0) keysListBox.SelectedIndex = keysListBox.SelectedIndex - 1;
            };
        }
        private void refreshSummary()
        {
            if (!databaseLoaded) return;
            summary_treeView.Nodes.Clear();
            foreach (User user in DBHelper.ReadUsers())
            {
                TreeNode userNode = new TreeNode((user.Role == "Administrator" ? "[A] " : "") + user.Name);
                foreach (AuthMethod authMethod in DBHelper.GetAuthMethods(user))
                {
                    TreeNode amNode = new TreeNode(authMethod.ToString());
                    Key[] keys = DBHelper.ReadKeys("", authMethod);
                    foreach (Key key in keys)
                    {
                        amNode.Nodes.Add(key.ToString());
                    }
                    amNode.Nodes.Add("Keys required: " + authMethod.Number_of_keys);
                    if (authMethod.Number_of_keys > keys.Count()) amNode.Text += "  #### Login impossible ####";
                    userNode.Nodes.Add(amNode);
                }
                summary_treeView.Nodes.Add(userNode);
            }
            summary_treeView.ExpandAll();
        }
        private void summary_tabPage_Enter(object sender, EventArgs e)
        {
            refreshSummary();
        }
        private void expandAll_button_Click(object sender, EventArgs e)
        {
            summary_treeView.ExpandAll();
        }
        private void collapseAll_button_Click(object sender, EventArgs e)
        {
            summary_treeView.CollapseAll();
        }
        private void keys_tabPage_Enter(object sender, EventArgs e)
        {
            UpdateKeyList();
        }
        private void keySerial_textBox_TextChanged(object sender, EventArgs e)
        {
            Key key = (Key)keysListBox.SelectedItem;
            key.Serial = keySerial_textBox.Text;
            key.Save();
        }

        private void cleanDB_button_Click(object sender, EventArgs e)
        {
            DBHelper.CleanDB();
        }

        private void dbErase_button_Click(object sender, EventArgs e)
        {
            DialogResult accepted = MessageBox.Show("Are you sure?", "Database erase", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (accepted == DialogResult.No) return;
            if (dbErase_checkBox.Checked)
            {
                try
                {
                    DBHelper.Disconnect();
                    System.IO.File.Delete((string)m_settings.LocalDatabasePath);
                    string DBPassword = Encoding.ASCII.GetString(ProtectedData.Unprotect((byte[])m_settings.DBPassword, (byte[])m_settings.DBPasswordSalt, DataProtectionScope.LocalMachine));
                    BooleanResult connectionSuccess = DBHelper.ConnectOrCreateLocalDB((string)m_settings.LocalDatabasePath, DBPassword, true);
                    if (connectionSuccess.Success) databaseLoaded = true;
                    MessageBox.Show(connectionSuccess.Message);
                }
                catch (Exception ex) { MessageBox.Show("Unable to erase database" + ex.Message + "\n Try again later.", "Database erase"); }
            }
        }

        private void auth_tabPage_Enter(object sender, EventArgs e)
        {
            try
            {
                if (databaseLoaded) UpdateUserList();
            }
            catch { MessageBox.Show("Database is corrupted"); tabControl.SelectTab(advancedSettings_tabPage); }
        }

        private void advancedSettings_tabPage_Enter(object sender, EventArgs e)
        {
            if (!databaseLoaded)
            {
                tabControl.SelectTab("advancedSettings_tabPage");
                DBOpened_checkBox.Checked = false;
            }
            else
            {
                advancedSettings_tabPage.Text = "Advanced settings";
                DBOpened_checkBox.Checked = true;
            }
        }
        // defaults for logging
        private bool extraLogs = false;
        private string modeLogs = "L";
        private int countLogs = 50;
        private void FillLogs()
        {
            try
            {
                logs_dataView.Rows.Clear();
                if (extraLogs)
                {
                    logs_dataView.Columns["leid"].Visible = true;
                    logs_dataView.Columns["amid"].Visible = true;
                    logs_dataView.Columns["uid"].Visible = true;
                }
                else
                {
                    logs_dataView.Columns["leid"].Visible = false;
                    logs_dataView.Columns["amid"].Visible = false;
                    logs_dataView.Columns["uid"].Visible = false;
                }
                foreach (LogEntity le in DBHelper.ReadLogs(modeLogs, countLogs))
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.Cells.AddRange();
                    string[] login_attempt;
                    if (extraLogs)
                        login_attempt = new string[] { le.Name, le.AMDescription, le.Success ? "Success" : "Fail", le.Time.ToString(), le.KeysUsed, le.LEID.ToString(), le.UID.ToString(), le.AMID.ToString() };
                    else
                        login_attempt = new string[] { le.Name, le.AMDescription, le.Success ? "Success" : "Fail", le.Time.ToString(), le.KeysUsed };
                    logs_dataView.Rows.Add(login_attempt);
                }
            }
            catch (Exception ex) { m_logger.Debug(ex.Message); }
        }
        private void logs_tabPage_Enter(object sender, EventArgs e)
        {
            FillLogs();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            modeLogs = "F";
            FillLogs();
        }

        private void last100logs_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            modeLogs="L";
            FillLogs();
        }

        private void extraLogs_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            extraLogs = extraLogs_checkBox.Checked;
            FillLogs();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            modeLogs = "All";
            FillLogs();
        }

        private void countLogs_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            countLogs = (int)countLogs_numericUpDown.Value;
            FillLogs();
        }

        private void todayLogs_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            modeLogs = "Today";
            FillLogs();
        }

        private void thisMonthLogs_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            modeLogs = "This month";
            FillLogs();
        }

        private void removeUnusedKeys_button_Click_1(object sender, EventArgs e)
        {
            DBHelper.RemoveUnusedKeys();
            UpdateKeyList();
        }
        private void checkKey()
        {
            try
            {
                string password = checkPassword_textBox.Text;
                bool success = ((Key)keysListBox.SelectedItem).CheckKey(password);
                checkKeyResult_button.BackColor = (success) ? Color.Green : Color.Red;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); checkKeyResult_button.BackColor = Color.White; }
        }
        private void checkKey_button_Click(object sender, EventArgs e)
        {
            checkKey();
        }

        private void advancedSettings_alwaysCheckSelectedKey_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            m_settings.AlwaysCheckSelectedKey = (advancedSettings_alwaysCheckSelectedKey_checkBox.Checked);
        }

        private void CheckAuthMethod()
        {
            AuthMethod am = (AuthMethod)authMethods_listBox.SelectedItem;
            UserInformation ui = new UserInformation()
            {
                Username = userName_textBox.Text,
                Password = testAMpassword_textBox.Text,
                OriginalPassword = testAMpassword_textBox.Text
            };
            BooleanResult authMethodCheck = AuthenticationManager.TryAuthMethod(am, ui, false);
            successPictureBox.Visible = authMethodCheck.Success;
            User user = new User();
            user.FillByName(ui.Username);
            if (user.WindowsPassword != null && ui.Password != user.WindowsPassword && ui.Password != ui.OriginalPassword)
                MessageBox.Show("You certainly can't log in with this authentication method - some keys contain incorrect Windows password.",
                    "Bad keys", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (user.WindowsPassword == null && ui.Password == ui.OriginalPassword)
                MessageBox.Show("You can't log in this way as database has no Windows password and keys do not provide it either.",
                    "Login impossible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void openingPictureBox_Click(object sender, MouseEventArgs e)
        {
            CheckAuthMethod();
            Thread.Sleep(15);
            Refresh();
            // make sure database isn't locked and give plugin some time to do its job
        }

        private void openingPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
	}
}