namespace pGina.Plugin.MFLoginPlugin.Entities.ManagementForms
{
	partial class HttpRequestManagementForm
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
            this.address_label = new System.Windows.Forms.Label();
            this.address_textBox = new System.Windows.Forms.TextBox();
            this.description_textBox = new System.Windows.Forms.TextBox();
            this.description_label = new System.Windows.Forms.Label();
            this.ok_button = new System.Windows.Forms.Button();
            this.response_label = new System.Windows.Forms.Label();
            this.response_textBox = new System.Windows.Forms.TextBox();
            this.setAnyway_button = new System.Windows.Forms.Button();
            this.receivedResponse_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.createdKeys_listBox = new System.Windows.Forms.ListBox();
            this.existingKeys_groupBox = new System.Windows.Forms.GroupBox();
            this.existingKeys_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // inverted_checkBox
            // 
            this.inverted_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.inverted_checkBox.Location = new System.Drawing.Point(12, 152);
            this.inverted_checkBox.Name = "inverted_checkBox";
            this.inverted_checkBox.Size = new System.Drawing.Size(342, 29);
            this.inverted_checkBox.TabIndex = 3;
            this.inverted_checkBox.Text = "Invert (Response has to be INCORRECT)";
            this.inverted_checkBox.UseVisualStyleBackColor = true;
            // 
            // address_label
            // 
            this.address_label.AutoSize = true;
            this.address_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.address_label.Location = new System.Drawing.Point(9, 9);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(106, 17);
            this.address_label.TabIndex = 13;
            this.address_label.Text = "Http(s) address";
            // 
            // address_textBox
            // 
            this.address_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.address_textBox.Location = new System.Drawing.Point(12, 29);
            this.address_textBox.Multiline = true;
            this.address_textBox.Name = "address_textBox";
            this.address_textBox.Size = new System.Drawing.Size(532, 69);
            this.address_textBox.TabIndex = 1;
            this.address_textBox.TextChanged += new System.EventHandler(this.address_textBox_TextChanged);
            // 
            // description_textBox
            // 
            this.description_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.description_textBox.Location = new System.Drawing.Point(12, 204);
            this.description_textBox.Multiline = true;
            this.description_textBox.Name = "description_textBox";
            this.description_textBox.Size = new System.Drawing.Size(532, 31);
            this.description_textBox.TabIndex = 4;
            // 
            // description_label
            // 
            this.description_label.AutoSize = true;
            this.description_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.description_label.Location = new System.Drawing.Point(9, 184);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(83, 17);
            this.description_label.TabIndex = 10;
            this.description_label.Text = "Description:";
            // 
            // ok_button
            // 
            this.ok_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ok_button.Location = new System.Drawing.Point(12, 241);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(532, 48);
            this.ok_button.TabIndex = 5;
            this.ok_button.Text = "Check and set key";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // response_label
            // 
            this.response_label.AutoSize = true;
            this.response_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.response_label.Location = new System.Drawing.Point(9, 101);
            this.response_label.Name = "response_label";
            this.response_label.Size = new System.Drawing.Size(72, 17);
            this.response_label.TabIndex = 16;
            this.response_label.Text = "Response";
            // 
            // response_textBox
            // 
            this.response_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.response_textBox.Location = new System.Drawing.Point(12, 121);
            this.response_textBox.Name = "response_textBox";
            this.response_textBox.Size = new System.Drawing.Size(532, 23);
            this.response_textBox.TabIndex = 2;
            this.response_textBox.TextChanged += new System.EventHandler(this.response_textBox_TextChanged);
            // 
            // setAnyway_button
            // 
            this.setAnyway_button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.setAnyway_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.setAnyway_button.Location = new System.Drawing.Point(12, 392);
            this.setAnyway_button.Name = "setAnyway_button";
            this.setAnyway_button.Size = new System.Drawing.Size(532, 32);
            this.setAnyway_button.TabIndex = 7;
            this.setAnyway_button.Text = "Set the key anyway";
            this.setAnyway_button.UseVisualStyleBackColor = false;
            this.setAnyway_button.Visible = false;
            this.setAnyway_button.Click += new System.EventHandler(this.setAnyway_button_Click);
            // 
            // receivedResponse_textBox
            // 
            this.receivedResponse_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.receivedResponse_textBox.Location = new System.Drawing.Point(12, 317);
            this.receivedResponse_textBox.Multiline = true;
            this.receivedResponse_textBox.Name = "receivedResponse_textBox";
            this.receivedResponse_textBox.ReadOnly = true;
            this.receivedResponse_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.receivedResponse_textBox.Size = new System.Drawing.Size(532, 69);
            this.receivedResponse_textBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "RECEIVED RESPONSE:";
            // 
            // createdKeys_listBox
            // 
            this.createdKeys_listBox.FormattingEnabled = true;
            this.createdKeys_listBox.Location = new System.Drawing.Point(6, 19);
            this.createdKeys_listBox.Name = "createdKeys_listBox";
            this.createdKeys_listBox.Size = new System.Drawing.Size(343, 381);
            this.createdKeys_listBox.TabIndex = 3;
            this.createdKeys_listBox.SelectedIndexChanged += new System.EventHandler(this.createdKeys_listBox_SelectedIndexChanged);
            // 
            // existingKeys_groupBox
            // 
            this.existingKeys_groupBox.Controls.Add(this.createdKeys_listBox);
            this.existingKeys_groupBox.Location = new System.Drawing.Point(550, 12);
            this.existingKeys_groupBox.Name = "existingKeys_groupBox";
            this.existingKeys_groupBox.Size = new System.Drawing.Size(355, 412);
            this.existingKeys_groupBox.TabIndex = 23;
            this.existingKeys_groupBox.TabStop = false;
            this.existingKeys_groupBox.Text = "Created Keys";
            // 
            // HttpRequestManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 436);
            this.Controls.Add(this.existingKeys_groupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.receivedResponse_textBox);
            this.Controls.Add(this.setAnyway_button);
            this.Controls.Add(this.response_label);
            this.Controls.Add(this.response_textBox);
            this.Controls.Add(this.inverted_checkBox);
            this.Controls.Add(this.address_label);
            this.Controls.Add(this.address_textBox);
            this.Controls.Add(this.description_textBox);
            this.Controls.Add(this.description_label);
            this.Controls.Add(this.ok_button);
            this.Name = "HttpRequestManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Http request";
            this.existingKeys_groupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox inverted_checkBox;
		private System.Windows.Forms.Label address_label;
		private System.Windows.Forms.TextBox address_textBox;
		private System.Windows.Forms.TextBox description_textBox;
		private System.Windows.Forms.Label description_label;
		private System.Windows.Forms.Button ok_button;
		private System.Windows.Forms.Label response_label;
		private System.Windows.Forms.TextBox response_textBox;
		private System.Windows.Forms.Button setAnyway_button;
		private System.Windows.Forms.TextBox receivedResponse_textBox;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox createdKeys_listBox;
        private System.Windows.Forms.GroupBox existingKeys_groupBox;
	}
}