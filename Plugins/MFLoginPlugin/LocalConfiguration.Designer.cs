namespace pGina.Plugin.MFLoginPlugin
{
    partial class LocalConfiguration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "BluetoothDevice (unreliable!)"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.MenuBar, null);
			System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "ConnectedDevice"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.MenuBar, null);
			System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "Password"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.MenuBar, null);
			this.changeRole_contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.user_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.admin_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.controlPanel = new System.Windows.Forms.ToolStrip();
			this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
			this.advancedSettings_tabPage = new System.Windows.Forms.TabPage();
			this.runSetup_button = new System.Windows.Forms.Button();
			this.keys_tabPage = new System.Windows.Forms.TabPage();
			this.keyInfo = new System.Windows.Forms.GroupBox();
			this.keyConfigure_button = new System.Windows.Forms.Button();
			this.keyData_checkBox = new System.Windows.Forms.CheckBox();
			this.keyPassword_checkBox = new System.Windows.Forms.CheckBox();
			this.keySerial_checkBox = new System.Windows.Forms.CheckBox();
			this.keyType_label = new System.Windows.Forms.Label();
			this.keyInverted_checkBox = new System.Windows.Forms.CheckBox();
			this.keyDescription_textBox = new System.Windows.Forms.TextBox();
			this.keyDescription_label = new System.Windows.Forms.Label();
			this.refreshKeyList_button = new System.Windows.Forms.Button();
			this.removeUnusedKeys_button = new System.Windows.Forms.Button();
			this.keysListBox = new System.Windows.Forms.ListBox();
			this.auth_tabPage = new System.Windows.Forms.TabPage();
			this.fastChoice_groupBox = new System.Windows.Forms.GroupBox();
			this.fastChoiceTypes_listView = new System.Windows.Forms.ListView();
			this.user_groupBox = new System.Windows.Forms.GroupBox();
			this.userIconPictureBox = new System.Windows.Forms.PictureBox();
			this.keepPassword_checkBox = new System.Windows.Forms.CheckBox();
			this.role_textBox = new System.Windows.Forms.TextBox();
			this.userName_textBox = new System.Windows.Forms.TextBox();
			this.authConfig = new System.Windows.Forms.GroupBox();
			this.description_textBox = new System.Windows.Forms.TextBox();
			this.description_label = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.removeAuthMethod_button = new System.Windows.Forms.Button();
			this.newAuthMethod_button = new System.Windows.Forms.Button();
			this.authMethods_listBox = new System.Windows.Forms.ListBox();
			this.openingPictureBox = new System.Windows.Forms.PictureBox();
			this.keysRequired_label = new System.Windows.Forms.Label();
			this.successPictureBox = new System.Windows.Forms.PictureBox();
			this.keysRequired_NumUpDown = new System.Windows.Forms.NumericUpDown();
			this.key5Label = new System.Windows.Forms.Label();
			this.key4Label = new System.Windows.Forms.Label();
			this.key3Label = new System.Windows.Forms.Label();
			this.key2Label = new System.Windows.Forms.Label();
			this.key1Label = new System.Windows.Forms.Label();
			this.key3Button = new System.Windows.Forms.Button();
			this.key5Button = new System.Windows.Forms.Button();
			this.key4Button = new System.Windows.Forms.Button();
			this.key1Button = new System.Windows.Forms.Button();
			this.key2Button = new System.Windows.Forms.Button();
			this.UsersGroupBox = new System.Windows.Forms.GroupBox();
			this.removeUser_button = new System.Windows.Forms.Button();
			this.addUser_button = new System.Windows.Forms.Button();
			this.userListBox = new System.Windows.Forms.ListBox();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.summary_tabPage = new System.Windows.Forms.TabPage();
			this.changeRole_contextMenuStrip.SuspendLayout();
			this.controlPanel.SuspendLayout();
			this.advancedSettings_tabPage.SuspendLayout();
			this.keys_tabPage.SuspendLayout();
			this.keyInfo.SuspendLayout();
			this.auth_tabPage.SuspendLayout();
			this.fastChoice_groupBox.SuspendLayout();
			this.user_groupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.userIconPictureBox)).BeginInit();
			this.authConfig.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.openingPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.successPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.keysRequired_NumUpDown)).BeginInit();
			this.UsersGroupBox.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.SuspendLayout();
			// 
			// changeRole_contextMenuStrip
			// 
			this.changeRole_contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.user_toolStripMenuItem,
            this.admin_toolStripMenuItem});
			this.changeRole_contextMenuStrip.Name = "changeRole_contextMenuStrip";
			this.changeRole_contextMenuStrip.ShowImageMargin = false;
			this.changeRole_contextMenuStrip.ShowItemToolTips = false;
			this.changeRole_contextMenuStrip.Size = new System.Drawing.Size(136, 52);
			this.changeRole_contextMenuStrip.Text = "Role";
			this.changeRole_contextMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.changeRole_contextMenuStrip_ItemClicked);
			// 
			// user_toolStripMenuItem
			// 
			this.user_toolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.user_toolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.user_toolStripMenuItem.Name = "user_toolStripMenuItem";
			this.user_toolStripMenuItem.Size = new System.Drawing.Size(135, 24);
			this.user_toolStripMenuItem.Text = "User";
			// 
			// admin_toolStripMenuItem
			// 
			this.admin_toolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.admin_toolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.admin_toolStripMenuItem.Name = "admin_toolStripMenuItem";
			this.admin_toolStripMenuItem.Size = new System.Drawing.Size(135, 24);
			this.admin_toolStripMenuItem.Text = "Administrator";
			// 
			// controlPanel
			// 
			this.controlPanel.AutoSize = false;
			this.controlPanel.CanOverflow = false;
			this.controlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.controlPanel.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.controlPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3});
			this.controlPanel.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.controlPanel.Location = new System.Drawing.Point(0, 406);
			this.controlPanel.Name = "controlPanel";
			this.controlPanel.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.controlPanel.Size = new System.Drawing.Size(984, 28);
			this.controlPanel.TabIndex = 6;
			this.controlPanel.Text = "toolStrip1";
			this.controlPanel.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.controlPanel_ItemClicked);
			// 
			// toolStripButton3
			// 
			this.toolStripButton3.AutoSize = false;
			this.toolStripButton3.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButton3.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.toolStripButton3.ForeColor = System.Drawing.SystemColors.ActiveBorder;
			this.toolStripButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolStripButton3.Margin = new System.Windows.Forms.Padding(0);
			this.toolStripButton3.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
			this.toolStripButton3.Name = "toolStripButton3";
			this.toolStripButton3.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
			this.toolStripButton3.Size = new System.Drawing.Size(983, 28);
			this.toolStripButton3.Text = "OK";
			this.toolStripButton3.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// advancedSettings_tabPage
			// 
			this.advancedSettings_tabPage.Controls.Add(this.runSetup_button);
			this.advancedSettings_tabPage.Location = new System.Drawing.Point(4, 24);
			this.advancedSettings_tabPage.Margin = new System.Windows.Forms.Padding(4);
			this.advancedSettings_tabPage.Name = "advancedSettings_tabPage";
			this.advancedSettings_tabPage.Padding = new System.Windows.Forms.Padding(4);
			this.advancedSettings_tabPage.Size = new System.Drawing.Size(976, 382);
			this.advancedSettings_tabPage.TabIndex = 3;
			this.advancedSettings_tabPage.Text = "Advanced settings";
			this.advancedSettings_tabPage.UseVisualStyleBackColor = true;
			// 
			// runSetup_button
			// 
			this.runSetup_button.Location = new System.Drawing.Point(10, 7);
			this.runSetup_button.Margin = new System.Windows.Forms.Padding(4);
			this.runSetup_button.Name = "runSetup_button";
			this.runSetup_button.Size = new System.Drawing.Size(245, 38);
			this.runSetup_button.TabIndex = 11;
			this.runSetup_button.Text = "Run setup dialog again";
			this.runSetup_button.UseVisualStyleBackColor = true;
			this.runSetup_button.Click += new System.EventHandler(this.runSetup_button_Click);
			// 
			// keys_tabPage
			// 
			this.keys_tabPage.Controls.Add(this.keyInfo);
			this.keys_tabPage.Controls.Add(this.refreshKeyList_button);
			this.keys_tabPage.Controls.Add(this.removeUnusedKeys_button);
			this.keys_tabPage.Controls.Add(this.keysListBox);
			this.keys_tabPage.Location = new System.Drawing.Point(4, 24);
			this.keys_tabPage.Margin = new System.Windows.Forms.Padding(4);
			this.keys_tabPage.Name = "keys_tabPage";
			this.keys_tabPage.Padding = new System.Windows.Forms.Padding(4);
			this.keys_tabPage.Size = new System.Drawing.Size(976, 382);
			this.keys_tabPage.TabIndex = 2;
			this.keys_tabPage.Text = "Keys";
			this.keys_tabPage.UseVisualStyleBackColor = true;
			// 
			// keyInfo
			// 
			this.keyInfo.BackColor = System.Drawing.Color.SkyBlue;
			this.keyInfo.Controls.Add(this.keyConfigure_button);
			this.keyInfo.Controls.Add(this.keyData_checkBox);
			this.keyInfo.Controls.Add(this.keyPassword_checkBox);
			this.keyInfo.Controls.Add(this.keySerial_checkBox);
			this.keyInfo.Controls.Add(this.keyType_label);
			this.keyInfo.Controls.Add(this.keyInverted_checkBox);
			this.keyInfo.Controls.Add(this.keyDescription_textBox);
			this.keyInfo.Controls.Add(this.keyDescription_label);
			this.keyInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.keyInfo.Location = new System.Drawing.Point(273, 7);
			this.keyInfo.Name = "keyInfo";
			this.keyInfo.Size = new System.Drawing.Size(458, 185);
			this.keyInfo.TabIndex = 17;
			this.keyInfo.TabStop = false;
			this.keyInfo.Text = "Key information";
			this.keyInfo.Enter += new System.EventHandler(this.keyInfo_Enter);
			// 
			// keyConfigure_button
			// 
			this.keyConfigure_button.Enabled = false;
			this.keyConfigure_button.Location = new System.Drawing.Point(6, 150);
			this.keyConfigure_button.Name = "keyConfigure_button";
			this.keyConfigure_button.Size = new System.Drawing.Size(445, 29);
			this.keyConfigure_button.TabIndex = 7;
			this.keyConfigure_button.Text = "Configure";
			this.keyConfigure_button.UseVisualStyleBackColor = true;
			this.keyConfigure_button.Click += new System.EventHandler(this.keyConfigure_button_Click);
			// 
			// keyData_checkBox
			// 
			this.keyData_checkBox.AutoSize = true;
			this.keyData_checkBox.BackColor = System.Drawing.Color.White;
			this.keyData_checkBox.Enabled = false;
			this.keyData_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.keyData_checkBox.Location = new System.Drawing.Point(337, 120);
			this.keyData_checkBox.Name = "keyData_checkBox";
			this.keyData_checkBox.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.keyData_checkBox.Size = new System.Drawing.Size(112, 24);
			this.keyData_checkBox.TabIndex = 6;
			this.keyData_checkBox.Text = "Other data";
			this.keyData_checkBox.UseVisualStyleBackColor = false;
			// 
			// keyPassword_checkBox
			// 
			this.keyPassword_checkBox.AutoSize = true;
			this.keyPassword_checkBox.BackColor = System.Drawing.Color.White;
			this.keyPassword_checkBox.Enabled = false;
			this.keyPassword_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.keyPassword_checkBox.Location = new System.Drawing.Point(190, 120);
			this.keyPassword_checkBox.Name = "keyPassword_checkBox";
			this.keyPassword_checkBox.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.keyPassword_checkBox.Size = new System.Drawing.Size(141, 24);
			this.keyPassword_checkBox.TabIndex = 5;
			this.keyPassword_checkBox.Text = "Has password";
			this.keyPassword_checkBox.UseVisualStyleBackColor = false;
			// 
			// keySerial_checkBox
			// 
			this.keySerial_checkBox.AutoSize = true;
			this.keySerial_checkBox.BackColor = System.Drawing.Color.White;
			this.keySerial_checkBox.Enabled = false;
			this.keySerial_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.keySerial_checkBox.Location = new System.Drawing.Point(10, 120);
			this.keySerial_checkBox.Name = "keySerial_checkBox";
			this.keySerial_checkBox.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
			this.keySerial_checkBox.Size = new System.Drawing.Size(175, 24);
			this.keySerial_checkBox.TabIndex = 4;
			this.keySerial_checkBox.Text = "Has serial/address";
			this.keySerial_checkBox.UseVisualStyleBackColor = false;
			// 
			// keyType_label
			// 
			this.keyType_label.AutoSize = true;
			this.keyType_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
			this.keyType_label.Location = new System.Drawing.Point(6, 19);
			this.keyType_label.Name = "keyType_label";
			this.keyType_label.Size = new System.Drawing.Size(0, 24);
			this.keyType_label.TabIndex = 3;
			// 
			// keyInverted_checkBox
			// 
			this.keyInverted_checkBox.AutoSize = true;
			this.keyInverted_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.keyInverted_checkBox.Location = new System.Drawing.Point(10, 90);
			this.keyInverted_checkBox.Name = "keyInverted_checkBox";
			this.keyInverted_checkBox.Size = new System.Drawing.Size(87, 24);
			this.keyInverted_checkBox.TabIndex = 2;
			this.keyInverted_checkBox.Text = "Inverted";
			this.keyInverted_checkBox.UseVisualStyleBackColor = true;
			this.keyInverted_checkBox.CheckedChanged += new System.EventHandler(this.keyInverted_checkBox_CheckedChanged);
			// 
			// keyDescription_textBox
			// 
			this.keyDescription_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.keyDescription_textBox.Location = new System.Drawing.Point(107, 50);
			this.keyDescription_textBox.Name = "keyDescription_textBox";
			this.keyDescription_textBox.Size = new System.Drawing.Size(322, 26);
			this.keyDescription_textBox.TabIndex = 1;
			this.keyDescription_textBox.TextChanged += new System.EventHandler(this.keyDescription_textBox_TextChanged);
			// 
			// keyDescription_label
			// 
			this.keyDescription_label.AutoSize = true;
			this.keyDescription_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.keyDescription_label.Location = new System.Drawing.Point(6, 50);
			this.keyDescription_label.Name = "keyDescription_label";
			this.keyDescription_label.Size = new System.Drawing.Size(95, 20);
			this.keyDescription_label.TabIndex = 0;
			this.keyDescription_label.Text = "Description";
			// 
			// refreshKeyList_button
			// 
			this.refreshKeyList_button.Location = new System.Drawing.Point(8, 317);
			this.refreshKeyList_button.Name = "refreshKeyList_button";
			this.refreshKeyList_button.Size = new System.Drawing.Size(123, 58);
			this.refreshKeyList_button.TabIndex = 16;
			this.refreshKeyList_button.Text = "Refresh";
			this.refreshKeyList_button.UseVisualStyleBackColor = true;
			this.refreshKeyList_button.Click += new System.EventHandler(this.refreshKeyList_button_Click);
			// 
			// removeUnusedKeys_button
			// 
			this.removeUnusedKeys_button.Location = new System.Drawing.Point(137, 317);
			this.removeUnusedKeys_button.Name = "removeUnusedKeys_button";
			this.removeUnusedKeys_button.Size = new System.Drawing.Size(130, 58);
			this.removeUnusedKeys_button.TabIndex = 15;
			this.removeUnusedKeys_button.Text = "Remove all unused keys from database";
			this.removeUnusedKeys_button.UseVisualStyleBackColor = true;
			this.removeUnusedKeys_button.Click += new System.EventHandler(this.removeUnusedKeys_button_Click);
			// 
			// keysListBox
			// 
			this.keysListBox.FormattingEnabled = true;
			this.keysListBox.ItemHeight = 15;
			this.keysListBox.Location = new System.Drawing.Point(8, 7);
			this.keysListBox.Name = "keysListBox";
			this.keysListBox.Size = new System.Drawing.Size(259, 304);
			this.keysListBox.TabIndex = 14;
			this.keysListBox.SelectedIndexChanged += new System.EventHandler(this.keysListBox_SelectedIndexChanged);
			// 
			// auth_tabPage
			// 
			this.auth_tabPage.Controls.Add(this.fastChoice_groupBox);
			this.auth_tabPage.Controls.Add(this.user_groupBox);
			this.auth_tabPage.Controls.Add(this.authConfig);
			this.auth_tabPage.Controls.Add(this.UsersGroupBox);
			this.auth_tabPage.Location = new System.Drawing.Point(4, 24);
			this.auth_tabPage.Margin = new System.Windows.Forms.Padding(4);
			this.auth_tabPage.Name = "auth_tabPage";
			this.auth_tabPage.Padding = new System.Windows.Forms.Padding(4);
			this.auth_tabPage.Size = new System.Drawing.Size(976, 382);
			this.auth_tabPage.TabIndex = 0;
			this.auth_tabPage.Text = "Authentication";
			this.auth_tabPage.UseVisualStyleBackColor = true;
			// 
			// fastChoice_groupBox
			// 
			this.fastChoice_groupBox.BackColor = System.Drawing.Color.Thistle;
			this.fastChoice_groupBox.Controls.Add(this.fastChoiceTypes_listView);
			this.fastChoice_groupBox.Location = new System.Drawing.Point(474, 235);
			this.fastChoice_groupBox.Name = "fastChoice_groupBox";
			this.fastChoice_groupBox.Size = new System.Drawing.Size(494, 138);
			this.fastChoice_groupBox.TabIndex = 19;
			this.fastChoice_groupBox.TabStop = false;
			this.fastChoice_groupBox.Text = "Pick key type";
			// 
			// fastChoiceTypes_listView
			// 
			this.fastChoiceTypes_listView.Alignment = System.Windows.Forms.ListViewAlignment.Default;
			this.fastChoiceTypes_listView.AutoArrange = false;
			this.fastChoiceTypes_listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			listViewItem7.Tag = "BluetoothDevice";
			listViewItem8.Tag = "ConnectedDevice";
			listViewItem9.Tag = "Password";
			this.fastChoiceTypes_listView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem7,
            listViewItem8,
            listViewItem9});
			this.fastChoiceTypes_listView.LabelWrap = false;
			this.fastChoiceTypes_listView.Location = new System.Drawing.Point(6, 20);
			this.fastChoiceTypes_listView.MultiSelect = false;
			this.fastChoiceTypes_listView.Name = "fastChoiceTypes_listView";
			this.fastChoiceTypes_listView.ShowGroups = false;
			this.fastChoiceTypes_listView.Size = new System.Drawing.Size(482, 112);
			this.fastChoiceTypes_listView.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.fastChoiceTypes_listView.TabIndex = 4;
			this.fastChoiceTypes_listView.UseCompatibleStateImageBehavior = false;
			this.fastChoiceTypes_listView.View = System.Windows.Forms.View.Tile;
			this.fastChoiceTypes_listView.SelectedIndexChanged += new System.EventHandler(this.fastChoiceTypes_listView_SelectedIndexChanged);
			this.fastChoiceTypes_listView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.fastChoiceTypes_listView_MouseDoubleClick);
			this.fastChoiceTypes_listView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragSource_MouseDown);
			this.fastChoiceTypes_listView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragSource_MouseMove);
			this.fastChoiceTypes_listView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragSource_MouseUp);
			// 
			// user_groupBox
			// 
			this.user_groupBox.BackColor = System.Drawing.Color.Wheat;
			this.user_groupBox.Controls.Add(this.userIconPictureBox);
			this.user_groupBox.Controls.Add(this.keepPassword_checkBox);
			this.user_groupBox.Controls.Add(this.role_textBox);
			this.user_groupBox.Controls.Add(this.userName_textBox);
			this.user_groupBox.Location = new System.Drawing.Point(253, 235);
			this.user_groupBox.Name = "user_groupBox";
			this.user_groupBox.Size = new System.Drawing.Size(214, 140);
			this.user_groupBox.TabIndex = 18;
			this.user_groupBox.TabStop = false;
			// 
			// userIconPictureBox
			// 
			this.userIconPictureBox.BackColor = System.Drawing.Color.SeaShell;
			this.userIconPictureBox.BackgroundImage = global::pGina.Plugin.MFLoginPlugin.Properties.Resources.user_logo;
			this.userIconPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.userIconPictureBox.InitialImage = null;
			this.userIconPictureBox.Location = new System.Drawing.Point(6, 61);
			this.userIconPictureBox.Name = "userIconPictureBox";
			this.userIconPictureBox.Size = new System.Drawing.Size(70, 73);
			this.userIconPictureBox.TabIndex = 17;
			this.userIconPictureBox.TabStop = false;
			// 
			// keepPassword_checkBox
			// 
			this.keepPassword_checkBox.Checked = true;
			this.keepPassword_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.keepPassword_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.keepPassword_checkBox.Location = new System.Drawing.Point(82, 61);
			this.keepPassword_checkBox.Name = "keepPassword_checkBox";
			this.keepPassword_checkBox.Size = new System.Drawing.Size(126, 43);
			this.keepPassword_checkBox.TabIndex = 23;
			this.keepPassword_checkBox.Text = "Keep password in the OS";
			this.keepPassword_checkBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.keepPassword_checkBox.UseVisualStyleBackColor = true;
			this.keepPassword_checkBox.Click += new System.EventHandler(this.keepPassword_checkBox_Click);
			// 
			// role_textBox
			// 
			this.role_textBox.BackColor = System.Drawing.SystemColors.Info;
			this.role_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.role_textBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.role_textBox.Location = new System.Drawing.Point(82, 110);
			this.role_textBox.MaxLength = 30;
			this.role_textBox.Name = "role_textBox";
			this.role_textBox.ReadOnly = true;
			this.role_textBox.Size = new System.Drawing.Size(126, 24);
			this.role_textBox.TabIndex = 22;
			this.role_textBox.TabStop = false;
			this.role_textBox.Text = "Role";
			this.role_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.role_textBox.WordWrap = false;
			// 
			// userName_textBox
			// 
			this.userName_textBox.BackColor = System.Drawing.SystemColors.Info;
			this.userName_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.userName_textBox.Location = new System.Drawing.Point(6, 6);
			this.userName_textBox.MaxLength = 128;
			this.userName_textBox.Multiline = true;
			this.userName_textBox.Name = "userName_textBox";
			this.userName_textBox.ReadOnly = true;
			this.userName_textBox.Size = new System.Drawing.Size(202, 49);
			this.userName_textBox.TabIndex = 21;
			this.userName_textBox.TabStop = false;
			this.userName_textBox.Text = "Username";
			// 
			// authConfig
			// 
			this.authConfig.BackColor = System.Drawing.Color.SkyBlue;
			this.authConfig.Controls.Add(this.description_textBox);
			this.authConfig.Controls.Add(this.description_label);
			this.authConfig.Controls.Add(this.panel1);
			this.authConfig.Controls.Add(this.openingPictureBox);
			this.authConfig.Controls.Add(this.keysRequired_label);
			this.authConfig.Controls.Add(this.successPictureBox);
			this.authConfig.Controls.Add(this.keysRequired_NumUpDown);
			this.authConfig.Controls.Add(this.key5Label);
			this.authConfig.Controls.Add(this.key4Label);
			this.authConfig.Controls.Add(this.key3Label);
			this.authConfig.Controls.Add(this.key2Label);
			this.authConfig.Controls.Add(this.key1Label);
			this.authConfig.Controls.Add(this.key3Button);
			this.authConfig.Controls.Add(this.key5Button);
			this.authConfig.Controls.Add(this.key4Button);
			this.authConfig.Controls.Add(this.key1Button);
			this.authConfig.Controls.Add(this.key2Button);
			this.authConfig.Location = new System.Drawing.Point(253, 8);
			this.authConfig.Name = "authConfig";
			this.authConfig.Size = new System.Drawing.Size(715, 221);
			this.authConfig.TabIndex = 12;
			this.authConfig.TabStop = false;
			this.authConfig.Text = "User authentication";
			// 
			// description_textBox
			// 
			this.description_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.description_textBox.Location = new System.Drawing.Point(399, 49);
			this.description_textBox.Name = "description_textBox";
			this.description_textBox.Size = new System.Drawing.Size(271, 26);
			this.description_textBox.TabIndex = 26;
			this.description_textBox.TextChanged += new System.EventHandler(this.description_textBox_TextChanged);
			// 
			// description_label
			// 
			this.description_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.description_label.Location = new System.Drawing.Point(399, 21);
			this.description_label.Name = "description_label";
			this.description_label.Size = new System.Drawing.Size(270, 25);
			this.description_label.TabIndex = 25;
			this.description_label.Text = "Authentication method description:";
			this.description_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.panel1.Controls.Add(this.removeAuthMethod_button);
			this.panel1.Controls.Add(this.newAuthMethod_button);
			this.panel1.Controls.Add(this.authMethods_listBox);
			this.panel1.Location = new System.Drawing.Point(7, 21);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(379, 98);
			this.panel1.TabIndex = 24;
			// 
			// removeAuthMethod_button
			// 
			this.removeAuthMethod_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.removeAuthMethod_button.Location = new System.Drawing.Point(219, 51);
			this.removeAuthMethod_button.Name = "removeAuthMethod_button";
			this.removeAuthMethod_button.Size = new System.Drawing.Size(147, 39);
			this.removeAuthMethod_button.TabIndex = 4;
			this.removeAuthMethod_button.Text = "REMOVE authentication method";
			this.removeAuthMethod_button.UseVisualStyleBackColor = true;
			this.removeAuthMethod_button.Click += new System.EventHandler(this.button1_Click);
			// 
			// newAuthMethod_button
			// 
			this.newAuthMethod_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.newAuthMethod_button.Location = new System.Drawing.Point(219, 6);
			this.newAuthMethod_button.Name = "newAuthMethod_button";
			this.newAuthMethod_button.Size = new System.Drawing.Size(147, 39);
			this.newAuthMethod_button.TabIndex = 3;
			this.newAuthMethod_button.Text = "NEW authentication method";
			this.newAuthMethod_button.UseVisualStyleBackColor = true;
			this.newAuthMethod_button.Click += new System.EventHandler(this.newAuthMethod_button_Click);
			// 
			// authMethods_listBox
			// 
			this.authMethods_listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.authMethods_listBox.ItemHeight = 16;
			this.authMethods_listBox.Location = new System.Drawing.Point(4, 6);
			this.authMethods_listBox.Name = "authMethods_listBox";
			this.authMethods_listBox.Size = new System.Drawing.Size(209, 84);
			this.authMethods_listBox.TabIndex = 0;
			this.authMethods_listBox.SelectedIndexChanged += new System.EventHandler(this.authMethods_listBox_SelectedIndexChanged);
			// 
			// openingPictureBox
			// 
			this.openingPictureBox.BackgroundImage = global::pGina.Plugin.MFLoginPlugin.Properties.Resources.opening;
			this.openingPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.openingPictureBox.Location = new System.Drawing.Point(7, 126);
			this.openingPictureBox.Name = "openingPictureBox";
			this.openingPictureBox.Size = new System.Drawing.Size(75, 88);
			this.openingPictureBox.TabIndex = 19;
			this.openingPictureBox.TabStop = false;
			// 
			// keysRequired_label
			// 
			this.keysRequired_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.keysRequired_label.Location = new System.Drawing.Point(399, 87);
			this.keysRequired_label.Name = "keysRequired_label";
			this.keysRequired_label.Size = new System.Drawing.Size(204, 28);
			this.keysRequired_label.TabIndex = 20;
			this.keysRequired_label.Text = "How many keys are required?";
			this.keysRequired_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// successPictureBox
			// 
			this.successPictureBox.BackgroundImage = global::pGina.Plugin.MFLoginPlugin.Properties.Resources.success;
			this.successPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.successPictureBox.Location = new System.Drawing.Point(635, 124);
			this.successPictureBox.Name = "successPictureBox";
			this.successPictureBox.Size = new System.Drawing.Size(74, 89);
			this.successPictureBox.TabIndex = 18;
			this.successPictureBox.TabStop = false;
			// 
			// keysRequired_NumUpDown
			// 
			this.keysRequired_NumUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
			this.keysRequired_NumUpDown.Location = new System.Drawing.Point(610, 86);
			this.keysRequired_NumUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.keysRequired_NumUpDown.Name = "keysRequired_NumUpDown";
			this.keysRequired_NumUpDown.Size = new System.Drawing.Size(59, 29);
			this.keysRequired_NumUpDown.TabIndex = 13;
			this.keysRequired_NumUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.keysRequired_NumUpDown.ValueChanged += new System.EventHandler(this.keysRequired_NumUpDown_ValueChanged);
			// 
			// key5Label
			// 
			this.key5Label.Location = new System.Drawing.Point(526, 124);
			this.key5Label.Name = "key5Label";
			this.key5Label.Size = new System.Drawing.Size(95, 20);
			this.key5Label.TabIndex = 16;
			this.key5Label.Text = "Key 5";
			this.key5Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// key4Label
			// 
			this.key4Label.Location = new System.Drawing.Point(417, 124);
			this.key4Label.Name = "key4Label";
			this.key4Label.Size = new System.Drawing.Size(95, 20);
			this.key4Label.TabIndex = 15;
			this.key4Label.Text = "Key 4";
			this.key4Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.key4Label.Click += new System.EventHandler(this.key4Label_Click);
			// 
			// key3Label
			// 
			this.key3Label.Location = new System.Drawing.Point(307, 124);
			this.key3Label.Name = "key3Label";
			this.key3Label.Size = new System.Drawing.Size(95, 20);
			this.key3Label.TabIndex = 14;
			this.key3Label.Text = "Key 3";
			this.key3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// key2Label
			// 
			this.key2Label.Location = new System.Drawing.Point(198, 124);
			this.key2Label.Name = "key2Label";
			this.key2Label.Size = new System.Drawing.Size(95, 20);
			this.key2Label.TabIndex = 13;
			this.key2Label.Text = "Key 2";
			this.key2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// key1Label
			// 
			this.key1Label.Location = new System.Drawing.Point(94, 125);
			this.key1Label.Name = "key1Label";
			this.key1Label.Size = new System.Drawing.Size(95, 20);
			this.key1Label.TabIndex = 12;
			this.key1Label.Text = "Key 1";
			this.key1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// key3Button
			// 
			this.key3Button.AllowDrop = true;
			this.key3Button.Location = new System.Drawing.Point(307, 147);
			this.key3Button.Name = "key3Button";
			this.key3Button.Size = new System.Drawing.Size(100, 66);
			this.key3Button.TabIndex = 9;
			this.key3Button.UseVisualStyleBackColor = true;
			this.key3Button.Click += new System.EventHandler(this.OpenKeyConfig);
			this.key3Button.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragTarget_DragDrop);
			this.key3Button.DragOver += new System.Windows.Forms.DragEventHandler(this.DragTarget_DragOver);
			// 
			// key5Button
			// 
			this.key5Button.AllowDrop = true;
			this.key5Button.Location = new System.Drawing.Point(526, 147);
			this.key5Button.Name = "key5Button";
			this.key5Button.Size = new System.Drawing.Size(100, 66);
			this.key5Button.TabIndex = 11;
			this.key5Button.UseVisualStyleBackColor = true;
			this.key5Button.Click += new System.EventHandler(this.OpenKeyConfig);
			this.key5Button.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragTarget_DragDrop);
			this.key5Button.DragOver += new System.Windows.Forms.DragEventHandler(this.DragTarget_DragOver);
			// 
			// key4Button
			// 
			this.key4Button.AllowDrop = true;
			this.key4Button.Location = new System.Drawing.Point(417, 147);
			this.key4Button.Name = "key4Button";
			this.key4Button.Size = new System.Drawing.Size(100, 66);
			this.key4Button.TabIndex = 10;
			this.key4Button.UseVisualStyleBackColor = true;
			this.key4Button.Click += new System.EventHandler(this.OpenKeyConfig);
			this.key4Button.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragTarget_DragDrop);
			this.key4Button.DragOver += new System.Windows.Forms.DragEventHandler(this.DragTarget_DragOver);
			// 
			// key1Button
			// 
			this.key1Button.AllowDrop = true;
			this.key1Button.Location = new System.Drawing.Point(94, 148);
			this.key1Button.Name = "key1Button";
			this.key1Button.Size = new System.Drawing.Size(95, 66);
			this.key1Button.TabIndex = 7;
			this.key1Button.UseVisualStyleBackColor = true;
			this.key1Button.Click += new System.EventHandler(this.OpenKeyConfig);
			this.key1Button.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragTarget_DragDrop);
			this.key1Button.DragOver += new System.Windows.Forms.DragEventHandler(this.DragTarget_DragOver);
			// 
			// key2Button
			// 
			this.key2Button.AllowDrop = true;
			this.key2Button.Location = new System.Drawing.Point(198, 147);
			this.key2Button.Name = "key2Button";
			this.key2Button.Size = new System.Drawing.Size(100, 66);
			this.key2Button.TabIndex = 8;
			this.key2Button.UseVisualStyleBackColor = true;
			this.key2Button.Click += new System.EventHandler(this.OpenKeyConfig);
			this.key2Button.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragTarget_DragDrop);
			this.key2Button.DragOver += new System.Windows.Forms.DragEventHandler(this.DragTarget_DragOver);
			// 
			// UsersGroupBox
			// 
			this.UsersGroupBox.BackColor = System.Drawing.Color.Gainsboro;
			this.UsersGroupBox.Controls.Add(this.removeUser_button);
			this.UsersGroupBox.Controls.Add(this.addUser_button);
			this.UsersGroupBox.Controls.Add(this.userListBox);
			this.UsersGroupBox.Location = new System.Drawing.Point(9, 8);
			this.UsersGroupBox.Name = "UsersGroupBox";
			this.UsersGroupBox.Size = new System.Drawing.Size(238, 367);
			this.UsersGroupBox.TabIndex = 6;
			this.UsersGroupBox.TabStop = false;
			this.UsersGroupBox.Text = "Users";
			// 
			// removeUser_button
			// 
			this.removeUser_button.Location = new System.Drawing.Point(122, 335);
			this.removeUser_button.Name = "removeUser_button";
			this.removeUser_button.Size = new System.Drawing.Size(110, 26);
			this.removeUser_button.TabIndex = 8;
			this.removeUser_button.Text = "Remove";
			this.removeUser_button.UseVisualStyleBackColor = true;
			this.removeUser_button.Click += new System.EventHandler(this.removeUser_button_Click);
			// 
			// addUser_button
			// 
			this.addUser_button.Location = new System.Drawing.Point(6, 335);
			this.addUser_button.Name = "addUser_button";
			this.addUser_button.Size = new System.Drawing.Size(110, 26);
			this.addUser_button.TabIndex = 6;
			this.addUser_button.Text = "Add";
			this.addUser_button.UseVisualStyleBackColor = true;
			this.addUser_button.Click += new System.EventHandler(this.addUser_button_Click);
			// 
			// userListBox
			// 
			this.userListBox.FormattingEnabled = true;
			this.userListBox.ItemHeight = 15;
			this.userListBox.Location = new System.Drawing.Point(6, 27);
			this.userListBox.Name = "userListBox";
			this.userListBox.Size = new System.Drawing.Size(226, 304);
			this.userListBox.TabIndex = 5;
			this.userListBox.SelectedIndexChanged += new System.EventHandler(this.userListBox_SelectedIndexChanged);
			this.userListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.userListBox_MouseDown);
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.auth_tabPage);
			this.tabControl.Controls.Add(this.keys_tabPage);
			this.tabControl.Controls.Add(this.advancedSettings_tabPage);
			this.tabControl.Controls.Add(this.summary_tabPage);
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Top;
			this.tabControl.HotTrack = true;
			this.tabControl.Location = new System.Drawing.Point(0, 0);
			this.tabControl.Margin = new System.Windows.Forms.Padding(4);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(984, 410);
			this.tabControl.TabIndex = 5;
			this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
			this.tabControl.Click += new System.EventHandler(this.tabControl_Click);
			// 
			// summary_tabPage
			// 
			this.summary_tabPage.Location = new System.Drawing.Point(4, 24);
			this.summary_tabPage.Name = "summary_tabPage";
			this.summary_tabPage.Padding = new System.Windows.Forms.Padding(3);
			this.summary_tabPage.Size = new System.Drawing.Size(976, 382);
			this.summary_tabPage.TabIndex = 4;
			this.summary_tabPage.Text = "Information summary";
			this.summary_tabPage.UseVisualStyleBackColor = true;
			// 
			// LocalConfiguration
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 434);
			this.Controls.Add(this.controlPanel);
			this.Controls.Add(this.tabControl);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "LocalConfiguration";
			this.ShowIcon = false;
			this.Text = "Plugin Configuration";
			this.changeRole_contextMenuStrip.ResumeLayout(false);
			this.controlPanel.ResumeLayout(false);
			this.controlPanel.PerformLayout();
			this.advancedSettings_tabPage.ResumeLayout(false);
			this.keys_tabPage.ResumeLayout(false);
			this.keyInfo.ResumeLayout(false);
			this.keyInfo.PerformLayout();
			this.auth_tabPage.ResumeLayout(false);
			this.fastChoice_groupBox.ResumeLayout(false);
			this.user_groupBox.ResumeLayout(false);
			this.user_groupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.userIconPictureBox)).EndInit();
			this.authConfig.ResumeLayout(false);
			this.authConfig.PerformLayout();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.openingPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.successPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.keysRequired_NumUpDown)).EndInit();
			this.UsersGroupBox.ResumeLayout(false);
			this.tabControl.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStrip controlPanel;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
		private System.Windows.Forms.ContextMenuStrip changeRole_contextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem user_toolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem admin_toolStripMenuItem;
		private System.Windows.Forms.TabPage advancedSettings_tabPage;
		private System.Windows.Forms.Button runSetup_button;
		private System.Windows.Forms.TabPage keys_tabPage;
		private System.Windows.Forms.Button refreshKeyList_button;
		private System.Windows.Forms.Button removeUnusedKeys_button;
		private System.Windows.Forms.ListBox keysListBox;
		private System.Windows.Forms.TabPage auth_tabPage;
		private System.Windows.Forms.GroupBox fastChoice_groupBox;
		private System.Windows.Forms.ListView fastChoiceTypes_listView;
		private System.Windows.Forms.GroupBox user_groupBox;
		private System.Windows.Forms.PictureBox userIconPictureBox;
		private System.Windows.Forms.CheckBox keepPassword_checkBox;
		private System.Windows.Forms.TextBox role_textBox;
		private System.Windows.Forms.TextBox userName_textBox;
		private System.Windows.Forms.GroupBox authConfig;
		private System.Windows.Forms.TextBox description_textBox;
		private System.Windows.Forms.Label description_label;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button removeAuthMethod_button;
		private System.Windows.Forms.Button newAuthMethod_button;
		private System.Windows.Forms.ListBox authMethods_listBox;
		private System.Windows.Forms.PictureBox openingPictureBox;
		private System.Windows.Forms.Label keysRequired_label;
		private System.Windows.Forms.PictureBox successPictureBox;
		private System.Windows.Forms.NumericUpDown keysRequired_NumUpDown;
		private System.Windows.Forms.Label key5Label;
		private System.Windows.Forms.Label key4Label;
		private System.Windows.Forms.Label key3Label;
		private System.Windows.Forms.Label key2Label;
		private System.Windows.Forms.Label key1Label;
		private System.Windows.Forms.Button key3Button;
		private System.Windows.Forms.Button key5Button;
		private System.Windows.Forms.Button key4Button;
		private System.Windows.Forms.Button key1Button;
		private System.Windows.Forms.Button key2Button;
		private System.Windows.Forms.GroupBox UsersGroupBox;
		private System.Windows.Forms.Button removeUser_button;
		private System.Windows.Forms.Button addUser_button;
		private System.Windows.Forms.ListBox userListBox;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.GroupBox keyInfo;
		private System.Windows.Forms.TextBox keyDescription_textBox;
		private System.Windows.Forms.Label keyDescription_label;
		private System.Windows.Forms.CheckBox keyInverted_checkBox;
		private System.Windows.Forms.Label keyType_label;
		private System.Windows.Forms.CheckBox keyData_checkBox;
		private System.Windows.Forms.CheckBox keyPassword_checkBox;
		private System.Windows.Forms.CheckBox keySerial_checkBox;
		private System.Windows.Forms.Button keyConfigure_button;
		private System.Windows.Forms.TabPage summary_tabPage;
	}
}