namespace pGina.Plugin.MFLoginPlugin.Entities.ManagementForms
{
	partial class UserManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManagementForm));
            this.addUser_button = new System.Windows.Forms.Button();
            this.name_groupBox = new System.Windows.Forms.GroupBox();
            this.userNameCorrect_label = new System.Windows.Forms.Label();
            this.username_textBox = new System.Windows.Forms.TextBox();
            this.role_groupBox = new System.Windows.Forms.GroupBox();
            this.administrator_radioButton = new System.Windows.Forms.RadioButton();
            this.user_radioButton = new System.Windows.Forms.RadioButton();
            this.systemUsers_listBox = new System.Windows.Forms.ListBox();
            this.pickUser_comboBox = new System.Windows.Forms.ComboBox();
            this.warning_label = new System.Windows.Forms.Label();
            this.name_groupBox.SuspendLayout();
            this.role_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addUser_button
            // 
            this.addUser_button.Location = new System.Drawing.Point(13, 294);
            this.addUser_button.Name = "addUser_button";
            this.addUser_button.Size = new System.Drawing.Size(295, 31);
            this.addUser_button.TabIndex = 0;
            this.addUser_button.Text = "Add";
            this.addUser_button.UseVisualStyleBackColor = true;
            this.addUser_button.Click += new System.EventHandler(this.addUser_button_Click);
            // 
            // name_groupBox
            // 
            this.name_groupBox.Controls.Add(this.userNameCorrect_label);
            this.name_groupBox.Controls.Add(this.username_textBox);
            this.name_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.name_groupBox.Location = new System.Drawing.Point(13, 117);
            this.name_groupBox.Name = "name_groupBox";
            this.name_groupBox.Size = new System.Drawing.Size(295, 96);
            this.name_groupBox.TabIndex = 1;
            this.name_groupBox.TabStop = false;
            this.name_groupBox.Text = "Username";
            // 
            // userNameCorrect_label
            // 
            this.userNameCorrect_label.AutoSize = true;
            this.userNameCorrect_label.Location = new System.Drawing.Point(7, 73);
            this.userNameCorrect_label.Name = "userNameCorrect_label";
            this.userNameCorrect_label.Size = new System.Drawing.Size(183, 17);
            this.userNameCorrect_label.TabIndex = 1;
            this.userNameCorrect_label.Text = "Create a new Windows user";
            // 
            // username_textBox
            // 
            this.username_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.username_textBox.Location = new System.Drawing.Point(6, 22);
            this.username_textBox.Multiline = true;
            this.username_textBox.Name = "username_textBox";
            this.username_textBox.Size = new System.Drawing.Size(283, 48);
            this.username_textBox.TabIndex = 0;
            this.username_textBox.TextChanged += new System.EventHandler(this.username_textBox_TextChanged);
            // 
            // role_groupBox
            // 
            this.role_groupBox.Controls.Add(this.administrator_radioButton);
            this.role_groupBox.Controls.Add(this.user_radioButton);
            this.role_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.role_groupBox.Location = new System.Drawing.Point(13, 219);
            this.role_groupBox.Name = "role_groupBox";
            this.role_groupBox.Size = new System.Drawing.Size(295, 69);
            this.role_groupBox.TabIndex = 2;
            this.role_groupBox.TabStop = false;
            this.role_groupBox.Text = "Role";
            // 
            // administrator_radioButton
            // 
            this.administrator_radioButton.AutoSize = true;
            this.administrator_radioButton.Location = new System.Drawing.Point(7, 44);
            this.administrator_radioButton.Name = "administrator_radioButton";
            this.administrator_radioButton.Size = new System.Drawing.Size(109, 21);
            this.administrator_radioButton.TabIndex = 1;
            this.administrator_radioButton.TabStop = true;
            this.administrator_radioButton.Text = "Administrator";
            this.administrator_radioButton.UseVisualStyleBackColor = true;
            // 
            // user_radioButton
            // 
            this.user_radioButton.AutoSize = true;
            this.user_radioButton.Checked = true;
            this.user_radioButton.Location = new System.Drawing.Point(7, 20);
            this.user_radioButton.Name = "user_radioButton";
            this.user_radioButton.Size = new System.Drawing.Size(56, 21);
            this.user_radioButton.TabIndex = 0;
            this.user_radioButton.TabStop = true;
            this.user_radioButton.Text = "User";
            this.user_radioButton.UseVisualStyleBackColor = true;
            // 
            // systemUsers_listBox
            // 
            this.systemUsers_listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.systemUsers_listBox.FormattingEnabled = true;
            this.systemUsers_listBox.ItemHeight = 15;
            this.systemUsers_listBox.Location = new System.Drawing.Point(319, 51);
            this.systemUsers_listBox.Name = "systemUsers_listBox";
            this.systemUsers_listBox.Size = new System.Drawing.Size(305, 274);
            this.systemUsers_listBox.TabIndex = 3;
            this.systemUsers_listBox.SelectedIndexChanged += new System.EventHandler(this.systemUsers_listBox_SelectedIndexChanged);
            // 
            // pickUser_comboBox
            // 
            this.pickUser_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.pickUser_comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pickUser_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.pickUser_comboBox.FormattingEnabled = true;
            this.pickUser_comboBox.Location = new System.Drawing.Point(319, 12);
            this.pickUser_comboBox.MaxLength = 128;
            this.pickUser_comboBox.Name = "pickUser_comboBox";
            this.pickUser_comboBox.Size = new System.Drawing.Size(305, 26);
            this.pickUser_comboBox.Sorted = true;
            this.pickUser_comboBox.TabIndex = 4;
            this.pickUser_comboBox.SelectedIndexChanged += new System.EventHandler(this.pickUser_comboBox_SelectedIndexChanged);
            // 
            // warning_label
            // 
            this.warning_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.warning_label.Location = new System.Drawing.Point(16, 18);
            this.warning_label.Name = "warning_label";
            this.warning_label.Size = new System.Drawing.Size(292, 102);
            this.warning_label.TabIndex = 5;
            this.warning_label.Text = resources.GetString("warning_label.Text");
            // 
            // UserManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 336);
            this.Controls.Add(this.warning_label);
            this.Controls.Add(this.pickUser_comboBox);
            this.Controls.Add(this.systemUsers_listBox);
            this.Controls.Add(this.role_groupBox);
            this.Controls.Add(this.name_groupBox);
            this.Controls.Add(this.addUser_button);
            this.Name = "UserManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New user";
            this.Load += new System.EventHandler(this.AddUserForm_Load);
            this.name_groupBox.ResumeLayout(false);
            this.name_groupBox.PerformLayout();
            this.role_groupBox.ResumeLayout(false);
            this.role_groupBox.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button addUser_button;
		private System.Windows.Forms.GroupBox name_groupBox;
		private System.Windows.Forms.TextBox username_textBox;
		private System.Windows.Forms.GroupBox role_groupBox;
		private System.Windows.Forms.RadioButton administrator_radioButton;
		private System.Windows.Forms.RadioButton user_radioButton;
        private System.Windows.Forms.Label userNameCorrect_label;
        private System.Windows.Forms.ListBox systemUsers_listBox;
        private System.Windows.Forms.ComboBox pickUser_comboBox;
        private System.Windows.Forms.Label warning_label;
	}
}