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
			this.authConfig = new System.Windows.Forms.GroupBox();
			this.successPictureBox = new System.Windows.Forms.PictureBox();
			this.userIconPictureBox = new System.Windows.Forms.PictureBox();
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
			this.userListBox = new System.Windows.Forms.ListBox();
			this.ListDragSource = new System.Windows.Forms.ListView();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.newKey_label = new System.Windows.Forms.Label();
			this.newBluetooth_button = new System.Windows.Forms.Button();
			this.newUSB_button = new System.Windows.Forms.Button();
			this.newPassword_button = new System.Windows.Forms.Button();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.newUser_label = new System.Windows.Forms.Label();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.runSetup_button = new System.Windows.Forms.Button();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
			this.openingPictureBox = new System.Windows.Forms.PictureBox();
			this.tabControl.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.authConfig.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.successPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.userIconPictureBox)).BeginInit();
			this.UsersGroupBox.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.openingPictureBox)).BeginInit();
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
			this.tabControl.Size = new System.Drawing.Size(833, 392);
			this.tabControl.TabIndex = 5;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.authConfig);
			this.tabPage1.Controls.Add(this.UsersGroupBox);
			this.tabPage1.Controls.Add(this.ListDragSource);
			this.tabPage1.Location = new System.Drawing.Point(4, 24);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
			this.tabPage1.Size = new System.Drawing.Size(825, 364);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Authentication";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// authConfig
			// 
			this.authConfig.Controls.Add(this.openingPictureBox);
			this.authConfig.Controls.Add(this.successPictureBox);
			this.authConfig.Controls.Add(this.userIconPictureBox);
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
			this.authConfig.Location = new System.Drawing.Point(155, 8);
			this.authConfig.Name = "authConfig";
			this.authConfig.Size = new System.Drawing.Size(662, 194);
			this.authConfig.TabIndex = 12;
			this.authConfig.TabStop = false;
			this.authConfig.Text = "User authentication";
			// 
			// successPictureBox
			// 
			this.successPictureBox.BackgroundImage = global::pGina.Plugin.MFLoginPlugin.Properties.Resources.success;
			this.successPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.successPictureBox.Location = new System.Drawing.Point(601, 27);
			this.successPictureBox.Name = "successPictureBox";
			this.successPictureBox.Size = new System.Drawing.Size(55, 73);
			this.successPictureBox.TabIndex = 18;
			this.successPictureBox.TabStop = false;
			// 
			// userIconPictureBox
			// 
			this.userIconPictureBox.BackColor = System.Drawing.Color.SeaShell;
			this.userIconPictureBox.BackgroundImage = global::pGina.Plugin.MFLoginPlugin.Properties.Resources.user_logo;
			this.userIconPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.userIconPictureBox.InitialImage = null;
			this.userIconPictureBox.Location = new System.Drawing.Point(16, 27);
			this.userIconPictureBox.Name = "userIconPictureBox";
			this.userIconPictureBox.Size = new System.Drawing.Size(70, 73);
			this.userIconPictureBox.TabIndex = 17;
			this.userIconPictureBox.TabStop = false;
			// 
			// key5Label
			// 
			this.key5Label.Location = new System.Drawing.Point(513, 27);
			this.key5Label.Name = "key5Label";
			this.key5Label.Size = new System.Drawing.Size(80, 20);
			this.key5Label.TabIndex = 16;
			this.key5Label.Text = "Key 5";
			this.key5Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// key4Label
			// 
			this.key4Label.Location = new System.Drawing.Point(427, 27);
			this.key4Label.Name = "key4Label";
			this.key4Label.Size = new System.Drawing.Size(80, 20);
			this.key4Label.TabIndex = 15;
			this.key4Label.Text = "Key 4";
			this.key4Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// key3Label
			// 
			this.key3Label.Location = new System.Drawing.Point(341, 27);
			this.key3Label.Name = "key3Label";
			this.key3Label.Size = new System.Drawing.Size(80, 20);
			this.key3Label.TabIndex = 14;
			this.key3Label.Text = "Key 3";
			this.key3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// key2Label
			// 
			this.key2Label.Location = new System.Drawing.Point(252, 27);
			this.key2Label.Name = "key2Label";
			this.key2Label.Size = new System.Drawing.Size(80, 20);
			this.key2Label.TabIndex = 13;
			this.key2Label.Text = "Key 2";
			this.key2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// key1Label
			// 
			this.key1Label.Location = new System.Drawing.Point(169, 27);
			this.key1Label.Name = "key1Label";
			this.key1Label.Size = new System.Drawing.Size(80, 20);
			this.key1Label.TabIndex = 12;
			this.key1Label.Text = "Key 1";
			this.key1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// key3Button
			// 
			this.key3Button.AllowDrop = true;
			this.key3Button.Location = new System.Drawing.Point(341, 50);
			this.key3Button.Name = "key3Button";
			this.key3Button.Size = new System.Drawing.Size(80, 50);
			this.key3Button.TabIndex = 9;
			this.key3Button.UseVisualStyleBackColor = true;
			this.key3Button.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragTarget_DragDrop);
			this.key3Button.DragOver += new System.Windows.Forms.DragEventHandler(this.DragTarget_DragOver);
			// 
			// key5Button
			// 
			this.key5Button.AllowDrop = true;
			this.key5Button.Location = new System.Drawing.Point(513, 50);
			this.key5Button.Name = "key5Button";
			this.key5Button.Size = new System.Drawing.Size(80, 50);
			this.key5Button.TabIndex = 11;
			this.key5Button.UseVisualStyleBackColor = true;
			this.key5Button.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragTarget_DragDrop);
			this.key5Button.DragOver += new System.Windows.Forms.DragEventHandler(this.DragTarget_DragOver);
			// 
			// key4Button
			// 
			this.key4Button.AllowDrop = true;
			this.key4Button.Location = new System.Drawing.Point(427, 50);
			this.key4Button.Name = "key4Button";
			this.key4Button.Size = new System.Drawing.Size(80, 50);
			this.key4Button.TabIndex = 10;
			this.key4Button.UseVisualStyleBackColor = true;
			this.key4Button.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragTarget_DragDrop);
			this.key4Button.DragOver += new System.Windows.Forms.DragEventHandler(this.DragTarget_DragOver);
			// 
			// key1Button
			// 
			this.key1Button.AllowDrop = true;
			this.key1Button.Location = new System.Drawing.Point(169, 50);
			this.key1Button.Name = "key1Button";
			this.key1Button.Size = new System.Drawing.Size(80, 50);
			this.key1Button.TabIndex = 7;
			this.key1Button.UseVisualStyleBackColor = true;
			this.key1Button.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragTarget_DragDrop);
			this.key1Button.DragOver += new System.Windows.Forms.DragEventHandler(this.DragTarget_DragOver);
			// 
			// key2Button
			// 
			this.key2Button.AllowDrop = true;
			this.key2Button.Location = new System.Drawing.Point(255, 50);
			this.key2Button.Name = "key2Button";
			this.key2Button.Size = new System.Drawing.Size(80, 50);
			this.key2Button.TabIndex = 8;
			this.key2Button.UseVisualStyleBackColor = true;
			this.key2Button.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragTarget_DragDrop);
			this.key2Button.DragOver += new System.Windows.Forms.DragEventHandler(this.DragTarget_DragOver);
			// 
			// UsersGroupBox
			// 
			this.UsersGroupBox.Controls.Add(this.userListBox);
			this.UsersGroupBox.Location = new System.Drawing.Point(9, 8);
			this.UsersGroupBox.Name = "UsersGroupBox";
			this.UsersGroupBox.Size = new System.Drawing.Size(133, 307);
			this.UsersGroupBox.TabIndex = 6;
			this.UsersGroupBox.TabStop = false;
			this.UsersGroupBox.Text = "Users";
			// 
			// userListBox
			// 
			this.userListBox.FormattingEnabled = true;
			this.userListBox.ItemHeight = 15;
			this.userListBox.Location = new System.Drawing.Point(6, 27);
			this.userListBox.Name = "userListBox";
			this.userListBox.Size = new System.Drawing.Size(120, 274);
			this.userListBox.TabIndex = 5;
			// 
			// ListDragSource
			// 
			this.ListDragSource.Alignment = System.Windows.Forms.ListViewAlignment.Default;
			this.ListDragSource.AutoArrange = false;
			this.ListDragSource.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			listViewItem1.Tag = "Password";
			listViewItem2.Tag = "USB";
			this.ListDragSource.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
			this.ListDragSource.LabelWrap = false;
			this.ListDragSource.Location = new System.Drawing.Point(437, 232);
			this.ListDragSource.MultiSelect = false;
			this.ListDragSource.Name = "ListDragSource";
			this.ListDragSource.ShowGroups = false;
			this.ListDragSource.Size = new System.Drawing.Size(275, 109);
			this.ListDragSource.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.ListDragSource.TabIndex = 4;
			this.ListDragSource.UseCompatibleStateImageBehavior = false;
			this.ListDragSource.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragSource_MouseDown);
			this.ListDragSource.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragSource_MouseMove);
			this.ListDragSource.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragSource_MouseUp);
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
			this.tabPage3.Size = new System.Drawing.Size(825, 364);
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
			this.tabPage2.Size = new System.Drawing.Size(825, 364);
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
			this.tabPage4.Size = new System.Drawing.Size(825, 364);
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
			// toolStrip1
			// 
			this.toolStrip1.AutoSize = false;
			this.toolStrip1.CanOverflow = false;
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton4,
            this.toolStripButton3});
			this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.toolStrip1.Location = new System.Drawing.Point(0, 389);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.toolStrip1.Size = new System.Drawing.Size(833, 28);
			this.toolStrip1.TabIndex = 6;
			this.toolStrip1.Text = "toolStrip1";
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
			this.toolStripButton3.Text = "SAVE";
			this.toolStripButton3.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// openingPictureBox
			// 
			this.openingPictureBox.BackgroundImage = global::pGina.Plugin.MFLoginPlugin.Properties.Resources.opening;
			this.openingPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.openingPictureBox.Location = new System.Drawing.Point(104, 27);
			this.openingPictureBox.Name = "openingPictureBox";
			this.openingPictureBox.Size = new System.Drawing.Size(56, 73);
			this.openingPictureBox.TabIndex = 19;
			this.openingPictureBox.TabStop = false;
			// 
			// LocalConfiguration
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(833, 417);
			this.Controls.Add(this.toolStrip1);
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
			this.authConfig.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.successPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.userIconPictureBox)).EndInit();
			this.UsersGroupBox.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage4.ResumeLayout(false);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.openingPictureBox)).EndInit();
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
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ListView ListDragSource;
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
	}
}