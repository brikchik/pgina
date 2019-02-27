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
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Password"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.InactiveBorder, null);
			System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "USB"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.InactiveBorder, null);
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalConfiguration));
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.fastChoice_groupBox = new System.Windows.Forms.GroupBox();
			this.fastChoiceTypes_listView = new System.Windows.Forms.ListView();
			this.fastChoiceKeys_listView = new System.Windows.Forms.ListView();
			this.user_groupBox = new System.Windows.Forms.GroupBox();
			this.userIconPictureBox = new System.Windows.Forms.PictureBox();
			this.role_textBox = new System.Windows.Forms.TextBox();
			this.userName_textBox = new System.Windows.Forms.TextBox();
			this.authConfig = new System.Windows.Forms.GroupBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.newAuthMethod_button = new System.Windows.Forms.Button();
			this.nextAuthMethod_button = new System.Windows.Forms.Button();
			this.prevAuthMethod_button = new System.Windows.Forms.Button();
			this.authMethods_listBox = new System.Windows.Forms.ListBox();
			this.keepPassword_checkBox = new System.Windows.Forms.CheckBox();
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
			this.createUser_button = new System.Windows.Forms.Button();
			this.addUser_button = new System.Windows.Forms.Button();
			this.userListBox = new System.Windows.Forms.ListBox();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.newKey_label = new System.Windows.Forms.Label();
			this.newBluetooth_button = new System.Windows.Forms.Button();
			this.newUSB_button = new System.Windows.Forms.Button();
			this.newPassword_button = new System.Windows.Forms.Button();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.newUser_label = new System.Windows.Forms.Label();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.runSetup_button = new System.Windows.Forms.Button();
			this.controlPanel = new System.Windows.Forms.ToolStrip();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
			this.tabControl.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.fastChoice_groupBox.SuspendLayout();
			this.user_groupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.userIconPictureBox)).BeginInit();
			this.authConfig.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.openingPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.successPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.keysRequired_NumUpDown)).BeginInit();
			this.UsersGroupBox.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.controlPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabPage1);
			this.tabControl.Controls.Add(this.tabPage3);
			this.tabControl.Controls.Add(this.tabPage2);
			this.tabControl.Controls.Add(this.tabPage4);
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Top;
			this.tabControl.HotTrack = true;
			this.tabControl.Location = new System.Drawing.Point(0, 0);
			this.tabControl.Margin = new System.Windows.Forms.Padding(4);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(945, 392);
			this.tabControl.TabIndex = 5;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.fastChoice_groupBox);
			this.tabPage1.Controls.Add(this.user_groupBox);
			this.tabPage1.Controls.Add(this.authConfig);
			this.tabPage1.Controls.Add(this.UsersGroupBox);
			this.tabPage1.Location = new System.Drawing.Point(4, 24);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
			this.tabPage1.Size = new System.Drawing.Size(937, 364);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Authentication";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// fastChoice_groupBox
			// 
			this.fastChoice_groupBox.BackColor = System.Drawing.Color.Thistle;
			this.fastChoice_groupBox.Controls.Add(this.fastChoiceTypes_listView);
			this.fastChoice_groupBox.Controls.Add(this.fastChoiceKeys_listView);
			this.fastChoice_groupBox.Location = new System.Drawing.Point(473, 219);
			this.fastChoice_groupBox.Name = "fastChoice_groupBox";
			this.fastChoice_groupBox.Size = new System.Drawing.Size(456, 138);
			this.fastChoice_groupBox.TabIndex = 19;
			this.fastChoice_groupBox.TabStop = false;
			this.fastChoice_groupBox.Text = "Fast choice";
			// 
			// fastChoiceTypes_listView
			// 
			this.fastChoiceTypes_listView.Alignment = System.Windows.Forms.ListViewAlignment.Default;
			this.fastChoiceTypes_listView.AutoArrange = false;
			this.fastChoiceTypes_listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			listViewItem1.Tag = "Password";
			listViewItem2.Tag = "USBDevice";
			this.fastChoiceTypes_listView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
			this.fastChoiceTypes_listView.LabelWrap = false;
			this.fastChoiceTypes_listView.Location = new System.Drawing.Point(6, 20);
			this.fastChoiceTypes_listView.MultiSelect = false;
			this.fastChoiceTypes_listView.Name = "fastChoiceTypes_listView";
			this.fastChoiceTypes_listView.ShowGroups = false;
			this.fastChoiceTypes_listView.Size = new System.Drawing.Size(210, 109);
			this.fastChoiceTypes_listView.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.fastChoiceTypes_listView.TabIndex = 4;
			this.fastChoiceTypes_listView.UseCompatibleStateImageBehavior = false;
			this.fastChoiceTypes_listView.SelectedIndexChanged += new System.EventHandler(this.fastChoiceTypes_listView_SelectedIndexChanged);
			this.fastChoiceTypes_listView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragSource_MouseDown);
			this.fastChoiceTypes_listView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragSource_MouseMove);
			this.fastChoiceTypes_listView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragSource_MouseUp);
			// 
			// fastChoiceKeys_listView
			// 
			this.fastChoiceKeys_listView.Alignment = System.Windows.Forms.ListViewAlignment.Default;
			this.fastChoiceKeys_listView.AutoArrange = false;
			this.fastChoiceKeys_listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.fastChoiceKeys_listView.LabelWrap = false;
			this.fastChoiceKeys_listView.Location = new System.Drawing.Point(226, 20);
			this.fastChoiceKeys_listView.MultiSelect = false;
			this.fastChoiceKeys_listView.Name = "fastChoiceKeys_listView";
			this.fastChoiceKeys_listView.ShowGroups = false;
			this.fastChoiceKeys_listView.Size = new System.Drawing.Size(224, 109);
			this.fastChoiceKeys_listView.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.fastChoiceKeys_listView.TabIndex = 5;
			this.fastChoiceKeys_listView.UseCompatibleStateImageBehavior = false;
			this.fastChoiceKeys_listView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragSource_MouseDown);
			this.fastChoiceKeys_listView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragSource_MouseMove);
			this.fastChoiceKeys_listView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragSource_MouseUp);
			// 
			// user_groupBox
			// 
			this.user_groupBox.BackColor = System.Drawing.Color.Wheat;
			this.user_groupBox.Controls.Add(this.userIconPictureBox);
			this.user_groupBox.Controls.Add(this.role_textBox);
			this.user_groupBox.Controls.Add(this.userName_textBox);
			this.user_groupBox.Location = new System.Drawing.Point(253, 217);
			this.user_groupBox.Name = "user_groupBox";
			this.user_groupBox.Size = new System.Drawing.Size(214, 140);
			this.user_groupBox.TabIndex = 18;
			this.user_groupBox.TabStop = false;
			this.user_groupBox.Text = "User";
			// 
			// userIconPictureBox
			// 
			this.userIconPictureBox.BackColor = System.Drawing.Color.SeaShell;
			this.userIconPictureBox.BackgroundImage = global::pGina.Plugin.MFLoginPlugin.Properties.Resources.user_logo;
			this.userIconPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.userIconPictureBox.InitialImage = null;
			this.userIconPictureBox.Location = new System.Drawing.Point(6, 24);
			this.userIconPictureBox.Name = "userIconPictureBox";
			this.userIconPictureBox.Size = new System.Drawing.Size(70, 73);
			this.userIconPictureBox.TabIndex = 17;
			this.userIconPictureBox.TabStop = false;
			// 
			// role_textBox
			// 
			this.role_textBox.BackColor = System.Drawing.SystemColors.Info;
			this.role_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.role_textBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.role_textBox.Location = new System.Drawing.Point(82, 24);
			this.role_textBox.MaxLength = 30;
			this.role_textBox.Name = "role_textBox";
			this.role_textBox.ReadOnly = true;
			this.role_textBox.Size = new System.Drawing.Size(126, 24);
			this.role_textBox.TabIndex = 22;
			this.role_textBox.TabStop = false;
			this.role_textBox.Text = "Administrator";
			this.role_textBox.WordWrap = false;
			// 
			// userName_textBox
			// 
			this.userName_textBox.BackColor = System.Drawing.SystemColors.Info;
			this.userName_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.userName_textBox.Location = new System.Drawing.Point(6, 105);
			this.userName_textBox.MaxLength = 128;
			this.userName_textBox.Name = "userName_textBox";
			this.userName_textBox.ReadOnly = true;
			this.userName_textBox.Size = new System.Drawing.Size(202, 26);
			this.userName_textBox.TabIndex = 21;
			this.userName_textBox.TabStop = false;
			this.userName_textBox.Text = "Username";
			this.userName_textBox.WordWrap = false;
			// 
			// authConfig
			// 
			this.authConfig.BackColor = System.Drawing.Color.SkyBlue;
			this.authConfig.Controls.Add(this.panel1);
			this.authConfig.Controls.Add(this.keepPassword_checkBox);
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
			this.authConfig.Size = new System.Drawing.Size(676, 203);
			this.authConfig.TabIndex = 12;
			this.authConfig.TabStop = false;
			this.authConfig.Text = "User authentication";
			this.authConfig.Enter += new System.EventHandler(this.authConfig_Enter);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.newAuthMethod_button);
			this.panel1.Controls.Add(this.nextAuthMethod_button);
			this.panel1.Controls.Add(this.prevAuthMethod_button);
			this.panel1.Controls.Add(this.authMethods_listBox);
			this.panel1.Location = new System.Drawing.Point(7, 21);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(379, 98);
			this.panel1.TabIndex = 24;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.button1.Location = new System.Drawing.Point(219, 51);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(147, 39);
			this.button1.TabIndex = 4;
			this.button1.Text = "REMOVE authentication method";
			this.button1.UseVisualStyleBackColor = true;
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
			// 
			// nextAuthMethod_button
			// 
			this.nextAuthMethod_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
			this.nextAuthMethod_button.Location = new System.Drawing.Point(163, 51);
			this.nextAuthMethod_button.Name = "nextAuthMethod_button";
			this.nextAuthMethod_button.Size = new System.Drawing.Size(44, 39);
			this.nextAuthMethod_button.TabIndex = 2;
			this.nextAuthMethod_button.Text = "↓";
			this.nextAuthMethod_button.UseVisualStyleBackColor = true;
			// 
			// prevAuthMethod_button
			// 
			this.prevAuthMethod_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
			this.prevAuthMethod_button.Location = new System.Drawing.Point(163, 6);
			this.prevAuthMethod_button.Name = "prevAuthMethod_button";
			this.prevAuthMethod_button.Size = new System.Drawing.Size(44, 39);
			this.prevAuthMethod_button.TabIndex = 1;
			this.prevAuthMethod_button.Text = "↑";
			this.prevAuthMethod_button.UseVisualStyleBackColor = true;
			// 
			// authMethods_listBox
			// 
			this.authMethods_listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.authMethods_listBox.ItemHeight = 16;
			this.authMethods_listBox.Items.AddRange(new object[] {
            "Authentication method 1"});
			this.authMethods_listBox.Location = new System.Drawing.Point(4, 6);
			this.authMethods_listBox.Name = "authMethods_listBox";
			this.authMethods_listBox.Size = new System.Drawing.Size(153, 84);
			this.authMethods_listBox.TabIndex = 0;
			this.authMethods_listBox.SelectedIndexChanged += new System.EventHandler(this.authMethods_listBox_SelectedIndexChanged);
			// 
			// keepPassword_checkBox
			// 
			this.keepPassword_checkBox.AutoSize = true;
			this.keepPassword_checkBox.Checked = true;
			this.keepPassword_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.keepPassword_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.keepPassword_checkBox.Location = new System.Drawing.Point(405, 90);
			this.keepPassword_checkBox.Name = "keepPassword_checkBox";
			this.keepPassword_checkBox.Size = new System.Drawing.Size(187, 21);
			this.keepPassword_checkBox.TabIndex = 23;
			this.keepPassword_checkBox.Text = "Keep password in the OS";
			this.keepPassword_checkBox.UseVisualStyleBackColor = true;
			this.keepPassword_checkBox.Click += new System.EventHandler(this.keepPassword_checkBox_Click);
			// 
			// openingPictureBox
			// 
			this.openingPictureBox.BackgroundImage = global::pGina.Plugin.MFLoginPlugin.Properties.Resources.opening;
			this.openingPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.openingPictureBox.Location = new System.Drawing.Point(7, 125);
			this.openingPictureBox.Name = "openingPictureBox";
			this.openingPictureBox.Size = new System.Drawing.Size(69, 72);
			this.openingPictureBox.TabIndex = 19;
			this.openingPictureBox.TabStop = false;
			// 
			// keysRequired_label
			// 
			this.keysRequired_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.keysRequired_label.Location = new System.Drawing.Point(402, 53);
			this.keysRequired_label.Name = "keysRequired_label";
			this.keysRequired_label.Size = new System.Drawing.Size(204, 28);
			this.keysRequired_label.TabIndex = 20;
			this.keysRequired_label.Text = "How many keys are required?";
			this.keysRequired_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// successPictureBox
			// 
			this.successPictureBox.BackgroundImage = global::pGina.Plugin.MFLoginPlugin.Properties.Resources.success;
			this.successPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.successPictureBox.Location = new System.Drawing.Point(602, 124);
			this.successPictureBox.Name = "successPictureBox";
			this.successPictureBox.Size = new System.Drawing.Size(67, 73);
			this.successPictureBox.TabIndex = 18;
			this.successPictureBox.TabStop = false;
			// 
			// keysRequired_NumUpDown
			// 
			this.keysRequired_NumUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
			this.keysRequired_NumUpDown.Location = new System.Drawing.Point(613, 52);
			this.keysRequired_NumUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.keysRequired_NumUpDown.Name = "keysRequired_NumUpDown";
			this.keysRequired_NumUpDown.Size = new System.Drawing.Size(56, 29);
			this.keysRequired_NumUpDown.TabIndex = 13;
			this.keysRequired_NumUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			// 
			// key5Label
			// 
			this.key5Label.Location = new System.Drawing.Point(498, 124);
			this.key5Label.Name = "key5Label";
			this.key5Label.Size = new System.Drawing.Size(95, 20);
			this.key5Label.TabIndex = 16;
			this.key5Label.Text = "Key 5";
			this.key5Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// key4Label
			// 
			this.key4Label.Location = new System.Drawing.Point(396, 124);
			this.key4Label.Name = "key4Label";
			this.key4Label.Size = new System.Drawing.Size(95, 20);
			this.key4Label.TabIndex = 15;
			this.key4Label.Text = "Key 4";
			this.key4Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// key3Label
			// 
			this.key3Label.Location = new System.Drawing.Point(288, 124);
			this.key3Label.Name = "key3Label";
			this.key3Label.Size = new System.Drawing.Size(95, 20);
			this.key3Label.TabIndex = 14;
			this.key3Label.Text = "Key 3";
			this.key3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// key2Label
			// 
			this.key2Label.Location = new System.Drawing.Point(187, 124);
			this.key2Label.Name = "key2Label";
			this.key2Label.Size = new System.Drawing.Size(95, 20);
			this.key2Label.TabIndex = 13;
			this.key2Label.Text = "Key 2";
			this.key2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// key1Label
			// 
			this.key1Label.Location = new System.Drawing.Point(84, 125);
			this.key1Label.Name = "key1Label";
			this.key1Label.Size = new System.Drawing.Size(95, 20);
			this.key1Label.TabIndex = 12;
			this.key1Label.Text = "Key 1";
			this.key1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// key3Button
			// 
			this.key3Button.AllowDrop = true;
			this.key3Button.Location = new System.Drawing.Point(291, 147);
			this.key3Button.Name = "key3Button";
			this.key3Button.Size = new System.Drawing.Size(95, 50);
			this.key3Button.TabIndex = 9;
			this.key3Button.UseVisualStyleBackColor = true;
			this.key3Button.Click += new System.EventHandler(this.OpenKeyConfig);
			this.key3Button.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragTarget_DragDrop);
			this.key3Button.DragOver += new System.Windows.Forms.DragEventHandler(this.DragTarget_DragOver);
			// 
			// key5Button
			// 
			this.key5Button.AllowDrop = true;
			this.key5Button.Location = new System.Drawing.Point(501, 147);
			this.key5Button.Name = "key5Button";
			this.key5Button.Size = new System.Drawing.Size(95, 50);
			this.key5Button.TabIndex = 11;
			this.key5Button.UseVisualStyleBackColor = true;
			this.key5Button.Click += new System.EventHandler(this.OpenKeyConfig);
			this.key5Button.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragTarget_DragDrop);
			this.key5Button.DragOver += new System.Windows.Forms.DragEventHandler(this.DragTarget_DragOver);
			// 
			// key4Button
			// 
			this.key4Button.AllowDrop = true;
			this.key4Button.Location = new System.Drawing.Point(396, 147);
			this.key4Button.Name = "key4Button";
			this.key4Button.Size = new System.Drawing.Size(95, 50);
			this.key4Button.TabIndex = 10;
			this.key4Button.UseVisualStyleBackColor = true;
			this.key4Button.Click += new System.EventHandler(this.OpenKeyConfig);
			this.key4Button.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragTarget_DragDrop);
			this.key4Button.DragOver += new System.Windows.Forms.DragEventHandler(this.DragTarget_DragOver);
			// 
			// key1Button
			// 
			this.key1Button.AllowDrop = true;
			this.key1Button.Location = new System.Drawing.Point(84, 147);
			this.key1Button.Name = "key1Button";
			this.key1Button.Size = new System.Drawing.Size(95, 50);
			this.key1Button.TabIndex = 7;
			this.key1Button.UseVisualStyleBackColor = true;
			this.key1Button.Click += new System.EventHandler(this.OpenKeyConfig);
			this.key1Button.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragTarget_DragDrop);
			this.key1Button.DragOver += new System.Windows.Forms.DragEventHandler(this.DragTarget_DragOver);
			// 
			// key2Button
			// 
			this.key2Button.AllowDrop = true;
			this.key2Button.Location = new System.Drawing.Point(187, 147);
			this.key2Button.Name = "key2Button";
			this.key2Button.Size = new System.Drawing.Size(95, 50);
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
			this.UsersGroupBox.Controls.Add(this.createUser_button);
			this.UsersGroupBox.Controls.Add(this.addUser_button);
			this.UsersGroupBox.Controls.Add(this.userListBox);
			this.UsersGroupBox.Location = new System.Drawing.Point(9, 8);
			this.UsersGroupBox.Name = "UsersGroupBox";
			this.UsersGroupBox.Size = new System.Drawing.Size(238, 349);
			this.UsersGroupBox.TabIndex = 6;
			this.UsersGroupBox.TabStop = false;
			this.UsersGroupBox.Text = "Users";
			// 
			// removeUser_button
			// 
			this.removeUser_button.Location = new System.Drawing.Point(162, 317);
			this.removeUser_button.Name = "removeUser_button";
			this.removeUser_button.Size = new System.Drawing.Size(70, 26);
			this.removeUser_button.TabIndex = 8;
			this.removeUser_button.Text = "Remove";
			this.removeUser_button.UseVisualStyleBackColor = true;
			this.removeUser_button.Click += new System.EventHandler(this.removeUser_button_Click);
			// 
			// createUser_button
			// 
			this.createUser_button.Location = new System.Drawing.Point(82, 317);
			this.createUser_button.Name = "createUser_button";
			this.createUser_button.Size = new System.Drawing.Size(74, 26);
			this.createUser_button.TabIndex = 7;
			this.createUser_button.Text = "Create";
			this.createUser_button.UseVisualStyleBackColor = true;
			// 
			// addUser_button
			// 
			this.addUser_button.Location = new System.Drawing.Point(6, 317);
			this.addUser_button.Name = "addUser_button";
			this.addUser_button.Size = new System.Drawing.Size(70, 26);
			this.addUser_button.TabIndex = 6;
			this.addUser_button.Text = "Add existing";
			this.addUser_button.UseVisualStyleBackColor = true;
			// 
			// userListBox
			// 
			this.userListBox.FormattingEnabled = true;
			this.userListBox.ItemHeight = 15;
			this.userListBox.Location = new System.Drawing.Point(6, 27);
			this.userListBox.Name = "userListBox";
			this.userListBox.Size = new System.Drawing.Size(226, 274);
			this.userListBox.TabIndex = 5;
			this.userListBox.SelectedIndexChanged += new System.EventHandler(this.userListBox_SelectedIndexChanged);
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.newKey_label);
			this.tabPage3.Controls.Add(this.newBluetooth_button);
			this.tabPage3.Controls.Add(this.newUSB_button);
			this.tabPage3.Controls.Add(this.newPassword_button);
			this.tabPage3.Location = new System.Drawing.Point(4, 24);
			this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
			this.tabPage3.Size = new System.Drawing.Size(937, 364);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Keys";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// newKey_label
			// 
			this.newKey_label.BackColor = System.Drawing.Color.DarkSalmon;
			this.newKey_label.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.newKey_label.Location = new System.Drawing.Point(10, 18);
			this.newKey_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.newKey_label.Name = "newKey_label";
			this.newKey_label.Size = new System.Drawing.Size(150, 38);
			this.newKey_label.TabIndex = 13;
			this.newKey_label.Text = "New key";
			this.newKey_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// newBluetooth_button
			// 
			this.newBluetooth_button.Location = new System.Drawing.Point(10, 151);
			this.newBluetooth_button.Margin = new System.Windows.Forms.Padding(4);
			this.newBluetooth_button.Name = "newBluetooth_button";
			this.newBluetooth_button.Size = new System.Drawing.Size(150, 38);
			this.newBluetooth_button.TabIndex = 12;
			this.newBluetooth_button.Text = "Bluetooth Device";
			this.newBluetooth_button.UseVisualStyleBackColor = true;
			this.newBluetooth_button.Click += new System.EventHandler(this.newBluetooth_button_Click);
			// 
			// newUSB_button
			// 
			this.newUSB_button.Location = new System.Drawing.Point(10, 106);
			this.newUSB_button.Margin = new System.Windows.Forms.Padding(4);
			this.newUSB_button.Name = "newUSB_button";
			this.newUSB_button.Size = new System.Drawing.Size(150, 38);
			this.newUSB_button.TabIndex = 11;
			this.newUSB_button.Text = "Any USB device";
			this.newUSB_button.UseVisualStyleBackColor = true;
			this.newUSB_button.Click += new System.EventHandler(this.newUSB_button_Click);
			// 
			// newPassword_button
			// 
			this.newPassword_button.Location = new System.Drawing.Point(10, 61);
			this.newPassword_button.Margin = new System.Windows.Forms.Padding(4);
			this.newPassword_button.Name = "newPassword_button";
			this.newPassword_button.Size = new System.Drawing.Size(150, 38);
			this.newPassword_button.TabIndex = 10;
			this.newPassword_button.Text = "Password";
			this.newPassword_button.UseVisualStyleBackColor = true;
			this.newPassword_button.Click += new System.EventHandler(this.newPassword_button_Click);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.newUser_label);
			this.tabPage2.Location = new System.Drawing.Point(4, 24);
			this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
			this.tabPage2.Size = new System.Drawing.Size(937, 364);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Users";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// newUser_label
			// 
			this.newUser_label.BackColor = System.Drawing.Color.DarkSalmon;
			this.newUser_label.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.newUser_label.Location = new System.Drawing.Point(10, 16);
			this.newUser_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.newUser_label.Name = "newUser_label";
			this.newUser_label.Size = new System.Drawing.Size(150, 38);
			this.newUser_label.TabIndex = 14;
			this.newUser_label.Text = "New user";
			this.newUser_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.runSetup_button);
			this.tabPage4.Location = new System.Drawing.Point(4, 24);
			this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
			this.tabPage4.Size = new System.Drawing.Size(937, 364);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Advanced settings";
			this.tabPage4.UseVisualStyleBackColor = true;
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
			// controlPanel
			// 
			this.controlPanel.AutoSize = false;
			this.controlPanel.CanOverflow = false;
			this.controlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.controlPanel.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.controlPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton4,
            this.toolStripButton3});
			this.controlPanel.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.controlPanel.Location = new System.Drawing.Point(0, 389);
			this.controlPanel.Name = "controlPanel";
			this.controlPanel.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.controlPanel.Size = new System.Drawing.Size(945, 28);
			this.controlPanel.TabIndex = 6;
			this.controlPanel.Text = "toolStrip1";
			this.controlPanel.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.controlPanel_ItemClicked);
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(49, 25);
			this.toolStripButton2.Text = "English";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(56, 25);
			this.toolStripButton1.Text = "Русский";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
			// 
			// toolStripButton4
			// 
			this.toolStripButton4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripButton4.AutoSize = false;
			this.toolStripButton4.BackColor = System.Drawing.SystemColors.ControlDark;
			this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
			this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton4.Name = "toolStripButton4";
			this.toolStripButton4.Size = new System.Drawing.Size(100, 25);
			this.toolStripButton4.Text = "CANCEL";
			this.toolStripButton4.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// toolStripButton3
			// 
			this.toolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripButton3.AutoSize = false;
			this.toolStripButton3.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
			this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton3.Name = "toolStripButton3";
			this.toolStripButton3.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
			this.toolStripButton3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.toolStripButton3.Size = new System.Drawing.Size(100, 25);
			this.toolStripButton3.Text = "OK";
			this.toolStripButton3.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// LocalConfiguration
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(945, 417);
			this.Controls.Add(this.controlPanel);
			this.Controls.Add(this.tabControl);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "LocalConfiguration";
			this.ShowIcon = false;
			this.Text = "Plugin Configuration";
			this.tabControl.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
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
			this.tabPage3.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage4.ResumeLayout(false);
			this.controlPanel.ResumeLayout(false);
			this.controlPanel.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label newUser_label;
        private System.Windows.Forms.Label newKey_label;
        private System.Windows.Forms.Button newBluetooth_button;
        private System.Windows.Forms.Button newUSB_button;
        private System.Windows.Forms.Button newPassword_button;
        private System.Windows.Forms.Button runSetup_button;
        private System.Windows.Forms.ToolStrip controlPanel;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ListView fastChoiceTypes_listView;
        private System.Windows.Forms.GroupBox UsersGroupBox;
        private System.Windows.Forms.ListBox userListBox;
        private System.Windows.Forms.GroupBox authConfig;
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
		private System.Windows.Forms.PictureBox successPictureBox;
		private System.Windows.Forms.PictureBox userIconPictureBox;
		private System.Windows.Forms.PictureBox openingPictureBox;
		private System.Windows.Forms.Label keysRequired_label;
		private System.Windows.Forms.NumericUpDown keysRequired_NumUpDown;
		private System.Windows.Forms.TextBox userName_textBox;
		private System.Windows.Forms.TextBox role_textBox;
		private System.Windows.Forms.CheckBox keepPassword_checkBox;
		private System.Windows.Forms.GroupBox user_groupBox;
		private System.Windows.Forms.GroupBox fastChoice_groupBox;
		private System.Windows.Forms.ListView fastChoiceKeys_listView;
		private System.Windows.Forms.Button removeUser_button;
		private System.Windows.Forms.Button createUser_button;
		private System.Windows.Forms.Button addUser_button;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button prevAuthMethod_button;
		private System.Windows.Forms.ListBox authMethods_listBox;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button newAuthMethod_button;
		private System.Windows.Forms.Button nextAuthMethod_button;
	}
}