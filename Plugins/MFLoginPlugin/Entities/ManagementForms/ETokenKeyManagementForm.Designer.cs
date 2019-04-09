namespace pGina.Plugin.MFLoginPlugin.Entities.ManagementForms
{
    partial class ETokenKeyManagementForm
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
            this.name_label = new System.Windows.Forms.Label();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.description_textBox = new System.Windows.Forms.TextBox();
            this.description_label = new System.Windows.Forms.Label();
            this.ok_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.createdKeys_listBox = new System.Windows.Forms.ListBox();
            this.existingKeys_groupBox = new System.Windows.Forms.GroupBox();
            this.existingKeys_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // inverted_checkBox
            // 
            this.inverted_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.inverted_checkBox.Location = new System.Drawing.Point(12, 109);
            this.inverted_checkBox.Name = "inverted_checkBox";
            this.inverted_checkBox.Size = new System.Drawing.Size(256, 30);
            this.inverted_checkBox.TabIndex = 16;
            this.inverted_checkBox.Text = "Invert (token has to be MISSING)";
            this.inverted_checkBox.UseVisualStyleBackColor = true;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.name_label.Location = new System.Drawing.Point(9, 66);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(99, 17);
            this.name_label.TabIndex = 20;
            this.name_label.Text = "eToken name:";
            // 
            // name_textBox
            // 
            this.name_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.name_textBox.Location = new System.Drawing.Point(12, 86);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.ReadOnly = true;
            this.name_textBox.Size = new System.Drawing.Size(256, 23);
            this.name_textBox.TabIndex = 15;
            // 
            // description_textBox
            // 
            this.description_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.description_textBox.Location = new System.Drawing.Point(12, 158);
            this.description_textBox.Multiline = true;
            this.description_textBox.Name = "description_textBox";
            this.description_textBox.Size = new System.Drawing.Size(256, 53);
            this.description_textBox.TabIndex = 17;
            this.description_textBox.Text = "eToken";
            // 
            // description_label
            // 
            this.description_label.AutoSize = true;
            this.description_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.description_label.Location = new System.Drawing.Point(13, 137);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(83, 17);
            this.description_label.TabIndex = 19;
            this.description_label.Text = "Description:";
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(12, 217);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(256, 23);
            this.ok_button.TabIndex = 18;
            this.ok_button.Text = "Set";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 57);
            this.label1.TabIndex = 21;
            this.label1.Text = "Warning:\r\n* eToken client has to be installed and running\r\n* Do not rely on this " +
                "key: you should have another way to log in if eToken software fails";
            // 
            // createdKeys_listBox
            // 
            this.createdKeys_listBox.FormattingEnabled = true;
            this.createdKeys_listBox.Location = new System.Drawing.Point(6, 19);
            this.createdKeys_listBox.Name = "createdKeys_listBox";
            this.createdKeys_listBox.Size = new System.Drawing.Size(506, 199);
            this.createdKeys_listBox.TabIndex = 3;
            this.createdKeys_listBox.SelectedIndexChanged += new System.EventHandler(this.createdKeys_listBox_SelectedIndexChanged);
            // 
            // existingKeys_groupBox
            // 
            this.existingKeys_groupBox.Controls.Add(this.createdKeys_listBox);
            this.existingKeys_groupBox.Location = new System.Drawing.Point(274, 12);
            this.existingKeys_groupBox.Name = "existingKeys_groupBox";
            this.existingKeys_groupBox.Size = new System.Drawing.Size(518, 228);
            this.existingKeys_groupBox.TabIndex = 22;
            this.existingKeys_groupBox.TabStop = false;
            this.existingKeys_groupBox.Text = "Created Keys";
            // 
            // ETokenKeyManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 251);
            this.Controls.Add(this.existingKeys_groupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inverted_checkBox);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.description_textBox);
            this.Controls.Add(this.description_label);
            this.Controls.Add(this.ok_button);
            this.Name = "ETokenKeyManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eToken";
            this.existingKeys_groupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion
		private System.Windows.Forms.CheckBox inverted_checkBox;
		private System.Windows.Forms.Label name_label;
		private System.Windows.Forms.TextBox name_textBox;
		private System.Windows.Forms.TextBox description_textBox;
		private System.Windows.Forms.Label description_label;
		private System.Windows.Forms.Button ok_button;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox createdKeys_listBox;
        private System.Windows.Forms.GroupBox existingKeys_groupBox;
	}
}