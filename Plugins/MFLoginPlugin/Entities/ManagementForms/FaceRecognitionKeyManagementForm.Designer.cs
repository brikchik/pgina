namespace pGina.Plugin.MFLoginPlugin.Entities.ManagementForms
{
    partial class FaceRecognitionKeyManagementForm
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
            this.path_label = new System.Windows.Forms.Label();
            this.serial_textBox = new System.Windows.Forms.TextBox();
            this.description_textBox = new System.Windows.Forms.TextBox();
            this.description_label = new System.Windows.Forms.Label();
            this.ok_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.createdKeys_listBox = new System.Windows.Forms.ListBox();
            this.existingKeys_groupBox = new System.Windows.Forms.GroupBox();
            this.keyConfig_groupBox = new System.Windows.Forms.GroupBox();
            this.sensivity_label = new System.Windows.Forms.Label();
            this.sensivity_trackBar = new System.Windows.Forms.TrackBar();
            this.testKey_button = new System.Windows.Forms.Button();
            this.rightEyeBlink_checkBox = new System.Windows.Forms.CheckBox();
            this.leftEyeBlink_checkBox = new System.Windows.Forms.CheckBox();
            this.blink_checkBox = new System.Windows.Forms.CheckBox();
            this.adFace_button = new System.Windows.Forms.Button();
            this.registeredFaces_listView = new System.Windows.Forms.ListView();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.existingKeys_groupBox.SuspendLayout();
            this.keyConfig_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sensivity_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // inverted_checkBox
            // 
            this.inverted_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.inverted_checkBox.Location = new System.Drawing.Point(13, 373);
            this.inverted_checkBox.Name = "inverted_checkBox";
            this.inverted_checkBox.Size = new System.Drawing.Size(273, 45);
            this.inverted_checkBox.TabIndex = 16;
            this.inverted_checkBox.Text = "Invert (recognition has to be MISSING)\r\nBe careful! This key is not very reliable" +
                "!";
            this.inverted_checkBox.UseVisualStyleBackColor = true;
            // 
            // path_label
            // 
            this.path_label.AutoSize = true;
            this.path_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.path_label.Location = new System.Drawing.Point(10, 330);
            this.path_label.Name = "path_label";
            this.path_label.Size = new System.Drawing.Size(116, 17);
            this.path_label.TabIndex = 20;
            this.path_label.Text = "Recognizer path:";
            // 
            // serial_textBox
            // 
            this.serial_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.serial_textBox.Location = new System.Drawing.Point(13, 350);
            this.serial_textBox.Name = "serial_textBox";
            this.serial_textBox.ReadOnly = true;
            this.serial_textBox.Size = new System.Drawing.Size(273, 23);
            this.serial_textBox.TabIndex = 15;
            // 
            // description_textBox
            // 
            this.description_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.description_textBox.Location = new System.Drawing.Point(12, 439);
            this.description_textBox.Multiline = true;
            this.description_textBox.Name = "description_textBox";
            this.description_textBox.Size = new System.Drawing.Size(273, 53);
            this.description_textBox.TabIndex = 17;
            // 
            // description_label
            // 
            this.description_label.AutoSize = true;
            this.description_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.description_label.Location = new System.Drawing.Point(13, 418);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(83, 17);
            this.description_label.TabIndex = 19;
            this.description_label.Text = "Description:";
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(12, 498);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(273, 28);
            this.ok_button.TabIndex = 18;
            this.ok_button.Text = "Set";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(10, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 57);
            this.label1.TabIndex = 21;
            this.label1.Text = "Warning:\r\n* Default camera is used\r\n* Do not rely on this key: you should have an" +
                "other way to log in if recognition fails";
            // 
            // createdKeys_listBox
            // 
            this.createdKeys_listBox.FormattingEnabled = true;
            this.createdKeys_listBox.Location = new System.Drawing.Point(6, 19);
            this.createdKeys_listBox.Name = "createdKeys_listBox";
            this.createdKeys_listBox.Size = new System.Drawing.Size(262, 225);
            this.createdKeys_listBox.TabIndex = 3;
            this.createdKeys_listBox.SelectedIndexChanged += new System.EventHandler(this.createdKeys_listBox_SelectedIndexChanged);
            // 
            // existingKeys_groupBox
            // 
            this.existingKeys_groupBox.Controls.Add(this.createdKeys_listBox);
            this.existingKeys_groupBox.Location = new System.Drawing.Point(12, 12);
            this.existingKeys_groupBox.Name = "existingKeys_groupBox";
            this.existingKeys_groupBox.Size = new System.Drawing.Size(274, 258);
            this.existingKeys_groupBox.TabIndex = 22;
            this.existingKeys_groupBox.TabStop = false;
            this.existingKeys_groupBox.Text = "Created Keys";
            // 
            // keyConfig_groupBox
            // 
            this.keyConfig_groupBox.Controls.Add(this.sensivity_label);
            this.keyConfig_groupBox.Controls.Add(this.sensivity_trackBar);
            this.keyConfig_groupBox.Controls.Add(this.testKey_button);
            this.keyConfig_groupBox.Controls.Add(this.rightEyeBlink_checkBox);
            this.keyConfig_groupBox.Controls.Add(this.leftEyeBlink_checkBox);
            this.keyConfig_groupBox.Controls.Add(this.blink_checkBox);
            this.keyConfig_groupBox.Controls.Add(this.adFace_button);
            this.keyConfig_groupBox.Controls.Add(this.registeredFaces_listView);
            this.keyConfig_groupBox.Controls.Add(this.pictureBox);
            this.keyConfig_groupBox.Location = new System.Drawing.Point(293, 13);
            this.keyConfig_groupBox.Name = "keyConfig_groupBox";
            this.keyConfig_groupBox.Size = new System.Drawing.Size(559, 521);
            this.keyConfig_groupBox.TabIndex = 23;
            this.keyConfig_groupBox.TabStop = false;
            this.keyConfig_groupBox.Text = "Key config";
            // 
            // sensivity_label
            // 
            this.sensivity_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.sensivity_label.Location = new System.Drawing.Point(246, 405);
            this.sensivity_label.Name = "sensivity_label";
            this.sensivity_label.Size = new System.Drawing.Size(120, 65);
            this.sensivity_label.TabIndex = 8;
            this.sensivity_label.Text = "Security level\r\n(Greater value -> More secure but less sensitive)";
            // 
            // sensivity_trackBar
            // 
            this.sensivity_trackBar.AutoSize = false;
            this.sensivity_trackBar.LargeChange = 1000;
            this.sensivity_trackBar.Location = new System.Drawing.Point(365, 414);
            this.sensivity_trackBar.Maximum = 10000;
            this.sensivity_trackBar.Minimum = 50;
            this.sensivity_trackBar.Name = "sensivity_trackBar";
            this.sensivity_trackBar.Size = new System.Drawing.Size(185, 45);
            this.sensivity_trackBar.SmallChange = 50;
            this.sensivity_trackBar.TabIndex = 7;
            this.sensivity_trackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.sensivity_trackBar.Value = 5000;
            this.sensivity_trackBar.Scroll += new System.EventHandler(this.sensivity_trackBar_Scroll);
            // 
            // testKey_button
            // 
            this.testKey_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.testKey_button.Location = new System.Drawing.Point(365, 475);
            this.testKey_button.Name = "testKey_button";
            this.testKey_button.Size = new System.Drawing.Size(106, 38);
            this.testKey_button.TabIndex = 6;
            this.testKey_button.Text = "Test key now";
            this.testKey_button.UseVisualStyleBackColor = true;
            this.testKey_button.Click += new System.EventHandler(this.testKey_button_Click);
            // 
            // rightEyeBlink_checkBox
            // 
            this.rightEyeBlink_checkBox.AutoSize = true;
            this.rightEyeBlink_checkBox.Enabled = false;
            this.rightEyeBlink_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.rightEyeBlink_checkBox.Location = new System.Drawing.Point(430, 374);
            this.rightEyeBlink_checkBox.Name = "rightEyeBlink_checkBox";
            this.rightEyeBlink_checkBox.Size = new System.Drawing.Size(120, 21);
            this.rightEyeBlink_checkBox.TabIndex = 5;
            this.rightEyeBlink_checkBox.Text = "Right eye blink";
            this.rightEyeBlink_checkBox.UseVisualStyleBackColor = true;
            // 
            // leftEyeBlink_checkBox
            // 
            this.leftEyeBlink_checkBox.AutoSize = true;
            this.leftEyeBlink_checkBox.Enabled = false;
            this.leftEyeBlink_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.leftEyeBlink_checkBox.Location = new System.Drawing.Point(246, 374);
            this.leftEyeBlink_checkBox.Name = "leftEyeBlink_checkBox";
            this.leftEyeBlink_checkBox.Size = new System.Drawing.Size(159, 21);
            this.leftEyeBlink_checkBox.TabIndex = 4;
            this.leftEyeBlink_checkBox.Text = "Wait for left eye blink";
            this.leftEyeBlink_checkBox.UseVisualStyleBackColor = true;
            // 
            // blink_checkBox
            // 
            this.blink_checkBox.AutoSize = true;
            this.blink_checkBox.Enabled = false;
            this.blink_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.blink_checkBox.Location = new System.Drawing.Point(246, 347);
            this.blink_checkBox.Name = "blink_checkBox";
            this.blink_checkBox.Size = new System.Drawing.Size(136, 21);
            this.blink_checkBox.TabIndex = 3;
            this.blink_checkBox.Text = "Wait for eye blink";
            this.blink_checkBox.UseVisualStyleBackColor = true;
            // 
            // adFace_button
            // 
            this.adFace_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.adFace_button.Location = new System.Drawing.Point(246, 473);
            this.adFace_button.Name = "adFace_button";
            this.adFace_button.Size = new System.Drawing.Size(100, 40);
            this.adFace_button.TabIndex = 2;
            this.adFace_button.Text = "Add face";
            this.adFace_button.UseVisualStyleBackColor = true;
            this.adFace_button.Click += new System.EventHandler(this.addFace_button_Click);
            // 
            // registeredFaces_listView
            // 
            this.registeredFaces_listView.Location = new System.Drawing.Point(10, 347);
            this.registeredFaces_listView.Name = "registeredFaces_listView";
            this.registeredFaces_listView.Size = new System.Drawing.Size(230, 166);
            this.registeredFaces_listView.TabIndex = 1;
            this.registeredFaces_listView.UseCompatibleStateImageBehavior = false;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox.Location = new System.Drawing.Point(10, 20);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(540, 320);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // FaceRecognitionKeyManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 539);
            this.Controls.Add(this.keyConfig_groupBox);
            this.Controls.Add(this.existingKeys_groupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inverted_checkBox);
            this.Controls.Add(this.path_label);
            this.Controls.Add(this.serial_textBox);
            this.Controls.Add(this.description_textBox);
            this.Controls.Add(this.description_label);
            this.Controls.Add(this.ok_button);
            this.Name = "FaceRecognitionKeyManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Face recognition";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FaceRecognitionKeyManagementForm_FormClosed);
            this.existingKeys_groupBox.ResumeLayout(false);
            this.keyConfig_groupBox.ResumeLayout(false);
            this.keyConfig_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sensivity_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion
		private System.Windows.Forms.CheckBox inverted_checkBox;
		private System.Windows.Forms.Label path_label;
		private System.Windows.Forms.TextBox serial_textBox;
		private System.Windows.Forms.TextBox description_textBox;
		private System.Windows.Forms.Label description_label;
		private System.Windows.Forms.Button ok_button;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox createdKeys_listBox;
        private System.Windows.Forms.GroupBox existingKeys_groupBox;
		private System.Windows.Forms.GroupBox keyConfig_groupBox;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button adFace_button;
        private System.Windows.Forms.ListView registeredFaces_listView;
        private System.Windows.Forms.CheckBox rightEyeBlink_checkBox;
        private System.Windows.Forms.CheckBox leftEyeBlink_checkBox;
        private System.Windows.Forms.CheckBox blink_checkBox;
        private System.Windows.Forms.Button testKey_button;
        private System.Windows.Forms.TrackBar sensivity_trackBar;
        private System.Windows.Forms.Label sensivity_label;
    }
}