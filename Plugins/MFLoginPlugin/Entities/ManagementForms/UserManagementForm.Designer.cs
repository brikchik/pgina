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
			this.addUser_button = new System.Windows.Forms.Button();
			this.name_groupBox = new System.Windows.Forms.GroupBox();
			this.role_groupBox = new System.Windows.Forms.GroupBox();
			this.user_radioButton = new System.Windows.Forms.RadioButton();
			this.administrator_radioButton = new System.Windows.Forms.RadioButton();
			this.username_textBox = new System.Windows.Forms.TextBox();
			this.userNameCorrect_label = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.name_groupBox.SuspendLayout();
			this.role_groupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// addUser_button
			// 
			this.addUser_button.Location = new System.Drawing.Point(13, 407);
			this.addUser_button.Name = "addUser_button";
			this.addUser_button.Size = new System.Drawing.Size(273, 31);
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
			this.name_groupBox.Location = new System.Drawing.Point(13, 223);
			this.name_groupBox.Name = "name_groupBox";
			this.name_groupBox.Size = new System.Drawing.Size(273, 103);
			this.name_groupBox.TabIndex = 1;
			this.name_groupBox.TabStop = false;
			this.name_groupBox.Text = "Username";
			// 
			// role_groupBox
			// 
			this.role_groupBox.Controls.Add(this.administrator_radioButton);
			this.role_groupBox.Controls.Add(this.user_radioButton);
			this.role_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.role_groupBox.Location = new System.Drawing.Point(13, 332);
			this.role_groupBox.Name = "role_groupBox";
			this.role_groupBox.Size = new System.Drawing.Size(273, 69);
			this.role_groupBox.TabIndex = 2;
			this.role_groupBox.TabStop = false;
			this.role_groupBox.Text = "Role";
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
			// username_textBox
			// 
			this.username_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.username_textBox.Location = new System.Drawing.Point(6, 22);
			this.username_textBox.Multiline = true;
			this.username_textBox.Name = "username_textBox";
			this.username_textBox.Size = new System.Drawing.Size(260, 48);
			this.username_textBox.TabIndex = 0;
			this.username_textBox.TextChanged += new System.EventHandler(this.username_textBox_TextChanged);
			// 
			// userNameCorrect_label
			// 
			this.userNameCorrect_label.AutoSize = true;
			this.userNameCorrect_label.Location = new System.Drawing.Point(7, 77);
			this.userNameCorrect_label.Name = "userNameCorrect_label";
			this.userNameCorrect_label.Size = new System.Drawing.Size(129, 17);
			this.userNameCorrect_label.TabIndex = 1;
			this.userNameCorrect_label.Text = "Username is empty";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(346, 81);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(322, 175);
			this.textBox1.TabIndex = 3;
			// 
			// UserManagementForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.role_groupBox);
			this.Controls.Add(this.name_groupBox);
			this.Controls.Add(this.addUser_button);
			this.Name = "UserManagementForm";
			this.Text = "AddUserForm";
			this.Load += new System.EventHandler(this.AddUserForm_Load);
			this.name_groupBox.ResumeLayout(false);
			this.name_groupBox.PerformLayout();
			this.role_groupBox.ResumeLayout(false);
			this.role_groupBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button addUser_button;
		private System.Windows.Forms.GroupBox name_groupBox;
		private System.Windows.Forms.TextBox username_textBox;
		private System.Windows.Forms.GroupBox role_groupBox;
		private System.Windows.Forms.RadioButton administrator_radioButton;
		private System.Windows.Forms.RadioButton user_radioButton;
		private System.Windows.Forms.Label userNameCorrect_label;
		private System.Windows.Forms.TextBox textBox1;
	}
}