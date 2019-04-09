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
            "BluetoothDevice (any device, 5 - 15 seconds to check)"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.MenuBar, null);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "ConnectedDevice"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.MenuBar, null);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "Encrypted Password File (with Windows password)"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.MenuBar, null);
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            "eToken USB"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.MenuBar, null);
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem(new string[] {
            "Password"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.MenuBar, null);
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem(new string[] {
            "Website http request"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.MenuBar, null);
            this.changeRole_contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.user_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.admin_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlPanel = new System.Windows.Forms.ToolStrip();
            this.ok_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cancel_toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.advancedSettings_tabPage = new System.Windows.Forms.TabPage();
            this.keysAdvancedSettings_groupBox = new System.Windows.Forms.GroupBox();
            this.onlyPairedBluetoothDevices_checkBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RestoreWindowsUsers_button = new System.Windows.Forms.Button();
            this.cleanDB_button = new System.Windows.Forms.Button();
            this.cleanDBKeys_button = new System.Windows.Forms.Button();
            this.otherAdvancedSettings_groupBox = new System.Windows.Forms.GroupBox();
            this.maxAuthTime_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.maxAuthTime_label = new System.Windows.Forms.Label();
            this.showpGinaLogs_checkBox = new System.Windows.Forms.CheckBox();
            this.openSummaryCollapsed_checkBox = new System.Windows.Forms.CheckBox();
            this.advancedSettings_alwaysCheckSelectedKey_checkBox = new System.Windows.Forms.CheckBox();
            this.requireAtLeastOneKeyInAuthMethod_checkBox = new System.Windows.Forms.CheckBox();
            this.database_groupBox = new System.Windows.Forms.GroupBox();
            this.DBOpened_checkBox = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dbErase_checkBox = new System.Windows.Forms.CheckBox();
            this.dbErase_button = new System.Windows.Forms.Button();
            this.database_label = new System.Windows.Forms.Label();
            this.runSetup_button = new System.Windows.Forms.Button();
            this.backup_groupBox = new System.Windows.Forms.GroupBox();
            this.backup_panel = new System.Windows.Forms.Panel();
            this.backupPassword_label = new System.Windows.Forms.Label();
            this.backupPath_button = new System.Windows.Forms.Button();
            this.backupPassword_textBox = new System.Windows.Forms.TextBox();
            this.backupPath_textBox = new System.Windows.Forms.TextBox();
            this.backupBackup_button = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dbBackupWarning_label = new System.Windows.Forms.Label();
            this.onLoadBackupEnabled_checkBox = new System.Windows.Forms.CheckBox();
            this.discardChanges_linkLabel = new System.Windows.Forms.LinkLabel();
            this.keys_tabPage = new System.Windows.Forms.TabPage();
            this.checkKey_groupBox = new System.Windows.Forms.GroupBox();
            this.checkKeyResult_button = new System.Windows.Forms.Button();
            this.checkKey_button = new System.Windows.Forms.Button();
            this.checkPassword_label = new System.Windows.Forms.Label();
            this.checkPassword_textBox = new System.Windows.Forms.TextBox();
            this.removeUnusedKeys_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.keyRemoval_checkBox = new System.Windows.Forms.CheckBox();
            this.deleteKey_button = new System.Windows.Forms.Button();
            this.keyInfo_groupBox = new System.Windows.Forms.GroupBox();
            this.keySerial_textBox = new System.Windows.Forms.TextBox();
            this.keyConfigure_button = new System.Windows.Forms.Button();
            this.keyData_checkBox = new System.Windows.Forms.CheckBox();
            this.keyPassword_checkBox = new System.Windows.Forms.CheckBox();
            this.keySerial_checkBox = new System.Windows.Forms.CheckBox();
            this.keyType_label = new System.Windows.Forms.Label();
            this.keyInverted_checkBox = new System.Windows.Forms.CheckBox();
            this.keyDescription_textBox = new System.Windows.Forms.TextBox();
            this.keyDescription_label = new System.Windows.Forms.Label();
            this.keysListBox = new System.Windows.Forms.ListBox();
            this.auth_tabPage = new System.Windows.Forms.TabPage();
            this.fastChoice_groupBox = new System.Windows.Forms.GroupBox();
            this.fastChoiceTypes_listView = new System.Windows.Forms.ListView();
            this.authConfig = new System.Windows.Forms.GroupBox();
            this.keysRequired_NumUpDown = new System.Windows.Forms.NumericUpDown();
            this.successPictureBox = new System.Windows.Forms.PictureBox();
            this.locked_pictureBox = new System.Windows.Forms.PictureBox();
            this.testAM_groupBox = new System.Windows.Forms.GroupBox();
            this.testAMpassword_textBox = new System.Windows.Forms.TextBox();
            this.openingPictureBox = new System.Windows.Forms.PictureBox();
            this.description_textBox = new System.Windows.Forms.TextBox();
            this.description_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.removeAuthMethod_button = new System.Windows.Forms.Button();
            this.newAuthMethod_button = new System.Windows.Forms.Button();
            this.authMethods_listBox = new System.Windows.Forms.ListBox();
            this.keysRequired_label = new System.Windows.Forms.Label();
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
            this.removeWithProfile_checkBox = new System.Windows.Forms.CheckBox();
            this.removeWindowsUser_checkBox = new System.Windows.Forms.CheckBox();
            this.addUser_button = new System.Windows.Forms.Button();
            this.user_ListBox = new System.Windows.Forms.ListBox();
            this.user_groupBox = new System.Windows.Forms.GroupBox();
            this.role_textBox = new System.Windows.Forms.Label();
            this.userIconPictureBox = new System.Windows.Forms.PictureBox();
            this.keepPassword_checkBox = new System.Windows.Forms.CheckBox();
            this.userName_textBox = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.summary_tabPage = new System.Windows.Forms.TabPage();
            this.collapseAll_button = new System.Windows.Forms.Button();
            this.expandAll_button = new System.Windows.Forms.Button();
            this.summary_treeView = new System.Windows.Forms.TreeView();
            this.logs_tabPage = new System.Windows.Forms.TabPage();
            this.logControl_groupBox = new System.Windows.Forms.GroupBox();
            this.thisMonthLogs_radioButton = new System.Windows.Forms.RadioButton();
            this.todayLogs_radioButton = new System.Windows.Forms.RadioButton();
            this.countLogs_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.allLogs_radioButton = new System.Windows.Forms.RadioButton();
            this.extraLogs_checkBox = new System.Windows.Forms.CheckBox();
            this.firstLogs_radioButton = new System.Windows.Forms.RadioButton();
            this.lastLogs_radioButton = new System.Windows.Forms.RadioButton();
            this.logs_dataView = new System.Windows.Forms.DataGridView();
            this.user_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authMethodDescription_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.success_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keysUsed_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pGinaLogs_tabPage = new System.Windows.Forms.TabPage();
            this.pGinaLogs_tabControl = new System.Windows.Forms.TabControl();
            this.pGinaLogsConfig_tabPage = new System.Windows.Forms.TabPage();
            this.pGinaConfigLog_listBox = new System.Windows.Forms.ListBox();
            this.pGinaLogsService_tabPage = new System.Windows.Forms.TabPage();
            this.pGinaServiceLog_listBox = new System.Windows.Forms.ListBox();
            this.changeRole_contextMenuStrip.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.advancedSettings_tabPage.SuspendLayout();
            this.keysAdvancedSettings_groupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.otherAdvancedSettings_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxAuthTime_numericUpDown)).BeginInit();
            this.database_groupBox.SuspendLayout();
            this.panel3.SuspendLayout();
            this.backup_groupBox.SuspendLayout();
            this.backup_panel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.keys_tabPage.SuspendLayout();
            this.checkKey_groupBox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.keyInfo_groupBox.SuspendLayout();
            this.auth_tabPage.SuspendLayout();
            this.fastChoice_groupBox.SuspendLayout();
            this.authConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keysRequired_NumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.successPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locked_pictureBox)).BeginInit();
            this.testAM_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.openingPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.UsersGroupBox.SuspendLayout();
            this.user_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userIconPictureBox)).BeginInit();
            this.tabControl.SuspendLayout();
            this.summary_tabPage.SuspendLayout();
            this.logs_tabPage.SuspendLayout();
            this.logControl_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countLogs_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logs_dataView)).BeginInit();
            this.pGinaLogs_tabPage.SuspendLayout();
            this.pGinaLogs_tabControl.SuspendLayout();
            this.pGinaLogsConfig_tabPage.SuspendLayout();
            this.pGinaLogsService_tabPage.SuspendLayout();
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
            this.ok_toolStripButton,
            this.toolStripSeparator1,
            this.cancel_toolStripButton});
            this.controlPanel.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.controlPanel.Location = new System.Drawing.Point(0, 406);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.controlPanel.Size = new System.Drawing.Size(984, 28);
            this.controlPanel.TabIndex = 6;
            this.controlPanel.Text = "toolStrip1";
            // 
            // ok_toolStripButton
            // 
            this.ok_toolStripButton.AutoSize = false;
            this.ok_toolStripButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ok_toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ok_toolStripButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ok_toolStripButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ok_toolStripButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ok_toolStripButton.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.ok_toolStripButton.Margin = new System.Windows.Forms.Padding(0);
            this.ok_toolStripButton.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.ok_toolStripButton.Name = "ok_toolStripButton";
            this.ok_toolStripButton.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.ok_toolStripButton.Size = new System.Drawing.Size(683, 28);
            this.ok_toolStripButton.Text = "OK";
            this.ok_toolStripButton.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.AutoSize = false;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(16, 28);
            // 
            // cancel_toolStripButton
            // 
            this.cancel_toolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cancel_toolStripButton.AutoSize = false;
            this.cancel_toolStripButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cancel_toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cancel_toolStripButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancel_toolStripButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cancel_toolStripButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancel_toolStripButton.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.cancel_toolStripButton.Margin = new System.Windows.Forms.Padding(0);
            this.cancel_toolStripButton.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.cancel_toolStripButton.Name = "cancel_toolStripButton";
            this.cancel_toolStripButton.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.cancel_toolStripButton.Size = new System.Drawing.Size(283, 28);
            this.cancel_toolStripButton.Text = "CANCEL";
            this.cancel_toolStripButton.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // advancedSettings_tabPage
            // 
            this.advancedSettings_tabPage.Controls.Add(this.keysAdvancedSettings_groupBox);
            this.advancedSettings_tabPage.Controls.Add(this.groupBox1);
            this.advancedSettings_tabPage.Controls.Add(this.otherAdvancedSettings_groupBox);
            this.advancedSettings_tabPage.Controls.Add(this.database_groupBox);
            this.advancedSettings_tabPage.Controls.Add(this.backup_groupBox);
            this.advancedSettings_tabPage.Location = new System.Drawing.Point(4, 24);
            this.advancedSettings_tabPage.Margin = new System.Windows.Forms.Padding(4);
            this.advancedSettings_tabPage.Name = "advancedSettings_tabPage";
            this.advancedSettings_tabPage.Padding = new System.Windows.Forms.Padding(4);
            this.advancedSettings_tabPage.Size = new System.Drawing.Size(976, 382);
            this.advancedSettings_tabPage.TabIndex = 3;
            this.advancedSettings_tabPage.Text = "Advanced settings";
            this.advancedSettings_tabPage.UseVisualStyleBackColor = true;
            this.advancedSettings_tabPage.Click += new System.EventHandler(this.advancedSettings_tabPage_Click);
            this.advancedSettings_tabPage.Enter += new System.EventHandler(this.advancedSettings_tabPage_Enter);
            // 
            // keysAdvancedSettings_groupBox
            // 
            this.keysAdvancedSettings_groupBox.Controls.Add(this.onlyPairedBluetoothDevices_checkBox);
            this.keysAdvancedSettings_groupBox.Location = new System.Drawing.Point(296, 182);
            this.keysAdvancedSettings_groupBox.Name = "keysAdvancedSettings_groupBox";
            this.keysAdvancedSettings_groupBox.Size = new System.Drawing.Size(338, 72);
            this.keysAdvancedSettings_groupBox.TabIndex = 18;
            this.keysAdvancedSettings_groupBox.TabStop = false;
            this.keysAdvancedSettings_groupBox.Text = "Key settings";
            // 
            // onlyPairedBluetoothDevices_checkBox
            // 
            this.onlyPairedBluetoothDevices_checkBox.AutoSize = true;
            this.onlyPairedBluetoothDevices_checkBox.Location = new System.Drawing.Point(8, 19);
            this.onlyPairedBluetoothDevices_checkBox.Name = "onlyPairedBluetoothDevices_checkBox";
            this.onlyPairedBluetoothDevices_checkBox.Size = new System.Drawing.Size(330, 20);
            this.onlyPairedBluetoothDevices_checkBox.TabIndex = 0;
            this.onlyPairedBluetoothDevices_checkBox.Text = "Allow to use only paired Bluetooth devices (secure)";
            this.onlyPairedBluetoothDevices_checkBox.UseVisualStyleBackColor = true;
            this.onlyPairedBluetoothDevices_checkBox.CheckedChanged += new System.EventHandler(this.onlyPairedBluetoothDevices_checkBox_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RestoreWindowsUsers_button);
            this.groupBox1.Controls.Add(this.cleanDB_button);
            this.groupBox1.Controls.Add(this.cleanDBKeys_button);
            this.groupBox1.Location = new System.Drawing.Point(296, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 168);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Service features";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // RestoreWindowsUsers_button
            // 
            this.RestoreWindowsUsers_button.Location = new System.Drawing.Point(8, 130);
            this.RestoreWindowsUsers_button.Name = "RestoreWindowsUsers_button";
            this.RestoreWindowsUsers_button.Size = new System.Drawing.Size(324, 29);
            this.RestoreWindowsUsers_button.TabIndex = 4;
            this.RestoreWindowsUsers_button.Text = "Add all database users to Windows";
            this.RestoreWindowsUsers_button.UseVisualStyleBackColor = true;
            this.RestoreWindowsUsers_button.Click += new System.EventHandler(this.RestoreWindowsUsers_button_Click);
            // 
            // cleanDB_button
            // 
            this.cleanDB_button.Location = new System.Drawing.Point(7, 21);
            this.cleanDB_button.Margin = new System.Windows.Forms.Padding(4);
            this.cleanDB_button.Name = "cleanDB_button";
            this.cleanDB_button.Size = new System.Drawing.Size(324, 64);
            this.cleanDB_button.TabIndex = 2;
            this.cleanDB_button.Text = "Clean database\r\n(Removes all users that don\'t exist in the OS and all unused auth" +
                "entication methods)";
            this.cleanDB_button.UseVisualStyleBackColor = true;
            this.cleanDB_button.Click += new System.EventHandler(this.cleanDB_button_Click);
            // 
            // cleanDBKeys_button
            // 
            this.cleanDBKeys_button.Location = new System.Drawing.Point(7, 92);
            this.cleanDBKeys_button.Name = "cleanDBKeys_button";
            this.cleanDBKeys_button.Size = new System.Drawing.Size(324, 29);
            this.cleanDBKeys_button.TabIndex = 3;
            this.cleanDBKeys_button.Text = "Remove all unused keys";
            this.cleanDBKeys_button.UseVisualStyleBackColor = true;
            this.cleanDBKeys_button.Click += new System.EventHandler(this.removeUnusedKeys_button_Click);
            // 
            // otherAdvancedSettings_groupBox
            // 
            this.otherAdvancedSettings_groupBox.Controls.Add(this.maxAuthTime_numericUpDown);
            this.otherAdvancedSettings_groupBox.Controls.Add(this.maxAuthTime_label);
            this.otherAdvancedSettings_groupBox.Controls.Add(this.showpGinaLogs_checkBox);
            this.otherAdvancedSettings_groupBox.Controls.Add(this.openSummaryCollapsed_checkBox);
            this.otherAdvancedSettings_groupBox.Controls.Add(this.advancedSettings_alwaysCheckSelectedKey_checkBox);
            this.otherAdvancedSettings_groupBox.Controls.Add(this.requireAtLeastOneKeyInAuthMethod_checkBox);
            this.otherAdvancedSettings_groupBox.Location = new System.Drawing.Point(9, 260);
            this.otherAdvancedSettings_groupBox.Name = "otherAdvancedSettings_groupBox";
            this.otherAdvancedSettings_groupBox.Size = new System.Drawing.Size(959, 115);
            this.otherAdvancedSettings_groupBox.TabIndex = 16;
            this.otherAdvancedSettings_groupBox.TabStop = false;
            this.otherAdvancedSettings_groupBox.Text = "Other settings";
            this.otherAdvancedSettings_groupBox.Enter += new System.EventHandler(this.otherAdvancedSettings_groupBox_Enter);
            // 
            // maxAuthTime_numericUpDown
            // 
            this.maxAuthTime_numericUpDown.Location = new System.Drawing.Point(764, 26);
            this.maxAuthTime_numericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.maxAuthTime_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxAuthTime_numericUpDown.Name = "maxAuthTime_numericUpDown";
            this.maxAuthTime_numericUpDown.Size = new System.Drawing.Size(66, 21);
            this.maxAuthTime_numericUpDown.TabIndex = 0;
            this.maxAuthTime_numericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.maxAuthTime_numericUpDown.ValueChanged += new System.EventHandler(this.maxAuthTime_numericUpDown_ValueChanged);
            // 
            // maxAuthTime_label
            // 
            this.maxAuthTime_label.AutoSize = true;
            this.maxAuthTime_label.Location = new System.Drawing.Point(536, 28);
            this.maxAuthTime_label.Name = "maxAuthTime_label";
            this.maxAuthTime_label.Size = new System.Drawing.Size(222, 16);
            this.maxAuthTime_label.TabIndex = 20;
            this.maxAuthTime_label.Text = "Max authentication time (in seconds)";
            // 
            // showpGinaLogs_checkBox
            // 
            this.showpGinaLogs_checkBox.AutoSize = true;
            this.showpGinaLogs_checkBox.Location = new System.Drawing.Point(359, 26);
            this.showpGinaLogs_checkBox.Name = "showpGinaLogs_checkBox";
            this.showpGinaLogs_checkBox.Size = new System.Drawing.Size(128, 20);
            this.showpGinaLogs_checkBox.TabIndex = 19;
            this.showpGinaLogs_checkBox.Text = "Show pGina logs";
            this.showpGinaLogs_checkBox.UseVisualStyleBackColor = true;
            this.showpGinaLogs_checkBox.CheckedChanged += new System.EventHandler(this.showpGinaLogs_checkBox_CheckedChanged);
            // 
            // openSummaryCollapsed_checkBox
            // 
            this.openSummaryCollapsed_checkBox.AutoSize = true;
            this.openSummaryCollapsed_checkBox.Location = new System.Drawing.Point(9, 79);
            this.openSummaryCollapsed_checkBox.Name = "openSummaryCollapsed_checkBox";
            this.openSummaryCollapsed_checkBox.Size = new System.Drawing.Size(247, 20);
            this.openSummaryCollapsed_checkBox.TabIndex = 18;
            this.openSummaryCollapsed_checkBox.Text = "Always open summary tab collapsed";
            this.openSummaryCollapsed_checkBox.UseVisualStyleBackColor = true;
            this.openSummaryCollapsed_checkBox.CheckedChanged += new System.EventHandler(this.openSummaryCollapsed_checkBox_CheckedChanged);
            // 
            // advancedSettings_alwaysCheckSelectedKey_checkBox
            // 
            this.advancedSettings_alwaysCheckSelectedKey_checkBox.AutoSize = true;
            this.advancedSettings_alwaysCheckSelectedKey_checkBox.Location = new System.Drawing.Point(9, 26);
            this.advancedSettings_alwaysCheckSelectedKey_checkBox.Name = "advancedSettings_alwaysCheckSelectedKey_checkBox";
            this.advancedSettings_alwaysCheckSelectedKey_checkBox.Size = new System.Drawing.Size(328, 20);
            this.advancedSettings_alwaysCheckSelectedKey_checkBox.TabIndex = 14;
            this.advancedSettings_alwaysCheckSelectedKey_checkBox.Text = "Automatically check key in Keys tab when selected";
            this.advancedSettings_alwaysCheckSelectedKey_checkBox.UseVisualStyleBackColor = true;
            this.advancedSettings_alwaysCheckSelectedKey_checkBox.CheckedChanged += new System.EventHandler(this.advancedSettings_alwaysCheckSelectedKey_checkBox_CheckedChanged);
            // 
            // requireAtLeastOneKeyInAuthMethod_checkBox
            // 
            this.requireAtLeastOneKeyInAuthMethod_checkBox.AutoSize = true;
            this.requireAtLeastOneKeyInAuthMethod_checkBox.Location = new System.Drawing.Point(9, 53);
            this.requireAtLeastOneKeyInAuthMethod_checkBox.Name = "requireAtLeastOneKeyInAuthMethod_checkBox";
            this.requireAtLeastOneKeyInAuthMethod_checkBox.Size = new System.Drawing.Size(302, 20);
            this.requireAtLeastOneKeyInAuthMethod_checkBox.TabIndex = 15;
            this.requireAtLeastOneKeyInAuthMethod_checkBox.Text = "Require at least 1 key In authentication method";
            this.requireAtLeastOneKeyInAuthMethod_checkBox.UseVisualStyleBackColor = true;
            this.requireAtLeastOneKeyInAuthMethod_checkBox.CheckedChanged += new System.EventHandler(this.requireAtLeastOneKeyInAuthMethod_checkBox_CheckedChanged);
            // 
            // database_groupBox
            // 
            this.database_groupBox.Controls.Add(this.DBOpened_checkBox);
            this.database_groupBox.Controls.Add(this.panel3);
            this.database_groupBox.Controls.Add(this.database_label);
            this.database_groupBox.Controls.Add(this.runSetup_button);
            this.database_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.database_groupBox.Location = new System.Drawing.Point(9, 7);
            this.database_groupBox.Name = "database_groupBox";
            this.database_groupBox.Size = new System.Drawing.Size(281, 247);
            this.database_groupBox.TabIndex = 12;
            this.database_groupBox.TabStop = false;
            this.database_groupBox.Text = "Database";
            this.database_groupBox.Enter += new System.EventHandler(this.database_groupBox_Enter);
            // 
            // DBOpened_checkBox
            // 
            this.DBOpened_checkBox.AutoCheck = false;
            this.DBOpened_checkBox.AutoSize = true;
            this.DBOpened_checkBox.Enabled = false;
            this.DBOpened_checkBox.Location = new System.Drawing.Point(7, 95);
            this.DBOpened_checkBox.Name = "DBOpened_checkBox";
            this.DBOpened_checkBox.Size = new System.Drawing.Size(117, 17);
            this.DBOpened_checkBox.TabIndex = 20;
            this.DBOpened_checkBox.TabStop = false;
            this.DBOpened_checkBox.Text = "Database available";
            this.DBOpened_checkBox.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel3.Controls.Add(this.dbErase_checkBox);
            this.panel3.Controls.Add(this.dbErase_button);
            this.panel3.Location = new System.Drawing.Point(7, 165);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(267, 75);
            this.panel3.TabIndex = 19;
            // 
            // dbErase_checkBox
            // 
            this.dbErase_checkBox.AutoEllipsis = true;
            this.dbErase_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.dbErase_checkBox.Location = new System.Drawing.Point(9, 2);
            this.dbErase_checkBox.Name = "dbErase_checkBox";
            this.dbErase_checkBox.Size = new System.Drawing.Size(255, 39);
            this.dbErase_checkBox.TabIndex = 4;
            this.dbErase_checkBox.Text = "I understand that all users, keys and logs will de erased";
            this.dbErase_checkBox.UseVisualStyleBackColor = true;
            // 
            // dbErase_button
            // 
            this.dbErase_button.BackColor = System.Drawing.Color.Tomato;
            this.dbErase_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dbErase_button.ForeColor = System.Drawing.SystemColors.Control;
            this.dbErase_button.Location = new System.Drawing.Point(2, 41);
            this.dbErase_button.Name = "dbErase_button";
            this.dbErase_button.Size = new System.Drawing.Size(262, 32);
            this.dbErase_button.TabIndex = 5;
            this.dbErase_button.Text = "ERASE DATABASE";
            this.dbErase_button.UseVisualStyleBackColor = false;
            this.dbErase_button.Click += new System.EventHandler(this.dbErase_button_Click);
            // 
            // database_label
            // 
            this.database_label.AutoEllipsis = true;
            this.database_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.database_label.Location = new System.Drawing.Point(4, 16);
            this.database_label.Name = "database_label";
            this.database_label.Size = new System.Drawing.Size(270, 76);
            this.database_label.TabIndex = 0;
            this.database_label.Text = "Please use the setup dialog to change database path or password\r\nCurrent database" +
                " path:\r\n";
            // 
            // runSetup_button
            // 
            this.runSetup_button.Location = new System.Drawing.Point(7, 120);
            this.runSetup_button.Margin = new System.Windows.Forms.Padding(4);
            this.runSetup_button.Name = "runSetup_button";
            this.runSetup_button.Size = new System.Drawing.Size(267, 38);
            this.runSetup_button.TabIndex = 1;
            this.runSetup_button.Text = "Run setup dialog again";
            this.runSetup_button.UseVisualStyleBackColor = true;
            this.runSetup_button.Click += new System.EventHandler(this.runSetup_button_Click);
            // 
            // backup_groupBox
            // 
            this.backup_groupBox.Controls.Add(this.backup_panel);
            this.backup_groupBox.Controls.Add(this.panel4);
            this.backup_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.backup_groupBox.Location = new System.Drawing.Point(640, 7);
            this.backup_groupBox.Name = "backup_groupBox";
            this.backup_groupBox.Size = new System.Drawing.Size(328, 222);
            this.backup_groupBox.TabIndex = 13;
            this.backup_groupBox.TabStop = false;
            this.backup_groupBox.Text = "Database backup";
            // 
            // backup_panel
            // 
            this.backup_panel.BackColor = System.Drawing.Color.Cornsilk;
            this.backup_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.backup_panel.Controls.Add(this.backupPassword_label);
            this.backup_panel.Controls.Add(this.backupPath_button);
            this.backup_panel.Controls.Add(this.backupPassword_textBox);
            this.backup_panel.Controls.Add(this.backupPath_textBox);
            this.backup_panel.Controls.Add(this.backupBackup_button);
            this.backup_panel.Location = new System.Drawing.Point(7, 130);
            this.backup_panel.Name = "backup_panel";
            this.backup_panel.Size = new System.Drawing.Size(315, 85);
            this.backup_panel.TabIndex = 3;
            // 
            // backupPassword_label
            // 
            this.backupPassword_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.backupPassword_label.Location = new System.Drawing.Point(149, 4);
            this.backupPassword_label.Name = "backupPassword_label";
            this.backupPassword_label.Size = new System.Drawing.Size(92, 50);
            this.backupPassword_label.TabIndex = 4;
            this.backupPassword_label.Text = "Password for backup database";
            this.backupPassword_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // backupPath_button
            // 
            this.backupPath_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.backupPath_button.Location = new System.Drawing.Point(4, 4);
            this.backupPath_button.Name = "backupPath_button";
            this.backupPath_button.Size = new System.Drawing.Size(134, 50);
            this.backupPath_button.TabIndex = 3;
            this.backupPath_button.Text = "Choose path to backup location";
            this.backupPath_button.UseVisualStyleBackColor = true;
            this.backupPath_button.Click += new System.EventHandler(this.backupPath_button_Click);
            // 
            // backupPassword_textBox
            // 
            this.backupPassword_textBox.Location = new System.Drawing.Point(152, 60);
            this.backupPassword_textBox.Name = "backupPassword_textBox";
            this.backupPassword_textBox.Size = new System.Drawing.Size(89, 20);
            this.backupPassword_textBox.TabIndex = 2;
            this.backupPassword_textBox.UseSystemPasswordChar = true;
            // 
            // backupPath_textBox
            // 
            this.backupPath_textBox.Location = new System.Drawing.Point(4, 60);
            this.backupPath_textBox.Name = "backupPath_textBox";
            this.backupPath_textBox.Size = new System.Drawing.Size(134, 20);
            this.backupPath_textBox.TabIndex = 1;
            // 
            // backupBackup_button
            // 
            this.backupBackup_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.backupBackup_button.Location = new System.Drawing.Point(247, 1);
            this.backupBackup_button.Name = "backupBackup_button";
            this.backupBackup_button.Size = new System.Drawing.Size(63, 80);
            this.backupBackup_button.TabIndex = 0;
            this.backupBackup_button.Text = "Back up now";
            this.backupBackup_button.UseVisualStyleBackColor = true;
            this.backupBackup_button.Click += new System.EventHandler(this.backupBackup_button_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.dbBackupWarning_label);
            this.panel4.Controls.Add(this.onLoadBackupEnabled_checkBox);
            this.panel4.Controls.Add(this.discardChanges_linkLabel);
            this.panel4.Location = new System.Drawing.Point(7, 19);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(315, 104);
            this.panel4.TabIndex = 2;
            // 
            // dbBackupWarning_label
            // 
            this.dbBackupWarning_label.Location = new System.Drawing.Point(8, 71);
            this.dbBackupWarning_label.Name = "dbBackupWarning_label";
            this.dbBackupWarning_label.Size = new System.Drawing.Size(304, 27);
            this.dbBackupWarning_label.TabIndex = 2;
            this.dbBackupWarning_label.Text = "Does NOT remove Windows users. Use the \"Clean database\" button in the \"Database\" " +
                "section to remove obsolete data";
            // 
            // onLoadBackupEnabled_checkBox
            // 
            this.onLoadBackupEnabled_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.onLoadBackupEnabled_checkBox.Location = new System.Drawing.Point(11, 10);
            this.onLoadBackupEnabled_checkBox.Name = "onLoadBackupEnabled_checkBox";
            this.onLoadBackupEnabled_checkBox.Size = new System.Drawing.Size(268, 36);
            this.onLoadBackupEnabled_checkBox.TabIndex = 1;
            this.onLoadBackupEnabled_checkBox.Text = "Backup current state on load (may be slow if the database is huge)";
            this.onLoadBackupEnabled_checkBox.UseVisualStyleBackColor = true;
            this.onLoadBackupEnabled_checkBox.CheckedChanged += new System.EventHandler(this.onLoadBackupEnabled_checkBox_CheckedChanged);
            // 
            // discardChanges_linkLabel
            // 
            this.discardChanges_linkLabel.AutoSize = true;
            this.discardChanges_linkLabel.Enabled = false;
            this.discardChanges_linkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.discardChanges_linkLabel.Location = new System.Drawing.Point(8, 49);
            this.discardChanges_linkLabel.Name = "discardChanges_linkLabel";
            this.discardChanges_linkLabel.Size = new System.Drawing.Size(280, 17);
            this.discardChanges_linkLabel.TabIndex = 0;
            this.discardChanges_linkLabel.TabStop = true;
            this.discardChanges_linkLabel.Text = "Discard recent changes (this configuration)";
            this.discardChanges_linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.discardChanges_linkLabel_LinkClicked);
            // 
            // keys_tabPage
            // 
            this.keys_tabPage.Controls.Add(this.checkKey_groupBox);
            this.keys_tabPage.Controls.Add(this.removeUnusedKeys_button);
            this.keys_tabPage.Controls.Add(this.panel2);
            this.keys_tabPage.Controls.Add(this.keyInfo_groupBox);
            this.keys_tabPage.Controls.Add(this.keysListBox);
            this.keys_tabPage.Location = new System.Drawing.Point(4, 24);
            this.keys_tabPage.Margin = new System.Windows.Forms.Padding(4);
            this.keys_tabPage.Name = "keys_tabPage";
            this.keys_tabPage.Padding = new System.Windows.Forms.Padding(4);
            this.keys_tabPage.Size = new System.Drawing.Size(976, 382);
            this.keys_tabPage.TabIndex = 2;
            this.keys_tabPage.Text = "Keys";
            this.keys_tabPage.UseVisualStyleBackColor = true;
            this.keys_tabPage.Enter += new System.EventHandler(this.keys_tabPage_Enter);
            // 
            // checkKey_groupBox
            // 
            this.checkKey_groupBox.BackColor = System.Drawing.Color.LightGray;
            this.checkKey_groupBox.Controls.Add(this.checkKeyResult_button);
            this.checkKey_groupBox.Controls.Add(this.checkKey_button);
            this.checkKey_groupBox.Controls.Add(this.checkPassword_label);
            this.checkKey_groupBox.Controls.Add(this.checkPassword_textBox);
            this.checkKey_groupBox.Enabled = false;
            this.checkKey_groupBox.Location = new System.Drawing.Point(401, 288);
            this.checkKey_groupBox.Name = "checkKey_groupBox";
            this.checkKey_groupBox.Size = new System.Drawing.Size(250, 87);
            this.checkKey_groupBox.TabIndex = 20;
            this.checkKey_groupBox.TabStop = false;
            this.checkKey_groupBox.Text = "Check key";
            // 
            // checkKeyResult_button
            // 
            this.checkKeyResult_button.BackColor = System.Drawing.Color.MintCream;
            this.checkKeyResult_button.Location = new System.Drawing.Point(123, 45);
            this.checkKeyResult_button.Name = "checkKeyResult_button";
            this.checkKeyResult_button.Size = new System.Drawing.Size(121, 36);
            this.checkKeyResult_button.TabIndex = 3;
            this.checkKeyResult_button.UseVisualStyleBackColor = false;
            // 
            // checkKey_button
            // 
            this.checkKey_button.Location = new System.Drawing.Point(9, 45);
            this.checkKey_button.Name = "checkKey_button";
            this.checkKey_button.Size = new System.Drawing.Size(108, 36);
            this.checkKey_button.TabIndex = 2;
            this.checkKey_button.Text = "Check key";
            this.checkKey_button.UseVisualStyleBackColor = true;
            this.checkKey_button.Click += new System.EventHandler(this.checkKey_button_Click);
            // 
            // checkPassword_label
            // 
            this.checkPassword_label.AutoSize = true;
            this.checkPassword_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.checkPassword_label.Location = new System.Drawing.Point(6, 22);
            this.checkPassword_label.Name = "checkPassword_label";
            this.checkPassword_label.Size = new System.Drawing.Size(73, 17);
            this.checkPassword_label.TabIndex = 1;
            this.checkPassword_label.Text = "Password:";
            // 
            // checkPassword_textBox
            // 
            this.checkPassword_textBox.Location = new System.Drawing.Point(85, 20);
            this.checkPassword_textBox.Name = "checkPassword_textBox";
            this.checkPassword_textBox.Size = new System.Drawing.Size(159, 21);
            this.checkPassword_textBox.TabIndex = 0;
            // 
            // removeUnusedKeys_button
            // 
            this.removeUnusedKeys_button.BackColor = System.Drawing.Color.Khaki;
            this.removeUnusedKeys_button.Location = new System.Drawing.Point(657, 339);
            this.removeUnusedKeys_button.Name = "removeUnusedKeys_button";
            this.removeUnusedKeys_button.Size = new System.Drawing.Size(311, 36);
            this.removeUnusedKeys_button.TabIndex = 19;
            this.removeUnusedKeys_button.Text = "Remove all unused keys";
            this.removeUnusedKeys_button.UseVisualStyleBackColor = false;
            this.removeUnusedKeys_button.Click += new System.EventHandler(this.removeUnusedKeys_button_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.keyRemoval_checkBox);
            this.panel2.Controls.Add(this.deleteKey_button);
            this.panel2.Location = new System.Drawing.Point(8, 288);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 87);
            this.panel2.TabIndex = 18;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // keyRemoval_checkBox
            // 
            this.keyRemoval_checkBox.AutoEllipsis = true;
            this.keyRemoval_checkBox.Location = new System.Drawing.Point(9, 6);
            this.keyRemoval_checkBox.Name = "keyRemoval_checkBox";
            this.keyRemoval_checkBox.Size = new System.Drawing.Size(374, 39);
            this.keyRemoval_checkBox.TabIndex = 5;
            this.keyRemoval_checkBox.Text = "I understand that the key(s) will be removed from the authentication methods and " +
                "the methods may stop to work";
            this.keyRemoval_checkBox.UseVisualStyleBackColor = true;
            // 
            // deleteKey_button
            // 
            this.deleteKey_button.BackColor = System.Drawing.Color.DarkSalmon;
            this.deleteKey_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.deleteKey_button.ForeColor = System.Drawing.SystemColors.Control;
            this.deleteKey_button.Location = new System.Drawing.Point(2, 45);
            this.deleteKey_button.Name = "deleteKey_button";
            this.deleteKey_button.Size = new System.Drawing.Size(381, 40);
            this.deleteKey_button.TabIndex = 6;
            this.deleteKey_button.Text = "DELETE KEY(S)";
            this.deleteKey_button.UseVisualStyleBackColor = false;
            this.deleteKey_button.Click += new System.EventHandler(this.deleteKey_button_Click);
            // 
            // keyInfo_groupBox
            // 
            this.keyInfo_groupBox.BackColor = System.Drawing.Color.SkyBlue;
            this.keyInfo_groupBox.Controls.Add(this.keySerial_textBox);
            this.keyInfo_groupBox.Controls.Add(this.keyConfigure_button);
            this.keyInfo_groupBox.Controls.Add(this.keyData_checkBox);
            this.keyInfo_groupBox.Controls.Add(this.keyPassword_checkBox);
            this.keyInfo_groupBox.Controls.Add(this.keySerial_checkBox);
            this.keyInfo_groupBox.Controls.Add(this.keyType_label);
            this.keyInfo_groupBox.Controls.Add(this.keyInverted_checkBox);
            this.keyInfo_groupBox.Controls.Add(this.keyDescription_textBox);
            this.keyInfo_groupBox.Controls.Add(this.keyDescription_label);
            this.keyInfo_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.keyInfo_groupBox.Location = new System.Drawing.Point(657, 7);
            this.keyInfo_groupBox.Name = "keyInfo_groupBox";
            this.keyInfo_groupBox.Size = new System.Drawing.Size(311, 326);
            this.keyInfo_groupBox.TabIndex = 17;
            this.keyInfo_groupBox.TabStop = false;
            this.keyInfo_groupBox.Text = "Key information";
            // 
            // keySerial_textBox
            // 
            this.keySerial_textBox.Enabled = false;
            this.keySerial_textBox.Location = new System.Drawing.Point(10, 198);
            this.keySerial_textBox.Name = "keySerial_textBox";
            this.keySerial_textBox.Size = new System.Drawing.Size(295, 23);
            this.keySerial_textBox.TabIndex = 8;
            this.keySerial_textBox.TextChanged += new System.EventHandler(this.keySerial_textBox_TextChanged);
            // 
            // keyConfigure_button
            // 
            this.keyConfigure_button.Enabled = false;
            this.keyConfigure_button.Location = new System.Drawing.Point(6, 263);
            this.keyConfigure_button.Name = "keyConfigure_button";
            this.keyConfigure_button.Size = new System.Drawing.Size(299, 53);
            this.keyConfigure_button.TabIndex = 4;
            this.keyConfigure_button.Text = "Advanced key configuration";
            this.keyConfigure_button.UseVisualStyleBackColor = true;
            this.keyConfigure_button.Click += new System.EventHandler(this.keyConfigure_button_Click);
            // 
            // keyData_checkBox
            // 
            this.keyData_checkBox.AutoSize = true;
            this.keyData_checkBox.BackColor = System.Drawing.Color.White;
            this.keyData_checkBox.Enabled = false;
            this.keyData_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.keyData_checkBox.Location = new System.Drawing.Point(157, 233);
            this.keyData_checkBox.Name = "keyData_checkBox";
            this.keyData_checkBox.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.keyData_checkBox.Size = new System.Drawing.Size(144, 24);
            this.keyData_checkBox.TabIndex = 6;
            this.keyData_checkBox.Text = "Has other data";
            this.keyData_checkBox.UseVisualStyleBackColor = false;
            // 
            // keyPassword_checkBox
            // 
            this.keyPassword_checkBox.AutoSize = true;
            this.keyPassword_checkBox.BackColor = System.Drawing.Color.White;
            this.keyPassword_checkBox.Enabled = false;
            this.keyPassword_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.keyPassword_checkBox.Location = new System.Drawing.Point(10, 233);
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
            this.keySerial_checkBox.Location = new System.Drawing.Point(10, 167);
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
            this.keyInverted_checkBox.Location = new System.Drawing.Point(10, 137);
            this.keyInverted_checkBox.Name = "keyInverted_checkBox";
            this.keyInverted_checkBox.Size = new System.Drawing.Size(87, 24);
            this.keyInverted_checkBox.TabIndex = 3;
            this.keyInverted_checkBox.Text = "Inverted";
            this.keyInverted_checkBox.UseVisualStyleBackColor = true;
            this.keyInverted_checkBox.CheckedChanged += new System.EventHandler(this.keyInverted_checkBox_CheckedChanged);
            // 
            // keyDescription_textBox
            // 
            this.keyDescription_textBox.Enabled = false;
            this.keyDescription_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.keyDescription_textBox.Location = new System.Drawing.Point(10, 73);
            this.keyDescription_textBox.Multiline = true;
            this.keyDescription_textBox.Name = "keyDescription_textBox";
            this.keyDescription_textBox.Size = new System.Drawing.Size(295, 58);
            this.keyDescription_textBox.TabIndex = 2;
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
            // keysListBox
            // 
            this.keysListBox.FormattingEnabled = true;
            this.keysListBox.ItemHeight = 15;
            this.keysListBox.Location = new System.Drawing.Point(8, 7);
            this.keysListBox.Name = "keysListBox";
            this.keysListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.keysListBox.Size = new System.Drawing.Size(643, 274);
            this.keysListBox.TabIndex = 1;
            this.keysListBox.SelectedIndexChanged += new System.EventHandler(this.keysListBox_SelectedIndexChanged);
            // 
            // auth_tabPage
            // 
            this.auth_tabPage.Controls.Add(this.fastChoice_groupBox);
            this.auth_tabPage.Controls.Add(this.authConfig);
            this.auth_tabPage.Controls.Add(this.UsersGroupBox);
            this.auth_tabPage.Controls.Add(this.user_groupBox);
            this.auth_tabPage.Location = new System.Drawing.Point(4, 24);
            this.auth_tabPage.Margin = new System.Windows.Forms.Padding(4);
            this.auth_tabPage.Name = "auth_tabPage";
            this.auth_tabPage.Padding = new System.Windows.Forms.Padding(4);
            this.auth_tabPage.Size = new System.Drawing.Size(976, 382);
            this.auth_tabPage.TabIndex = 0;
            this.auth_tabPage.Text = "Authentication";
            this.auth_tabPage.UseVisualStyleBackColor = true;
            this.auth_tabPage.Enter += new System.EventHandler(this.auth_tabPage_Enter);
            // 
            // fastChoice_groupBox
            // 
            this.fastChoice_groupBox.BackColor = System.Drawing.Color.Thistle;
            this.fastChoice_groupBox.Controls.Add(this.fastChoiceTypes_listView);
            this.fastChoice_groupBox.Location = new System.Drawing.Point(474, 8);
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
            listViewItem9.Tag = "EncryptedPasswordFileKey";
            listViewItem10.Tag = "ETokenKey";
            listViewItem11.Tag = "Password";
            listViewItem12.Tag = "HttpRequest";
            this.fastChoiceTypes_listView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12});
            this.fastChoiceTypes_listView.Location = new System.Drawing.Point(6, 20);
            this.fastChoiceTypes_listView.MultiSelect = false;
            this.fastChoiceTypes_listView.Name = "fastChoiceTypes_listView";
            this.fastChoiceTypes_listView.ShowGroups = false;
            this.fastChoiceTypes_listView.Size = new System.Drawing.Size(482, 112);
            this.fastChoiceTypes_listView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.fastChoiceTypes_listView.TabIndex = 4;
            this.fastChoiceTypes_listView.UseCompatibleStateImageBehavior = false;
            this.fastChoiceTypes_listView.View = System.Windows.Forms.View.Tile;
            this.fastChoiceTypes_listView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.fastChoiceTypes_listView_MouseDoubleClick);
            this.fastChoiceTypes_listView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragSource_MouseDown);
            this.fastChoiceTypes_listView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragSource_MouseMove);
            this.fastChoiceTypes_listView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragSource_MouseUp);
            // 
            // authConfig
            // 
            this.authConfig.BackColor = System.Drawing.Color.SkyBlue;
            this.authConfig.Controls.Add(this.keysRequired_NumUpDown);
            this.authConfig.Controls.Add(this.successPictureBox);
            this.authConfig.Controls.Add(this.locked_pictureBox);
            this.authConfig.Controls.Add(this.testAM_groupBox);
            this.authConfig.Controls.Add(this.description_textBox);
            this.authConfig.Controls.Add(this.description_label);
            this.authConfig.Controls.Add(this.panel1);
            this.authConfig.Controls.Add(this.keysRequired_label);
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
            this.authConfig.Location = new System.Drawing.Point(253, 154);
            this.authConfig.Name = "authConfig";
            this.authConfig.Size = new System.Drawing.Size(715, 221);
            this.authConfig.TabIndex = 12;
            this.authConfig.TabStop = false;
            this.authConfig.Text = "User authentication";
            // 
            // keysRequired_NumUpDown
            // 
            this.keysRequired_NumUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.keysRequired_NumUpDown.Location = new System.Drawing.Point(665, 182);
            this.keysRequired_NumUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.keysRequired_NumUpDown.Name = "keysRequired_NumUpDown";
            this.keysRequired_NumUpDown.Size = new System.Drawing.Size(44, 29);
            this.keysRequired_NumUpDown.TabIndex = 12;
            this.keysRequired_NumUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.keysRequired_NumUpDown.ValueChanged += new System.EventHandler(this.keysRequired_NumUpDown_ValueChanged);
            // 
            // successPictureBox
            // 
            this.successPictureBox.BackgroundImage = global::pGina.Plugin.MFLoginPlugin.Properties.Resources.success;
            this.successPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.successPictureBox.Location = new System.Drawing.Point(632, 18);
            this.successPictureBox.Name = "successPictureBox";
            this.successPictureBox.Size = new System.Drawing.Size(74, 89);
            this.successPictureBox.TabIndex = 18;
            this.successPictureBox.TabStop = false;
            this.successPictureBox.Visible = false;
            // 
            // locked_pictureBox
            // 
            this.locked_pictureBox.BackgroundImage = global::pGina.Plugin.MFLoginPlugin.Properties.Resources.lock_7_256;
            this.locked_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.locked_pictureBox.Location = new System.Drawing.Point(627, 18);
            this.locked_pictureBox.Name = "locked_pictureBox";
            this.locked_pictureBox.Size = new System.Drawing.Size(82, 89);
            this.locked_pictureBox.TabIndex = 38;
            this.locked_pictureBox.TabStop = false;
            // 
            // testAM_groupBox
            // 
            this.testAM_groupBox.BackColor = System.Drawing.Color.Transparent;
            this.testAM_groupBox.Controls.Add(this.testAMpassword_textBox);
            this.testAM_groupBox.Controls.Add(this.openingPictureBox);
            this.testAM_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.testAM_groupBox.Location = new System.Drawing.Point(6, 20);
            this.testAM_groupBox.Name = "testAM_groupBox";
            this.testAM_groupBox.Size = new System.Drawing.Size(82, 195);
            this.testAM_groupBox.TabIndex = 37;
            this.testAM_groupBox.TabStop = false;
            this.testAM_groupBox.Text = "Test current method: type password and click the icon";
            // 
            // testAMpassword_textBox
            // 
            this.testAMpassword_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.testAMpassword_textBox.Location = new System.Drawing.Point(6, 72);
            this.testAMpassword_textBox.Name = "testAMpassword_textBox";
            this.testAMpassword_textBox.PasswordChar = '*';
            this.testAMpassword_textBox.Size = new System.Drawing.Size(70, 23);
            this.testAMpassword_textBox.TabIndex = 36;
            // 
            // openingPictureBox
            // 
            this.openingPictureBox.BackgroundImage = global::pGina.Plugin.MFLoginPlugin.Properties.Resources.opening;
            this.openingPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openingPictureBox.Location = new System.Drawing.Point(6, 101);
            this.openingPictureBox.Name = "openingPictureBox";
            this.openingPictureBox.Size = new System.Drawing.Size(70, 88);
            this.openingPictureBox.TabIndex = 19;
            this.openingPictureBox.TabStop = false;
            this.openingPictureBox.Click += new System.EventHandler(this.openingPictureBox_Click);
            this.openingPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.openingPictureBox_MouseClick);
            this.openingPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.openingPictureBox_Click);
            // 
            // description_textBox
            // 
            this.description_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.description_textBox.Location = new System.Drawing.Point(465, 145);
            this.description_textBox.Name = "description_textBox";
            this.description_textBox.Size = new System.Drawing.Size(244, 26);
            this.description_textBox.TabIndex = 11;
            this.description_textBox.TextChanged += new System.EventHandler(this.description_textBox_TextChanged);
            // 
            // description_label
            // 
            this.description_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.description_label.Location = new System.Drawing.Point(465, 117);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(244, 25);
            this.description_label.TabIndex = 35;
            this.description_label.Text = "Authentication method name:";
            this.description_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.removeAuthMethod_button);
            this.panel1.Controls.Add(this.newAuthMethod_button);
            this.panel1.Controls.Add(this.authMethods_listBox);
            this.panel1.Location = new System.Drawing.Point(94, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 98);
            this.panel1.TabIndex = 34;
            // 
            // removeAuthMethod_button
            // 
            this.removeAuthMethod_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.removeAuthMethod_button.Location = new System.Drawing.Point(222, 51);
            this.removeAuthMethod_button.Name = "removeAuthMethod_button";
            this.removeAuthMethod_button.Size = new System.Drawing.Size(137, 39);
            this.removeAuthMethod_button.TabIndex = 15;
            this.removeAuthMethod_button.Text = "REMOVE authentication method";
            this.removeAuthMethod_button.UseVisualStyleBackColor = true;
            this.removeAuthMethod_button.Click += new System.EventHandler(this.removeAuthMethod_button_Click);
            // 
            // newAuthMethod_button
            // 
            this.newAuthMethod_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.newAuthMethod_button.Location = new System.Drawing.Point(222, 6);
            this.newAuthMethod_button.Name = "newAuthMethod_button";
            this.newAuthMethod_button.Size = new System.Drawing.Size(137, 39);
            this.newAuthMethod_button.TabIndex = 14;
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
            this.authMethods_listBox.Size = new System.Drawing.Size(212, 84);
            this.authMethods_listBox.TabIndex = 13;
            this.authMethods_listBox.SelectedIndexChanged += new System.EventHandler(this.authMethods_listBox_SelectedIndexChanged);
            // 
            // keysRequired_label
            // 
            this.keysRequired_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.keysRequired_label.Location = new System.Drawing.Point(465, 183);
            this.keysRequired_label.Name = "keysRequired_label";
            this.keysRequired_label.Size = new System.Drawing.Size(205, 28);
            this.keysRequired_label.TabIndex = 33;
            this.keysRequired_label.Text = "How many keys are required?";
            this.keysRequired_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // key5Label
            // 
            this.key5Label.Location = new System.Drawing.Point(526, 18);
            this.key5Label.Name = "key5Label";
            this.key5Label.Size = new System.Drawing.Size(95, 20);
            this.key5Label.TabIndex = 16;
            this.key5Label.Text = "Key 5";
            this.key5Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // key4Label
            // 
            this.key4Label.Location = new System.Drawing.Point(417, 18);
            this.key4Label.Name = "key4Label";
            this.key4Label.Size = new System.Drawing.Size(95, 20);
            this.key4Label.TabIndex = 15;
            this.key4Label.Text = "Key 4";
            this.key4Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // key3Label
            // 
            this.key3Label.Location = new System.Drawing.Point(307, 18);
            this.key3Label.Name = "key3Label";
            this.key3Label.Size = new System.Drawing.Size(95, 20);
            this.key3Label.TabIndex = 14;
            this.key3Label.Text = "Key 3";
            this.key3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // key2Label
            // 
            this.key2Label.Location = new System.Drawing.Point(198, 18);
            this.key2Label.Name = "key2Label";
            this.key2Label.Size = new System.Drawing.Size(95, 20);
            this.key2Label.TabIndex = 13;
            this.key2Label.Text = "Key 2";
            this.key2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // key1Label
            // 
            this.key1Label.Location = new System.Drawing.Point(94, 19);
            this.key1Label.Name = "key1Label";
            this.key1Label.Size = new System.Drawing.Size(95, 20);
            this.key1Label.TabIndex = 12;
            this.key1Label.Text = "Key 1";
            this.key1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // key3Button
            // 
            this.key3Button.AllowDrop = true;
            this.key3Button.Location = new System.Drawing.Point(307, 41);
            this.key3Button.Name = "key3Button";
            this.key3Button.Size = new System.Drawing.Size(100, 66);
            this.key3Button.TabIndex = 8;
            this.key3Button.UseVisualStyleBackColor = true;
            this.key3Button.Click += new System.EventHandler(this.ClearKey);
            this.key3Button.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragTarget_DragDrop);
            this.key3Button.DragOver += new System.Windows.Forms.DragEventHandler(this.DragTarget_DragOver);
            // 
            // key5Button
            // 
            this.key5Button.AllowDrop = true;
            this.key5Button.Location = new System.Drawing.Point(526, 41);
            this.key5Button.Name = "key5Button";
            this.key5Button.Size = new System.Drawing.Size(100, 66);
            this.key5Button.TabIndex = 10;
            this.key5Button.UseVisualStyleBackColor = true;
            this.key5Button.Click += new System.EventHandler(this.ClearKey);
            this.key5Button.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragTarget_DragDrop);
            this.key5Button.DragOver += new System.Windows.Forms.DragEventHandler(this.DragTarget_DragOver);
            // 
            // key4Button
            // 
            this.key4Button.AllowDrop = true;
            this.key4Button.Location = new System.Drawing.Point(417, 41);
            this.key4Button.Name = "key4Button";
            this.key4Button.Size = new System.Drawing.Size(100, 66);
            this.key4Button.TabIndex = 9;
            this.key4Button.UseVisualStyleBackColor = true;
            this.key4Button.Click += new System.EventHandler(this.ClearKey);
            this.key4Button.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragTarget_DragDrop);
            this.key4Button.DragOver += new System.Windows.Forms.DragEventHandler(this.DragTarget_DragOver);
            // 
            // key1Button
            // 
            this.key1Button.AllowDrop = true;
            this.key1Button.Location = new System.Drawing.Point(94, 42);
            this.key1Button.Name = "key1Button";
            this.key1Button.Size = new System.Drawing.Size(95, 66);
            this.key1Button.TabIndex = 6;
            this.key1Button.UseVisualStyleBackColor = true;
            this.key1Button.Click += new System.EventHandler(this.ClearKey);
            this.key1Button.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragTarget_DragDrop);
            this.key1Button.DragOver += new System.Windows.Forms.DragEventHandler(this.DragTarget_DragOver);
            // 
            // key2Button
            // 
            this.key2Button.AllowDrop = true;
            this.key2Button.Location = new System.Drawing.Point(198, 41);
            this.key2Button.Name = "key2Button";
            this.key2Button.Size = new System.Drawing.Size(100, 66);
            this.key2Button.TabIndex = 7;
            this.key2Button.UseVisualStyleBackColor = true;
            this.key2Button.Click += new System.EventHandler(this.ClearKey);
            this.key2Button.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragTarget_DragDrop);
            this.key2Button.DragOver += new System.Windows.Forms.DragEventHandler(this.DragTarget_DragOver);
            // 
            // UsersGroupBox
            // 
            this.UsersGroupBox.BackColor = System.Drawing.Color.Gainsboro;
            this.UsersGroupBox.Controls.Add(this.removeUser_button);
            this.UsersGroupBox.Controls.Add(this.removeWithProfile_checkBox);
            this.UsersGroupBox.Controls.Add(this.removeWindowsUser_checkBox);
            this.UsersGroupBox.Controls.Add(this.addUser_button);
            this.UsersGroupBox.Controls.Add(this.user_ListBox);
            this.UsersGroupBox.Location = new System.Drawing.Point(9, 8);
            this.UsersGroupBox.Name = "UsersGroupBox";
            this.UsersGroupBox.Size = new System.Drawing.Size(238, 367);
            this.UsersGroupBox.TabIndex = 6;
            this.UsersGroupBox.TabStop = false;
            this.UsersGroupBox.Text = "Users";
            // 
            // removeUser_button
            // 
            this.removeUser_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.removeUser_button.Location = new System.Drawing.Point(122, 335);
            this.removeUser_button.Name = "removeUser_button";
            this.removeUser_button.Size = new System.Drawing.Size(110, 26);
            this.removeUser_button.TabIndex = 4;
            this.removeUser_button.Text = "Remove";
            this.removeUser_button.UseVisualStyleBackColor = false;
            this.removeUser_button.Click += new System.EventHandler(this.removeUser_button_Click);
            // 
            // removeWithProfile_checkBox
            // 
            this.removeWithProfile_checkBox.AutoSize = true;
            this.removeWithProfile_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.removeWithProfile_checkBox.Checked = true;
            this.removeWithProfile_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.removeWithProfile_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.removeWithProfile_checkBox.Location = new System.Drawing.Point(115, 321);
            this.removeWithProfile_checkBox.Name = "removeWithProfile_checkBox";
            this.removeWithProfile_checkBox.Size = new System.Drawing.Size(120, 17);
            this.removeWithProfile_checkBox.TabIndex = 5;
            this.removeWithProfile_checkBox.Text = "Remove user profile";
            this.removeWithProfile_checkBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.removeWithProfile_checkBox.UseVisualStyleBackColor = true;
            this.removeWithProfile_checkBox.CheckedChanged += new System.EventHandler(this.removeWithProfile_checkBox_CheckedChanged);
            // 
            // removeWindowsUser_checkBox
            // 
            this.removeWindowsUser_checkBox.AutoSize = true;
            this.removeWindowsUser_checkBox.Checked = true;
            this.removeWindowsUser_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.removeWindowsUser_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.removeWindowsUser_checkBox.Location = new System.Drawing.Point(122, 307);
            this.removeWindowsUser_checkBox.Name = "removeWindowsUser_checkBox";
            this.removeWindowsUser_checkBox.Size = new System.Drawing.Size(107, 17);
            this.removeWindowsUser_checkBox.TabIndex = 3;
            this.removeWindowsUser_checkBox.Text = "Remove from OS";
            this.removeWindowsUser_checkBox.UseVisualStyleBackColor = true;
            // 
            // addUser_button
            // 
            this.addUser_button.Location = new System.Drawing.Point(6, 307);
            this.addUser_button.Name = "addUser_button";
            this.addUser_button.Size = new System.Drawing.Size(110, 54);
            this.addUser_button.TabIndex = 2;
            this.addUser_button.Text = "Add";
            this.addUser_button.UseVisualStyleBackColor = true;
            this.addUser_button.Click += new System.EventHandler(this.addUser_button_Click);
            // 
            // user_ListBox
            // 
            this.user_ListBox.FormattingEnabled = true;
            this.user_ListBox.ItemHeight = 15;
            this.user_ListBox.Location = new System.Drawing.Point(6, 27);
            this.user_ListBox.Name = "user_ListBox";
            this.user_ListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.user_ListBox.Size = new System.Drawing.Size(226, 274);
            this.user_ListBox.TabIndex = 1;
            this.user_ListBox.SelectedIndexChanged += new System.EventHandler(this.userListBox_SelectedIndexChanged);
            this.user_ListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.userListBox_MouseDown);
            // 
            // user_groupBox
            // 
            this.user_groupBox.BackColor = System.Drawing.Color.Wheat;
            this.user_groupBox.Controls.Add(this.role_textBox);
            this.user_groupBox.Controls.Add(this.userIconPictureBox);
            this.user_groupBox.Controls.Add(this.keepPassword_checkBox);
            this.user_groupBox.Controls.Add(this.userName_textBox);
            this.user_groupBox.Location = new System.Drawing.Point(253, 8);
            this.user_groupBox.Name = "user_groupBox";
            this.user_groupBox.Size = new System.Drawing.Size(214, 138);
            this.user_groupBox.TabIndex = 18;
            this.user_groupBox.TabStop = false;
            // 
            // role_textBox
            // 
            this.role_textBox.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.role_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.role_textBox.Location = new System.Drawing.Point(97, 100);
            this.role_textBox.Name = "role_textBox";
            this.role_textBox.Size = new System.Drawing.Size(111, 32);
            this.role_textBox.TabIndex = 22;
            this.role_textBox.Text = "Role";
            this.role_textBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.role_textBox.UseMnemonic = false;
            // 
            // userIconPictureBox
            // 
            this.userIconPictureBox.BackColor = System.Drawing.Color.SeaShell;
            this.userIconPictureBox.BackgroundImage = global::pGina.Plugin.MFLoginPlugin.Properties.Resources.user_logo;
            this.userIconPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userIconPictureBox.InitialImage = null;
            this.userIconPictureBox.Location = new System.Drawing.Point(6, 40);
            this.userIconPictureBox.Name = "userIconPictureBox";
            this.userIconPictureBox.Size = new System.Drawing.Size(85, 92);
            this.userIconPictureBox.TabIndex = 17;
            this.userIconPictureBox.TabStop = false;
            // 
            // keepPassword_checkBox
            // 
            this.keepPassword_checkBox.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.keepPassword_checkBox.Checked = true;
            this.keepPassword_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.keepPassword_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.keepPassword_checkBox.Location = new System.Drawing.Point(97, 40);
            this.keepPassword_checkBox.Name = "keepPassword_checkBox";
            this.keepPassword_checkBox.Size = new System.Drawing.Size(111, 57);
            this.keepPassword_checkBox.TabIndex = 5;
            this.keepPassword_checkBox.Text = "Keep password in the OS";
            this.keepPassword_checkBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.keepPassword_checkBox.UseVisualStyleBackColor = false;
            this.keepPassword_checkBox.Click += new System.EventHandler(this.keepPassword_checkBox_Click);
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
            this.userName_textBox.Size = new System.Drawing.Size(202, 28);
            this.userName_textBox.TabIndex = 21;
            this.userName_textBox.TabStop = false;
            this.userName_textBox.Text = "Username";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.auth_tabPage);
            this.tabControl.Controls.Add(this.keys_tabPage);
            this.tabControl.Controls.Add(this.summary_tabPage);
            this.tabControl.Controls.Add(this.logs_tabPage);
            this.tabControl.Controls.Add(this.advancedSettings_tabPage);
            this.tabControl.Controls.Add(this.pGinaLogs_tabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl.HotTrack = true;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(984, 410);
            this.tabControl.TabIndex = 5;
            // 
            // summary_tabPage
            // 
            this.summary_tabPage.Controls.Add(this.collapseAll_button);
            this.summary_tabPage.Controls.Add(this.expandAll_button);
            this.summary_tabPage.Controls.Add(this.summary_treeView);
            this.summary_tabPage.Location = new System.Drawing.Point(4, 24);
            this.summary_tabPage.Name = "summary_tabPage";
            this.summary_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.summary_tabPage.Size = new System.Drawing.Size(976, 382);
            this.summary_tabPage.TabIndex = 4;
            this.summary_tabPage.Text = "Information summary";
            this.summary_tabPage.UseVisualStyleBackColor = true;
            this.summary_tabPage.Enter += new System.EventHandler(this.summary_tabPage_Enter);
            // 
            // collapseAll_button
            // 
            this.collapseAll_button.Location = new System.Drawing.Point(851, 196);
            this.collapseAll_button.Name = "collapseAll_button";
            this.collapseAll_button.Size = new System.Drawing.Size(114, 180);
            this.collapseAll_button.TabIndex = 3;
            this.collapseAll_button.Text = "Collapse all";
            this.collapseAll_button.UseVisualStyleBackColor = true;
            this.collapseAll_button.Click += new System.EventHandler(this.collapseAll_button_Click);
            // 
            // expandAll_button
            // 
            this.expandAll_button.Location = new System.Drawing.Point(851, 12);
            this.expandAll_button.Name = "expandAll_button";
            this.expandAll_button.Size = new System.Drawing.Size(114, 180);
            this.expandAll_button.TabIndex = 2;
            this.expandAll_button.Text = "Expand all";
            this.expandAll_button.UseVisualStyleBackColor = true;
            this.expandAll_button.Click += new System.EventHandler(this.expandAll_button_Click);
            // 
            // summary_treeView
            // 
            this.summary_treeView.Location = new System.Drawing.Point(8, 12);
            this.summary_treeView.Name = "summary_treeView";
            this.summary_treeView.Size = new System.Drawing.Size(837, 364);
            this.summary_treeView.TabIndex = 1;
            // 
            // logs_tabPage
            // 
            this.logs_tabPage.Controls.Add(this.logControl_groupBox);
            this.logs_tabPage.Controls.Add(this.logs_dataView);
            this.logs_tabPage.Location = new System.Drawing.Point(4, 24);
            this.logs_tabPage.Name = "logs_tabPage";
            this.logs_tabPage.Size = new System.Drawing.Size(976, 382);
            this.logs_tabPage.TabIndex = 5;
            this.logs_tabPage.Text = "Logs";
            this.logs_tabPage.UseVisualStyleBackColor = true;
            this.logs_tabPage.Enter += new System.EventHandler(this.logs_tabPage_Enter);
            // 
            // logControl_groupBox
            // 
            this.logControl_groupBox.Controls.Add(this.thisMonthLogs_radioButton);
            this.logControl_groupBox.Controls.Add(this.todayLogs_radioButton);
            this.logControl_groupBox.Controls.Add(this.countLogs_numericUpDown);
            this.logControl_groupBox.Controls.Add(this.allLogs_radioButton);
            this.logControl_groupBox.Controls.Add(this.extraLogs_checkBox);
            this.logControl_groupBox.Controls.Add(this.firstLogs_radioButton);
            this.logControl_groupBox.Controls.Add(this.lastLogs_radioButton);
            this.logControl_groupBox.Location = new System.Drawing.Point(876, 3);
            this.logControl_groupBox.Name = "logControl_groupBox";
            this.logControl_groupBox.Size = new System.Drawing.Size(97, 376);
            this.logControl_groupBox.TabIndex = 3;
            this.logControl_groupBox.TabStop = false;
            this.logControl_groupBox.Text = "Log control";
            // 
            // thisMonthLogs_radioButton
            // 
            this.thisMonthLogs_radioButton.AutoSize = true;
            this.thisMonthLogs_radioButton.Location = new System.Drawing.Point(6, 235);
            this.thisMonthLogs_radioButton.Name = "thisMonthLogs_radioButton";
            this.thisMonthLogs_radioButton.Size = new System.Drawing.Size(91, 20);
            this.thisMonthLogs_radioButton.TabIndex = 7;
            this.thisMonthLogs_radioButton.TabStop = true;
            this.thisMonthLogs_radioButton.Text = "This month";
            this.thisMonthLogs_radioButton.UseVisualStyleBackColor = true;
            this.thisMonthLogs_radioButton.CheckedChanged += new System.EventHandler(this.thisMonthLogs_radioButton_CheckedChanged);
            // 
            // todayLogs_radioButton
            // 
            this.todayLogs_radioButton.AutoSize = true;
            this.todayLogs_radioButton.Location = new System.Drawing.Point(6, 209);
            this.todayLogs_radioButton.Name = "todayLogs_radioButton";
            this.todayLogs_radioButton.Size = new System.Drawing.Size(66, 20);
            this.todayLogs_radioButton.TabIndex = 5;
            this.todayLogs_radioButton.TabStop = true;
            this.todayLogs_radioButton.Text = "Today";
            this.todayLogs_radioButton.UseVisualStyleBackColor = true;
            this.todayLogs_radioButton.CheckedChanged += new System.EventHandler(this.todayLogs_radioButton_CheckedChanged);
            // 
            // countLogs_numericUpDown
            // 
            this.countLogs_numericUpDown.Location = new System.Drawing.Point(6, 72);
            this.countLogs_numericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.countLogs_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.countLogs_numericUpDown.Name = "countLogs_numericUpDown";
            this.countLogs_numericUpDown.Size = new System.Drawing.Size(75, 21);
            this.countLogs_numericUpDown.TabIndex = 4;
            this.countLogs_numericUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.countLogs_numericUpDown.ValueChanged += new System.EventHandler(this.countLogs_numericUpDown_ValueChanged);
            // 
            // allLogs_radioButton
            // 
            this.allLogs_radioButton.AutoSize = true;
            this.allLogs_radioButton.Location = new System.Drawing.Point(6, 183);
            this.allLogs_radioButton.Name = "allLogs_radioButton";
            this.allLogs_radioButton.Size = new System.Drawing.Size(41, 20);
            this.allLogs_radioButton.TabIndex = 3;
            this.allLogs_radioButton.Text = "All";
            this.allLogs_radioButton.UseVisualStyleBackColor = true;
            this.allLogs_radioButton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // extraLogs_checkBox
            // 
            this.extraLogs_checkBox.AutoSize = true;
            this.extraLogs_checkBox.Location = new System.Drawing.Point(6, 157);
            this.extraLogs_checkBox.Name = "extraLogs_checkBox";
            this.extraLogs_checkBox.Size = new System.Drawing.Size(97, 20);
            this.extraLogs_checkBox.TabIndex = 2;
            this.extraLogs_checkBox.Text = "Service info";
            this.extraLogs_checkBox.UseVisualStyleBackColor = true;
            this.extraLogs_checkBox.CheckedChanged += new System.EventHandler(this.extraLogs_checkBox_CheckedChanged);
            // 
            // firstLogs_radioButton
            // 
            this.firstLogs_radioButton.AutoSize = true;
            this.firstLogs_radioButton.Location = new System.Drawing.Point(6, 20);
            this.firstLogs_radioButton.Name = "firstLogs_radioButton";
            this.firstLogs_radioButton.Size = new System.Drawing.Size(65, 20);
            this.firstLogs_radioButton.TabIndex = 1;
            this.firstLogs_radioButton.Text = "Oldest";
            this.firstLogs_radioButton.UseVisualStyleBackColor = true;
            this.firstLogs_radioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lastLogs_radioButton
            // 
            this.lastLogs_radioButton.AutoSize = true;
            this.lastLogs_radioButton.Checked = true;
            this.lastLogs_radioButton.Location = new System.Drawing.Point(6, 46);
            this.lastLogs_radioButton.Name = "lastLogs_radioButton";
            this.lastLogs_radioButton.Size = new System.Drawing.Size(71, 20);
            this.lastLogs_radioButton.TabIndex = 0;
            this.lastLogs_radioButton.TabStop = true;
            this.lastLogs_radioButton.Text = "Newest";
            this.lastLogs_radioButton.UseVisualStyleBackColor = true;
            this.lastLogs_radioButton.CheckedChanged += new System.EventHandler(this.last100logs_radioButton_CheckedChanged);
            // 
            // logs_dataView
            // 
            this.logs_dataView.AllowUserToAddRows = false;
            this.logs_dataView.AllowUserToDeleteRows = false;
            this.logs_dataView.AllowUserToOrderColumns = true;
            this.logs_dataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.logs_dataView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.logs_dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.logs_dataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.user_column,
            this.authMethodDescription_column,
            this.success_column,
            this.time_column,
            this.keysUsed_column,
            this.leid,
            this.uid,
            this.amid});
            this.logs_dataView.Dock = System.Windows.Forms.DockStyle.Left;
            this.logs_dataView.Location = new System.Drawing.Point(0, 0);
            this.logs_dataView.MultiSelect = false;
            this.logs_dataView.Name = "logs_dataView";
            this.logs_dataView.ReadOnly = true;
            this.logs_dataView.RowHeadersVisible = false;
            this.logs_dataView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.logs_dataView.Size = new System.Drawing.Size(870, 382);
            this.logs_dataView.TabIndex = 2;
            // 
            // user_column
            // 
            this.user_column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.user_column.Frozen = true;
            this.user_column.HeaderText = "User";
            this.user_column.MaxInputLength = 128;
            this.user_column.Name = "user_column";
            this.user_column.ReadOnly = true;
            this.user_column.Width = 62;
            // 
            // authMethodDescription_column
            // 
            this.authMethodDescription_column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.authMethodDescription_column.HeaderText = "Method";
            this.authMethodDescription_column.MaxInputLength = 256;
            this.authMethodDescription_column.Name = "authMethodDescription_column";
            this.authMethodDescription_column.ReadOnly = true;
            this.authMethodDescription_column.Width = 5;
            // 
            // success_column
            // 
            this.success_column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.success_column.HeaderText = "Success";
            this.success_column.MaxInputLength = 20;
            this.success_column.Name = "success_column";
            this.success_column.ReadOnly = true;
            this.success_column.Width = 85;
            // 
            // time_column
            // 
            this.time_column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.time_column.HeaderText = "Time";
            this.time_column.Name = "time_column";
            this.time_column.ReadOnly = true;
            this.time_column.Width = 64;
            // 
            // keysUsed_column
            // 
            this.keysUsed_column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.keysUsed_column.HeaderText = "Keys";
            this.keysUsed_column.Name = "keysUsed_column";
            this.keysUsed_column.ReadOnly = true;
            // 
            // leid
            // 
            this.leid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.leid.HeaderText = "LEID";
            this.leid.Name = "leid";
            this.leid.ReadOnly = true;
            this.leid.Visible = false;
            // 
            // uid
            // 
            this.uid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.uid.HeaderText = "UID";
            this.uid.Name = "uid";
            this.uid.ReadOnly = true;
            this.uid.Visible = false;
            // 
            // amid
            // 
            this.amid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.amid.HeaderText = "AMID";
            this.amid.Name = "amid";
            this.amid.ReadOnly = true;
            this.amid.Visible = false;
            // 
            // pGinaLogs_tabPage
            // 
            this.pGinaLogs_tabPage.Controls.Add(this.pGinaLogs_tabControl);
            this.pGinaLogs_tabPage.Location = new System.Drawing.Point(4, 24);
            this.pGinaLogs_tabPage.Name = "pGinaLogs_tabPage";
            this.pGinaLogs_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.pGinaLogs_tabPage.Size = new System.Drawing.Size(976, 382);
            this.pGinaLogs_tabPage.TabIndex = 6;
            this.pGinaLogs_tabPage.Text = "pGina logs";
            this.pGinaLogs_tabPage.UseVisualStyleBackColor = true;
            this.pGinaLogs_tabPage.Enter += new System.EventHandler(this.pGinaLogs_tabPage_Enter);
            // 
            // pGinaLogs_tabControl
            // 
            this.pGinaLogs_tabControl.Controls.Add(this.pGinaLogsConfig_tabPage);
            this.pGinaLogs_tabControl.Controls.Add(this.pGinaLogsService_tabPage);
            this.pGinaLogs_tabControl.Location = new System.Drawing.Point(3, 3);
            this.pGinaLogs_tabControl.Name = "pGinaLogs_tabControl";
            this.pGinaLogs_tabControl.SelectedIndex = 0;
            this.pGinaLogs_tabControl.Size = new System.Drawing.Size(970, 376);
            this.pGinaLogs_tabControl.TabIndex = 1;
            // 
            // pGinaLogsConfig_tabPage
            // 
            this.pGinaLogsConfig_tabPage.Controls.Add(this.pGinaConfigLog_listBox);
            this.pGinaLogsConfig_tabPage.Location = new System.Drawing.Point(4, 24);
            this.pGinaLogsConfig_tabPage.Name = "pGinaLogsConfig_tabPage";
            this.pGinaLogsConfig_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.pGinaLogsConfig_tabPage.Size = new System.Drawing.Size(962, 348);
            this.pGinaLogsConfig_tabPage.TabIndex = 0;
            this.pGinaLogsConfig_tabPage.Text = "Configuration";
            this.pGinaLogsConfig_tabPage.UseVisualStyleBackColor = true;
            this.pGinaLogsConfig_tabPage.Enter += new System.EventHandler(this.pGinaLogsConfig_tabPage_Enter);
            this.pGinaLogsConfig_tabPage.Validated += new System.EventHandler(this.pGinaLogsConfig_tabPage_Validated);
            // 
            // pGinaConfigLog_listBox
            // 
            this.pGinaConfigLog_listBox.FormattingEnabled = true;
            this.pGinaConfigLog_listBox.HorizontalScrollbar = true;
            this.pGinaConfigLog_listBox.ItemHeight = 15;
            this.pGinaConfigLog_listBox.Location = new System.Drawing.Point(0, 0);
            this.pGinaConfigLog_listBox.Name = "pGinaConfigLog_listBox";
            this.pGinaConfigLog_listBox.Size = new System.Drawing.Size(962, 349);
            this.pGinaConfigLog_listBox.TabIndex = 0;
            this.pGinaConfigLog_listBox.SelectedIndexChanged += new System.EventHandler(this.pGinaConfigLog_listBox_SelectedIndexChanged);
            // 
            // pGinaLogsService_tabPage
            // 
            this.pGinaLogsService_tabPage.Controls.Add(this.pGinaServiceLog_listBox);
            this.pGinaLogsService_tabPage.Location = new System.Drawing.Point(4, 24);
            this.pGinaLogsService_tabPage.Name = "pGinaLogsService_tabPage";
            this.pGinaLogsService_tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.pGinaLogsService_tabPage.Size = new System.Drawing.Size(962, 348);
            this.pGinaLogsService_tabPage.TabIndex = 1;
            this.pGinaLogsService_tabPage.Text = "Service";
            this.pGinaLogsService_tabPage.UseVisualStyleBackColor = true;
            this.pGinaLogsService_tabPage.Enter += new System.EventHandler(this.pGinaLogsService_tabPage_Enter);
            // 
            // pGinaServiceLog_listBox
            // 
            this.pGinaServiceLog_listBox.FormattingEnabled = true;
            this.pGinaServiceLog_listBox.HorizontalScrollbar = true;
            this.pGinaServiceLog_listBox.ItemHeight = 15;
            this.pGinaServiceLog_listBox.Location = new System.Drawing.Point(0, 0);
            this.pGinaServiceLog_listBox.Name = "pGinaServiceLog_listBox";
            this.pGinaServiceLog_listBox.Size = new System.Drawing.Size(962, 349);
            this.pGinaServiceLog_listBox.TabIndex = 1;
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
            this.Load += new System.EventHandler(this.LocalConfiguration_Load);
            this.changeRole_contextMenuStrip.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.advancedSettings_tabPage.ResumeLayout(false);
            this.keysAdvancedSettings_groupBox.ResumeLayout(false);
            this.keysAdvancedSettings_groupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.otherAdvancedSettings_groupBox.ResumeLayout(false);
            this.otherAdvancedSettings_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxAuthTime_numericUpDown)).EndInit();
            this.database_groupBox.ResumeLayout(false);
            this.database_groupBox.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.backup_groupBox.ResumeLayout(false);
            this.backup_panel.ResumeLayout(false);
            this.backup_panel.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.keys_tabPage.ResumeLayout(false);
            this.checkKey_groupBox.ResumeLayout(false);
            this.checkKey_groupBox.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.keyInfo_groupBox.ResumeLayout(false);
            this.keyInfo_groupBox.PerformLayout();
            this.auth_tabPage.ResumeLayout(false);
            this.fastChoice_groupBox.ResumeLayout(false);
            this.authConfig.ResumeLayout(false);
            this.authConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keysRequired_NumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.successPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locked_pictureBox)).EndInit();
            this.testAM_groupBox.ResumeLayout(false);
            this.testAM_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.openingPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.UsersGroupBox.ResumeLayout(false);
            this.UsersGroupBox.PerformLayout();
            this.user_groupBox.ResumeLayout(false);
            this.user_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userIconPictureBox)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.summary_tabPage.ResumeLayout(false);
            this.logs_tabPage.ResumeLayout(false);
            this.logControl_groupBox.ResumeLayout(false);
            this.logControl_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countLogs_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logs_dataView)).EndInit();
            this.pGinaLogs_tabPage.ResumeLayout(false);
            this.pGinaLogs_tabControl.ResumeLayout(false);
            this.pGinaLogsConfig_tabPage.ResumeLayout(false);
            this.pGinaLogsService_tabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStrip controlPanel;
        private System.Windows.Forms.ToolStripButton ok_toolStripButton;
		private System.Windows.Forms.ContextMenuStrip changeRole_contextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem user_toolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem admin_toolStripMenuItem;
		private System.Windows.Forms.TabPage advancedSettings_tabPage;
		private System.Windows.Forms.Button runSetup_button;
        private System.Windows.Forms.TabPage keys_tabPage;
		private System.Windows.Forms.ListBox keysListBox;
		private System.Windows.Forms.TabPage auth_tabPage;
		private System.Windows.Forms.GroupBox fastChoice_groupBox;
		private System.Windows.Forms.ListView fastChoiceTypes_listView;
		private System.Windows.Forms.GroupBox user_groupBox;
		private System.Windows.Forms.PictureBox userIconPictureBox;
        private System.Windows.Forms.CheckBox keepPassword_checkBox;
		private System.Windows.Forms.TextBox userName_textBox;
		private System.Windows.Forms.GroupBox authConfig;
		private System.Windows.Forms.PictureBox openingPictureBox;
		private System.Windows.Forms.PictureBox successPictureBox;
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
		private System.Windows.Forms.ListBox user_ListBox;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.GroupBox keyInfo_groupBox;
		private System.Windows.Forms.TextBox keyDescription_textBox;
		private System.Windows.Forms.Label keyDescription_label;
		private System.Windows.Forms.CheckBox keyInverted_checkBox;
		private System.Windows.Forms.Label keyType_label;
		private System.Windows.Forms.CheckBox keyData_checkBox;
		private System.Windows.Forms.CheckBox keyPassword_checkBox;
		private System.Windows.Forms.CheckBox keySerial_checkBox;
		private System.Windows.Forms.Button keyConfigure_button;
		private System.Windows.Forms.TabPage summary_tabPage;
		private System.Windows.Forms.Button deleteKey_button;
		private System.Windows.Forms.CheckBox keyRemoval_checkBox;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox description_textBox;
		private System.Windows.Forms.Label description_label;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button removeAuthMethod_button;
		private System.Windows.Forms.Button newAuthMethod_button;
		private System.Windows.Forms.ListBox authMethods_listBox;
		private System.Windows.Forms.Label keysRequired_label;
		private System.Windows.Forms.NumericUpDown keysRequired_NumUpDown;
		private System.Windows.Forms.TreeView summary_treeView;
		private System.Windows.Forms.Button collapseAll_button;
		private System.Windows.Forms.Button expandAll_button;
		private System.Windows.Forms.TextBox keySerial_textBox;
        private System.Windows.Forms.GroupBox database_groupBox;
        private System.Windows.Forms.Label database_label;
        private System.Windows.Forms.Button cleanDB_button;
        private System.Windows.Forms.Button cleanDBKeys_button;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox dbErase_checkBox;
        private System.Windows.Forms.Button dbErase_button;
        private System.Windows.Forms.GroupBox backup_groupBox;
        private System.Windows.Forms.CheckBox removeWindowsUser_checkBox;
        private System.Windows.Forms.TabPage logs_tabPage;
        private System.Windows.Forms.CheckBox DBOpened_checkBox;
        private System.Windows.Forms.DataGridView logs_dataView;
        private System.Windows.Forms.GroupBox logControl_groupBox;
        private System.Windows.Forms.RadioButton firstLogs_radioButton;
        private System.Windows.Forms.RadioButton lastLogs_radioButton;
        private System.Windows.Forms.CheckBox extraLogs_checkBox;
        private System.Windows.Forms.RadioButton allLogs_radioButton;
        private System.Windows.Forms.NumericUpDown countLogs_numericUpDown;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn authMethodDescription_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn success_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn time_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn keysUsed_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn leid;
        private System.Windows.Forms.DataGridViewTextBoxColumn uid;
        private System.Windows.Forms.DataGridViewTextBoxColumn amid;
        private System.Windows.Forms.RadioButton todayLogs_radioButton;
        private System.Windows.Forms.RadioButton thisMonthLogs_radioButton;
        private System.Windows.Forms.Button removeUnusedKeys_button;
        private System.Windows.Forms.GroupBox checkKey_groupBox;
        private System.Windows.Forms.Button checkKeyResult_button;
        private System.Windows.Forms.Button checkKey_button;
        private System.Windows.Forms.Label checkPassword_label;
        private System.Windows.Forms.TextBox checkPassword_textBox;
        private System.Windows.Forms.CheckBox advancedSettings_alwaysCheckSelectedKey_checkBox;
        private System.Windows.Forms.GroupBox testAM_groupBox;
        private System.Windows.Forms.TextBox testAMpassword_textBox;
        private System.Windows.Forms.PictureBox locked_pictureBox;
        private System.Windows.Forms.Label role_textBox;
        private System.Windows.Forms.CheckBox requireAtLeastOneKeyInAuthMethod_checkBox;
        private System.Windows.Forms.ToolStripButton cancel_toolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.LinkLabel discardChanges_linkLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox onLoadBackupEnabled_checkBox;
        private System.Windows.Forms.Label dbBackupWarning_label;
        private System.Windows.Forms.Panel backup_panel;
        private System.Windows.Forms.Label backupPassword_label;
        private System.Windows.Forms.Button backupPath_button;
        private System.Windows.Forms.TextBox backupPassword_textBox;
        private System.Windows.Forms.TextBox backupPath_textBox;
        private System.Windows.Forms.Button backupBackup_button;
        private System.Windows.Forms.GroupBox otherAdvancedSettings_groupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button RestoreWindowsUsers_button;
		private System.Windows.Forms.CheckBox openSummaryCollapsed_checkBox;
		private System.Windows.Forms.TabPage pGinaLogs_tabPage;
		private System.Windows.Forms.ListBox pGinaConfigLog_listBox;
		private System.Windows.Forms.TabControl pGinaLogs_tabControl;
		private System.Windows.Forms.TabPage pGinaLogsConfig_tabPage;
		private System.Windows.Forms.TabPage pGinaLogsService_tabPage;
		private System.Windows.Forms.CheckBox showpGinaLogs_checkBox;
		private System.Windows.Forms.ListBox pGinaServiceLog_listBox;
        private System.Windows.Forms.CheckBox removeWithProfile_checkBox;
        private System.Windows.Forms.NumericUpDown maxAuthTime_numericUpDown;
        private System.Windows.Forms.Label maxAuthTime_label;
        private System.Windows.Forms.GroupBox keysAdvancedSettings_groupBox;
        private System.Windows.Forms.CheckBox onlyPairedBluetoothDevices_checkBox;
	}
}