namespace pGina.Plugin.MFLoginPlugin
{
    partial class FirstRun
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
			this.buttonContinue_local = new System.Windows.Forms.Button();
			this.buttonContinue_network = new System.Windows.Forms.Button();
			this.saveDBDialog = new System.Windows.Forms.SaveFileDialog();
			this.serverPath_textbox = new System.Windows.Forms.TextBox();
			this.serverPath_label = new System.Windows.Forms.Label();
			this.passwordField = new System.Windows.Forms.TextBox();
			this.password_label = new System.Windows.Forms.Label();
			this.changePath_button = new System.Windows.Forms.Button();
			this.defaultPath_button = new System.Windows.Forms.Button();
			this.dbPath_textBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// buttonContinue_local
			// 
			this.buttonContinue_local.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.buttonContinue_local.Dock = System.Windows.Forms.DockStyle.Left;
			this.buttonContinue_local.Location = new System.Drawing.Point(0, 0);
			this.buttonContinue_local.MinimumSize = new System.Drawing.Size(30, 0);
			this.buttonContinue_local.Name = "buttonContinue_local";
			this.buttonContinue_local.Size = new System.Drawing.Size(350, 146);
			this.buttonContinue_local.TabIndex = 0;
			this.buttonContinue_local.Text = "Continue locally";
			this.buttonContinue_local.UseVisualStyleBackColor = true;
			this.buttonContinue_local.Click += new System.EventHandler(this.buttonContinue_local_Click);
			// 
			// buttonContinue_network
			// 
			this.buttonContinue_network.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.buttonContinue_network.Dock = System.Windows.Forms.DockStyle.Right;
			this.buttonContinue_network.Location = new System.Drawing.Point(360, 0);
			this.buttonContinue_network.MinimumSize = new System.Drawing.Size(30, 0);
			this.buttonContinue_network.Name = "buttonContinue_network";
			this.buttonContinue_network.Size = new System.Drawing.Size(350, 146);
			this.buttonContinue_network.TabIndex = 1;
			this.buttonContinue_network.Text = "Join network";
			this.buttonContinue_network.UseVisualStyleBackColor = true;
			this.buttonContinue_network.Click += new System.EventHandler(this.buttonContinue_network_Click);
			// 
			// saveDBDialog
			// 
			this.saveDBDialog.DefaultExt = "db";
			this.saveDBDialog.Filter = "Database files|*.db";
			this.saveDBDialog.OverwritePrompt = false;
			this.saveDBDialog.SupportMultiDottedExtensions = true;
			// 
			// serverPath_textbox
			// 
			this.serverPath_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.serverPath_textbox.Location = new System.Drawing.Point(32, 62);
			this.serverPath_textbox.Name = "serverPath_textbox";
			this.serverPath_textbox.Size = new System.Drawing.Size(305, 31);
			this.serverPath_textbox.TabIndex = 2;
			// 
			// serverPath_label
			// 
			this.serverPath_label.AutoSize = true;
			this.serverPath_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.serverPath_label.Location = new System.Drawing.Point(63, 24);
			this.serverPath_label.Name = "serverPath_label";
			this.serverPath_label.Size = new System.Drawing.Size(241, 25);
			this.serverPath_label.TabIndex = 3;
			this.serverPath_label.Text = "Path to database server";
			// 
			// passwordField
			// 
			this.passwordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.passwordField.Location = new System.Drawing.Point(380, 36);
			this.passwordField.Name = "passwordField";
			this.passwordField.Size = new System.Drawing.Size(309, 29);
			this.passwordField.TabIndex = 4;
			// 
			// password_label
			// 
			this.password_label.AutoSize = true;
			this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
			this.password_label.Location = new System.Drawing.Point(376, 9);
			this.password_label.Name = "password_label";
			this.password_label.Size = new System.Drawing.Size(92, 24);
			this.password_label.TabIndex = 5;
			this.password_label.Text = "Password";
			// 
			// changePath_button
			// 
			this.changePath_button.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.changePath_button.Location = new System.Drawing.Point(380, 79);
			this.changePath_button.Name = "changePath_button";
			this.changePath_button.Size = new System.Drawing.Size(158, 31);
			this.changePath_button.TabIndex = 6;
			this.changePath_button.Text = "Change database path";
			this.changePath_button.UseVisualStyleBackColor = false;
			this.changePath_button.Click += new System.EventHandler(this.changePath_button_Click);
			// 
			// defaultPath_button
			// 
			this.defaultPath_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.defaultPath_button.Location = new System.Drawing.Point(544, 79);
			this.defaultPath_button.Name = "defaultPath_button";
			this.defaultPath_button.Size = new System.Drawing.Size(158, 31);
			this.defaultPath_button.TabIndex = 7;
			this.defaultPath_button.Text = "Use default path (default)";
			this.defaultPath_button.UseVisualStyleBackColor = false;
			this.defaultPath_button.Click += new System.EventHandler(this.defaultPath_button_Click);
			// 
			// dbPath_textBox
			// 
			this.dbPath_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.dbPath_textBox.Location = new System.Drawing.Point(380, 117);
			this.dbPath_textBox.Name = "dbPath_textBox";
			this.dbPath_textBox.Size = new System.Drawing.Size(318, 23);
			this.dbPath_textBox.TabIndex = 9;
			this.dbPath_textBox.Text = "MFLoginDB.db";
			// 
			// FirstRun
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(710, 146);
			this.Controls.Add(this.buttonContinue_network);
			this.Controls.Add(this.dbPath_textBox);
			this.Controls.Add(this.buttonContinue_local);
			this.Controls.Add(this.defaultPath_button);
			this.Controls.Add(this.changePath_button);
			this.Controls.Add(this.password_label);
			this.Controls.Add(this.passwordField);
			this.Controls.Add(this.serverPath_label);
			this.Controls.Add(this.serverPath_textbox);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FirstRun";
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Set up the plugin";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonContinue_local;
        private System.Windows.Forms.Button buttonContinue_network;
        private System.Windows.Forms.SaveFileDialog saveDBDialog;
        private System.Windows.Forms.TextBox serverPath_textbox;
        private System.Windows.Forms.Label serverPath_label;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Button changePath_button;
        private System.Windows.Forms.Button defaultPath_button;
		private System.Windows.Forms.TextBox dbPath_textBox;
	}
}