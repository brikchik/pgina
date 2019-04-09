namespace pGina.Plugin.MFLoginPlugin.Entities.ManagementForms
{
    partial class EncryptedPasswordFileKeyManagementForm
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
            this.chooseFile_button = new System.Windows.Forms.Button();
            this.inverted_checkBox = new System.Windows.Forms.CheckBox();
            this.password_label = new System.Windows.Forms.Label();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.description_textBox = new System.Windows.Forms.TextBox();
            this.description_label = new System.Windows.Forms.Label();
            this.ok_button = new System.Windows.Forms.Button();
            this.path_textBox = new System.Windows.Forms.TextBox();
            this.savePassword_checkBox = new System.Windows.Forms.CheckBox();
            this.createdKeys_listBox = new System.Windows.Forms.ListBox();
            this.existingKeys_groupBox = new System.Windows.Forms.GroupBox();
            this.existingKeys_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // chooseFile_button
            // 
            this.chooseFile_button.Location = new System.Drawing.Point(9, 9);
            this.chooseFile_button.Name = "chooseFile_button";
            this.chooseFile_button.Size = new System.Drawing.Size(256, 32);
            this.chooseFile_button.TabIndex = 14;
            this.chooseFile_button.Text = "Choose file path";
            this.chooseFile_button.UseVisualStyleBackColor = true;
            this.chooseFile_button.Click += new System.EventHandler(this.chooseFile_button_Click);
            // 
            // inverted_checkBox
            // 
            this.inverted_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.inverted_checkBox.Location = new System.Drawing.Point(9, 178);
            this.inverted_checkBox.Name = "inverted_checkBox";
            this.inverted_checkBox.Size = new System.Drawing.Size(256, 39);
            this.inverted_checkBox.TabIndex = 16;
            this.inverted_checkBox.Text = "Invert (File has to be MISSING / password incorrect)";
            this.inverted_checkBox.UseVisualStyleBackColor = true;
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.password_label.Location = new System.Drawing.Point(6, 71);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(140, 17);
            this.password_label.TabIndex = 20;
            this.password_label.Text = "Password for the file:";
            // 
            // password_textBox
            // 
            this.password_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.password_textBox.Location = new System.Drawing.Point(9, 91);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(256, 23);
            this.password_textBox.TabIndex = 15;
            // 
            // description_textBox
            // 
            this.description_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.description_textBox.Location = new System.Drawing.Point(9, 241);
            this.description_textBox.Multiline = true;
            this.description_textBox.Name = "description_textBox";
            this.description_textBox.Size = new System.Drawing.Size(256, 53);
            this.description_textBox.TabIndex = 17;
            this.description_textBox.Text = "PasswordFileKey";
            // 
            // description_label
            // 
            this.description_label.AutoSize = true;
            this.description_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.description_label.Location = new System.Drawing.Point(10, 220);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(83, 17);
            this.description_label.TabIndex = 19;
            this.description_label.Text = "Description:";
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(9, 300);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(256, 26);
            this.ok_button.TabIndex = 18;
            this.ok_button.Text = "Set";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // path_textBox
            // 
            this.path_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.path_textBox.Location = new System.Drawing.Point(9, 47);
            this.path_textBox.Name = "path_textBox";
            this.path_textBox.Size = new System.Drawing.Size(256, 23);
            this.path_textBox.TabIndex = 21;
            // 
            // savePassword_checkBox
            // 
            this.savePassword_checkBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.savePassword_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.savePassword_checkBox.Location = new System.Drawing.Point(9, 120);
            this.savePassword_checkBox.Name = "savePassword_checkBox";
            this.savePassword_checkBox.Size = new System.Drawing.Size(256, 54);
            this.savePassword_checkBox.TabIndex = 22;
            this.savePassword_checkBox.Text = "Save password to database (Insecure! Use it if you store the file in a removable " +
                "storage)";
            this.savePassword_checkBox.UseVisualStyleBackColor = false;
            // 
            // createdKeys_listBox
            // 
            this.createdKeys_listBox.FormattingEnabled = true;
            this.createdKeys_listBox.Location = new System.Drawing.Point(6, 19);
            this.createdKeys_listBox.Name = "createdKeys_listBox";
            this.createdKeys_listBox.Size = new System.Drawing.Size(522, 290);
            this.createdKeys_listBox.TabIndex = 3;
            this.createdKeys_listBox.SelectedIndexChanged += new System.EventHandler(this.createdKeys_listBox_SelectedIndexChanged);
            // 
            // existingKeys_groupBox
            // 
            this.existingKeys_groupBox.Controls.Add(this.createdKeys_listBox);
            this.existingKeys_groupBox.Location = new System.Drawing.Point(285, 9);
            this.existingKeys_groupBox.Name = "existingKeys_groupBox";
            this.existingKeys_groupBox.Size = new System.Drawing.Size(534, 317);
            this.existingKeys_groupBox.TabIndex = 23;
            this.existingKeys_groupBox.TabStop = false;
            this.existingKeys_groupBox.Text = "Created Keys";
            // 
            // EncryptedPasswordFileKeyManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 332);
            this.Controls.Add(this.existingKeys_groupBox);
            this.Controls.Add(this.savePassword_checkBox);
            this.Controls.Add(this.path_textBox);
            this.Controls.Add(this.chooseFile_button);
            this.Controls.Add(this.inverted_checkBox);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.description_textBox);
            this.Controls.Add(this.description_label);
            this.Controls.Add(this.ok_button);
            this.Name = "EncryptedPasswordFileKeyManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password file key";
            this.existingKeys_groupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chooseFile_button;
        private System.Windows.Forms.CheckBox inverted_checkBox;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.TextBox description_textBox;
        private System.Windows.Forms.Label description_label;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.TextBox path_textBox;
        private System.Windows.Forms.CheckBox savePassword_checkBox;
        private System.Windows.Forms.ListBox createdKeys_listBox;
        private System.Windows.Forms.GroupBox existingKeys_groupBox;
    }
}