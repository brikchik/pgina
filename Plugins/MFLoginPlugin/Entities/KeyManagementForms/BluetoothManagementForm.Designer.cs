﻿namespace pGina.Plugin.MFLoginPlugin.Entities.KeyManagementForms
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
			this.description_textBox = new System.Windows.Forms.TextBox();
			this.description_label = new System.Windows.Forms.Label();
			this.ok_button = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// description_textBox
			// 
			this.description_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.description_textBox.Location = new System.Drawing.Point(16, 167);
			this.description_textBox.Multiline = true;
			this.description_textBox.Name = "description_textBox";
			this.description_textBox.Size = new System.Drawing.Size(142, 53);
			this.description_textBox.TabIndex = 5;
			this.description_textBox.Text = "BluetoothDevice N";
			this.description_textBox.TextChanged += new System.EventHandler(this.description_textBox_TextChanged);
			// 
			// description_label
			// 
			this.description_label.AutoSize = true;
			this.description_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.description_label.Location = new System.Drawing.Point(13, 146);
			this.description_label.Name = "description_label";
			this.description_label.Size = new System.Drawing.Size(79, 17);
			this.description_label.TabIndex = 4;
			this.description_label.Text = "Description";
			this.description_label.Click += new System.EventHandler(this.description_label_Click);
			// 
			// ok_button
			// 
			this.ok_button.Location = new System.Drawing.Point(139, 226);
			this.ok_button.Name = "ok_button";
			this.ok_button.Size = new System.Drawing.Size(133, 23);
			this.ok_button.TabIndex = 3;
			this.ok_button.Text = "Set";
			this.ok_button.UseVisualStyleBackColor = true;
			this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
			// 
			// BluetoothManagementForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.description_textBox);
			this.Controls.Add(this.description_label);
			this.Controls.Add(this.ok_button);
			this.Name = "BluetoothManagementForm";
			this.Text = "BluetoothManagementForm";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.TextBox description_textBox;
		private System.Windows.Forms.Label description_label;
		private System.Windows.Forms.Button ok_button;
	}
}