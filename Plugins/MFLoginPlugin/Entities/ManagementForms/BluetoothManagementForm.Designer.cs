namespace pGina.Plugin.MFLoginPlugin.Entities.ManagementForms
{
    partial class BluetoothManagementForm
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
            this.inverted_checkBox = new System.Windows.Forms.CheckBox();
            this.serial_label = new System.Windows.Forms.Label();
            this.serial_textBox = new System.Windows.Forms.TextBox();
            this.description_textBox = new System.Windows.Forms.TextBox();
            this.description_label = new System.Windows.Forms.Label();
            this.ok_button = new System.Windows.Forms.Button();
            this.searchBTDevices_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inverted_checkBox
            // 
            this.inverted_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.inverted_checkBox.Location = new System.Drawing.Point(12, 104);
            this.inverted_checkBox.Name = "inverted_checkBox";
            this.inverted_checkBox.Size = new System.Drawing.Size(256, 30);
            this.inverted_checkBox.TabIndex = 7;
            this.inverted_checkBox.Text = "Invert (Device has to be MISSING)";
            this.inverted_checkBox.UseVisualStyleBackColor = true;
            this.inverted_checkBox.CheckedChanged += new System.EventHandler(this.inverted_checkBox_CheckedChanged);
            // 
            // serial_label
            // 
            this.serial_label.AutoSize = true;
            this.serial_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.serial_label.Location = new System.Drawing.Point(9, 57);
            this.serial_label.Name = "serial_label";
            this.serial_label.Size = new System.Drawing.Size(110, 17);
            this.serial_label.TabIndex = 13;
            this.serial_label.Text = "Device address:";
            this.serial_label.Click += new System.EventHandler(this.serial_label_Click);
            // 
            // serial_textBox
            // 
            this.serial_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.serial_textBox.Location = new System.Drawing.Point(12, 77);
            this.serial_textBox.Name = "serial_textBox";
            this.serial_textBox.Size = new System.Drawing.Size(256, 23);
            this.serial_textBox.TabIndex = 6;
            this.serial_textBox.TextChanged += new System.EventHandler(this.serial_textBox_TextChanged);
            // 
            // description_textBox
            // 
            this.description_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.description_textBox.Location = new System.Drawing.Point(12, 158);
            this.description_textBox.Multiline = true;
            this.description_textBox.Name = "description_textBox";
            this.description_textBox.Size = new System.Drawing.Size(256, 53);
            this.description_textBox.TabIndex = 8;
            this.description_textBox.Text = "BluetoothDevice N";
            this.description_textBox.TextChanged += new System.EventHandler(this.description_textBox_TextChanged_1);
            // 
            // description_label
            // 
            this.description_label.AutoSize = true;
            this.description_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.description_label.Location = new System.Drawing.Point(13, 137);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(83, 17);
            this.description_label.TabIndex = 10;
            this.description_label.Text = "Description:";
            this.description_label.Click += new System.EventHandler(this.description_label_Click_1);
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(12, 217);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(256, 23);
            this.ok_button.TabIndex = 9;
            this.ok_button.Text = "Set";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // searchBTDevices_button
            // 
            this.searchBTDevices_button.Location = new System.Drawing.Point(12, 12);
            this.searchBTDevices_button.Name = "searchBTDevices_button";
            this.searchBTDevices_button.Size = new System.Drawing.Size(256, 42);
            this.searchBTDevices_button.TabIndex = 3;
            this.searchBTDevices_button.Text = "Search for devices in range";
            this.searchBTDevices_button.UseVisualStyleBackColor = true;
            this.searchBTDevices_button.Click += new System.EventHandler(this.searchBTDevices_button_Click);
            // 
            // BluetoothManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 246);
            this.Controls.Add(this.searchBTDevices_button);
            this.Controls.Add(this.inverted_checkBox);
            this.Controls.Add(this.serial_label);
            this.Controls.Add(this.serial_textBox);
            this.Controls.Add(this.description_textBox);
            this.Controls.Add(this.description_label);
            this.Controls.Add(this.ok_button);
            this.Name = "BluetoothManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bluetooth key management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.CheckBox inverted_checkBox;
		private System.Windows.Forms.Label serial_label;
		private System.Windows.Forms.TextBox serial_textBox;
		private System.Windows.Forms.TextBox description_textBox;
		private System.Windows.Forms.Label description_label;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Button searchBTDevices_button;
	}
}