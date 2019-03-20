namespace pGina.Plugin.MFLoginPlugin.Entities.ManagementForms
{
	partial class ConnectedDeviceManagementForm
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
            this.ok_button = new System.Windows.Forms.Button();
            this.description_label = new System.Windows.Forms.Label();
            this.description_textBox = new System.Windows.Forms.TextBox();
            this.serial_textBox = new System.Windows.Forms.TextBox();
            this.serial_label = new System.Windows.Forms.Label();
            this.inverted_checkBox = new System.Windows.Forms.CheckBox();
            this.newKey_groupBox = new System.Windows.Forms.GroupBox();
            this.serialsListBox_label = new System.Windows.Forms.Label();
            this.reset_button = new System.Windows.Forms.Button();
            this.detectKey_button = new System.Windows.Forms.Button();
            this.serials_listBox = new System.Windows.Forms.ListBox();
            this.existingKeys_groupBox = new System.Windows.Forms.GroupBox();
            this.createdKeys_listBox = new System.Windows.Forms.ListBox();
            this.newKey_groupBox.SuspendLayout();
            this.existingKeys_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(13, 372);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(256, 23);
            this.ok_button.TabIndex = 0;
            this.ok_button.Text = "Set";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // description_label
            // 
            this.description_label.AutoSize = true;
            this.description_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.description_label.Location = new System.Drawing.Point(10, 292);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(83, 17);
            this.description_label.TabIndex = 1;
            this.description_label.Text = "Description:";
            // 
            // description_textBox
            // 
            this.description_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.description_textBox.Location = new System.Drawing.Point(13, 313);
            this.description_textBox.Multiline = true;
            this.description_textBox.Name = "description_textBox";
            this.description_textBox.Size = new System.Drawing.Size(256, 53);
            this.description_textBox.TabIndex = 2;
            this.description_textBox.Text = "ConnectedDevice N";
            this.description_textBox.TextChanged += new System.EventHandler(this.description_textBox_TextChanged);
            // 
            // serial_textBox
            // 
            this.serial_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.serial_textBox.Location = new System.Drawing.Point(13, 228);
            this.serial_textBox.Name = "serial_textBox";
            this.serial_textBox.Size = new System.Drawing.Size(256, 23);
            this.serial_textBox.TabIndex = 3;
            this.serial_textBox.TextChanged += new System.EventHandler(this.serial_textBox_TextChanged);
            // 
            // serial_label
            // 
            this.serial_label.AutoSize = true;
            this.serial_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.serial_label.Location = new System.Drawing.Point(10, 208);
            this.serial_label.Name = "serial_label";
            this.serial_label.Size = new System.Drawing.Size(93, 17);
            this.serial_label.TabIndex = 4;
            this.serial_label.Text = "Device serial:";
            // 
            // inverted_checkBox
            // 
            this.inverted_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.inverted_checkBox.Location = new System.Drawing.Point(13, 257);
            this.inverted_checkBox.Name = "inverted_checkBox";
            this.inverted_checkBox.Size = new System.Drawing.Size(256, 32);
            this.inverted_checkBox.TabIndex = 8;
            this.inverted_checkBox.Text = "Invert (Device has to be MISSING)";
            this.inverted_checkBox.UseVisualStyleBackColor = true;
            // 
            // newKey_groupBox
            // 
            this.newKey_groupBox.Controls.Add(this.serialsListBox_label);
            this.newKey_groupBox.Controls.Add(this.reset_button);
            this.newKey_groupBox.Controls.Add(this.detectKey_button);
            this.newKey_groupBox.Controls.Add(this.serials_listBox);
            this.newKey_groupBox.Location = new System.Drawing.Point(13, 13);
            this.newKey_groupBox.Name = "newKey_groupBox";
            this.newKey_groupBox.Size = new System.Drawing.Size(547, 192);
            this.newKey_groupBox.TabIndex = 9;
            this.newKey_groupBox.TabStop = false;
            this.newKey_groupBox.Text = "New key";
            // 
            // serialsListBox_label
            // 
            this.serialsListBox_label.AutoSize = true;
            this.serialsListBox_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.serialsListBox_label.Location = new System.Drawing.Point(318, 16);
            this.serialsListBox_label.Name = "serialsListBox_label";
            this.serialsListBox_label.Size = new System.Drawing.Size(121, 17);
            this.serialsListBox_label.TabIndex = 5;
            this.serialsListBox_label.Text = "Pick device serial:";
            // 
            // reset_button
            // 
            this.reset_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reset_button.Location = new System.Drawing.Point(7, 20);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(75, 160);
            this.reset_button.TabIndex = 2;
            this.reset_button.Text = "RESET";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // detectKey_button
            // 
            this.detectKey_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.detectKey_button.Location = new System.Drawing.Point(88, 20);
            this.detectKey_button.Name = "detectKey_button";
            this.detectKey_button.Size = new System.Drawing.Size(224, 160);
            this.detectKey_button.TabIndex = 1;
            this.detectKey_button.Text = "Insert your key and press this button";
            this.detectKey_button.UseVisualStyleBackColor = true;
            this.detectKey_button.Click += new System.EventHandler(this.detectKey_button_Click);
            // 
            // serials_listBox
            // 
            this.serials_listBox.FormattingEnabled = true;
            this.serials_listBox.Location = new System.Drawing.Point(321, 33);
            this.serials_listBox.Name = "serials_listBox";
            this.serials_listBox.Size = new System.Drawing.Size(220, 147);
            this.serials_listBox.TabIndex = 0;
            this.serials_listBox.SelectedIndexChanged += new System.EventHandler(this.serials_listBox_SelectedIndexChanged);
            // 
            // existingKeys_groupBox
            // 
            this.existingKeys_groupBox.Controls.Add(this.createdKeys_listBox);
            this.existingKeys_groupBox.Location = new System.Drawing.Point(285, 208);
            this.existingKeys_groupBox.Name = "existingKeys_groupBox";
            this.existingKeys_groupBox.Size = new System.Drawing.Size(275, 187);
            this.existingKeys_groupBox.TabIndex = 10;
            this.existingKeys_groupBox.TabStop = false;
            this.existingKeys_groupBox.Text = "Created Keys";
            // 
            // createdKeys_listBox
            // 
            this.createdKeys_listBox.FormattingEnabled = true;
            this.createdKeys_listBox.Location = new System.Drawing.Point(6, 19);
            this.createdKeys_listBox.Name = "createdKeys_listBox";
            this.createdKeys_listBox.Size = new System.Drawing.Size(263, 160);
            this.createdKeys_listBox.TabIndex = 1;
            this.createdKeys_listBox.SelectedIndexChanged += new System.EventHandler(this.createdKeys_listBox_SelectedIndexChanged);
            // 
            // ConnectedDeviceManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 406);
            this.Controls.Add(this.existingKeys_groupBox);
            this.Controls.Add(this.newKey_groupBox);
            this.Controls.Add(this.inverted_checkBox);
            this.Controls.Add(this.serial_label);
            this.Controls.Add(this.serial_textBox);
            this.Controls.Add(this.description_textBox);
            this.Controls.Add(this.description_label);
            this.Controls.Add(this.ok_button);
            this.Name = "ConnectedDeviceManagementForm";
            this.Text = "Connected Device";
            this.newKey_groupBox.ResumeLayout(false);
            this.newKey_groupBox.PerformLayout();
            this.existingKeys_groupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button ok_button;
		private System.Windows.Forms.Label description_label;
		private System.Windows.Forms.TextBox description_textBox;
		private System.Windows.Forms.TextBox serial_textBox;
		private System.Windows.Forms.Label serial_label;
		private System.Windows.Forms.CheckBox inverted_checkBox;
		private System.Windows.Forms.GroupBox newKey_groupBox;
		private System.Windows.Forms.Button reset_button;
		private System.Windows.Forms.Button detectKey_button;
		private System.Windows.Forms.ListBox serials_listBox;
		private System.Windows.Forms.Label serialsListBox_label;
		private System.Windows.Forms.GroupBox existingKeys_groupBox;
		private System.Windows.Forms.ListBox createdKeys_listBox;
	}
}