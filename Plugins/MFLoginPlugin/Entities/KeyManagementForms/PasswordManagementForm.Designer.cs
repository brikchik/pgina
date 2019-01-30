namespace pGina.Plugin.MFLoginPlugin.Entities.KeyManagementForms
{
    partial class PasswordManagementForm
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
            this.password_textBox1 = new System.Windows.Forms.TextBox();
            this.password_textBox2 = new System.Windows.Forms.TextBox();
            this.create_password_button = new System.Windows.Forms.Button();
            this.newPass_label = new System.Windows.Forms.Label();
            this.temp_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // password_textBox1
            // 
            this.password_textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.password_textBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.password_textBox1.Location = new System.Drawing.Point(26, 33);
            this.password_textBox1.MaxLength = 128;
            this.password_textBox1.Name = "password_textBox1";
            this.password_textBox1.PasswordChar = '*';
            this.password_textBox1.Size = new System.Drawing.Size(242, 29);
            this.password_textBox1.TabIndex = 0;
            this.password_textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password_textBox1.UseSystemPasswordChar = true;
            this.password_textBox1.WordWrap = false;
            // 
            // password_textBox2
            // 
            this.password_textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.password_textBox2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.password_textBox2.Location = new System.Drawing.Point(26, 70);
            this.password_textBox2.MaxLength = 128;
            this.password_textBox2.Name = "password_textBox2";
            this.password_textBox2.PasswordChar = '*';
            this.password_textBox2.Size = new System.Drawing.Size(242, 29);
            this.password_textBox2.TabIndex = 1;
            this.password_textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password_textBox2.UseSystemPasswordChar = true;
            this.password_textBox2.WordWrap = false;
            // 
            // create_password_button
            // 
            this.create_password_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.create_password_button.Location = new System.Drawing.Point(25, 105);
            this.create_password_button.Name = "create_password_button";
            this.create_password_button.Size = new System.Drawing.Size(243, 48);
            this.create_password_button.TabIndex = 2;
            this.create_password_button.Text = "Create password";
            this.create_password_button.UseVisualStyleBackColor = true;
            this.create_password_button.Click += new System.EventHandler(this.create_password_button_Click);
            // 
            // newPass_label
            // 
            this.newPass_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.newPass_label.Location = new System.Drawing.Point(22, 6);
            this.newPass_label.Name = "newPass_label";
            this.newPass_label.Size = new System.Drawing.Size(243, 23);
            this.newPass_label.TabIndex = 3;
            this.newPass_label.Text = "Enter password 2 times";
            this.newPass_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // temp_label
            // 
            this.temp_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.temp_label.Location = new System.Drawing.Point(25, 156);
            this.temp_label.Name = "temp_label";
            this.temp_label.Size = new System.Drawing.Size(240, 24);
            this.temp_label.TabIndex = 4;
            this.temp_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 185);
            this.Controls.Add(this.temp_label);
            this.Controls.Add(this.newPass_label);
            this.Controls.Add(this.create_password_button);
            this.Controls.Add(this.password_textBox2);
            this.Controls.Add(this.password_textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "PasswordManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox password_textBox1;
        private System.Windows.Forms.TextBox password_textBox2;
        private System.Windows.Forms.Button create_password_button;
        private System.Windows.Forms.Label newPass_label;
        private System.Windows.Forms.Label temp_label;
    }
}