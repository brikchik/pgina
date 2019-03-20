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
            this.BTControl_groupBox = new System.Windows.Forms.GroupBox();
            this.BTDevices_groupBox = new System.Windows.Forms.GroupBox();
            this.searchBTDevices_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inverted_checkBox
            // 
            this.inverted_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.inverted_checkBox.Location = new System.Drawing.Point(12, 218);
            this.inverted_checkBox.Name = "inverted_checkBox";
            this.inverted_checkBox.Size = new System.Drawing.Size(256, 30);
            this.inverted_checkBox.TabIndex = 14;
            this.inverted_checkBox.Text = "Invert (Device has to be MISSING)";
            this.inverted_checkBox.UseVisualStyleBackColor = true;
            // 
            // serial_label
            // 
            this.serial_label.AutoSize = true;
            this.serial_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.serial_label.Location = new System.Drawing.Point(9, 171);
            this.serial_label.Name = "serial_label";
            this.serial_label.Size = new System.Drawing.Size(110, 17);
            this.serial_label.TabIndex = 13;
            this.serial_label.Text = "Device address:";
            // 
            // serial_textBox
            // 
            this.serial_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.serial_textBox.Location = new System.Drawing.Point(12, 191);
            this.serial_textBox.Name = "serial_textBox";
            this.serial_textBox.Size = new System.Drawing.Size(256, 23);
            this.serial_textBox.TabIndex = 12;
            this.serial_textBox.TextChanged += new System.EventHandler(this.serial_textBox_TextChanged);
            // 
            // description_textBox
            // 
            this.description_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.description_textBox.Location = new System.Drawing.Point(12, 272);
            this.description_textBox.Multiline = true;
            this.description_textBox.Name = "description_textBox";
            this.description_textBox.Size = new System.Drawing.Size(256, 53);
            this.description_textBox.TabIndex = 11;
            this.description_textBox.Text = "BluetoothDevice N";
            // 
            // description_label
            // 
            this.description_label.AutoSize = true;
            this.description_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.description_label.Location = new System.Drawing.Point(9, 251);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(83, 17);
            this.description_label.TabIndex = 10;
            this.description_label.Text = "Description:";
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(12, 331);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(256, 23);
            this.ok_button.TabIndex = 9;
            this.ok_button.Text = "Set";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // BTControl_groupBox
            // 
            this.BTControl_groupBox.Location = new System.Drawing.Point(13, 13);
            this.BTControl_groupBox.Name = "BTControl_groupBox";
            this.BTControl_groupBox.Size = new System.Drawing.Size(255, 129);
            this.BTControl_groupBox.TabIndex = 15;
            this.BTControl_groupBox.TabStop = false;
            this.BTControl_groupBox.Text = "Bluetooth control";
            // 
            // BTDevices_groupBox
            // 
            this.BTDevices_groupBox.Location = new System.Drawing.Point(291, 171);
            this.BTDevices_groupBox.Name = "BTDevices_groupBox";
            this.BTDevices_groupBox.Size = new System.Drawing.Size(217, 183);
            this.BTDevices_groupBox.TabIndex = 16;
            this.BTDevices_groupBox.TabStop = false;
            this.BTDevices_groupBox.Text = "Bluetooth devices in range";
            // 
            // searchBTDevices_button
            // 
            this.searchBTDevices_button.Location = new System.Drawing.Point(291, 13);
            this.searchBTDevices_button.Name = "searchBTDevices_button";
            this.searchBTDevices_button.Size = new System.Drawing.Size(217, 42);
            this.searchBTDevices_button.TabIndex = 17;
            this.searchBTDevices_button.Text = "Search for devices in range";
            this.searchBTDevices_button.UseVisualStyleBackColor = true;
            // 
            // BluetoothManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 365);
            this.Controls.Add(this.searchBTDevices_button);
            this.Controls.Add(this.BTDevices_groupBox);
            this.Controls.Add(this.BTControl_groupBox);
            this.Controls.Add(this.inverted_checkBox);
            this.Controls.Add(this.serial_label);
            this.Controls.Add(this.serial_textBox);
            this.Controls.Add(this.description_textBox);
            this.Controls.Add(this.description_label);
            this.Controls.Add(this.ok_button);
            this.Name = "BluetoothManagementForm";
            this.Text = "BluetoothManagementForm";
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
        private System.Windows.Forms.GroupBox BTControl_groupBox;
        private System.Windows.Forms.GroupBox BTDevices_groupBox;
        private System.Windows.Forms.Button searchBTDevices_button;
	}
}