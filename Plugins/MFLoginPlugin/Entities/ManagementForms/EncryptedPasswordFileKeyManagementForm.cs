using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using log4net;

namespace pGina.Plugin.MFLoginPlugin.Entities.ManagementForms
{
    public partial class EncryptedPasswordFileKeyManagementForm : Form
    {
        public string Path = null;
        public string Password = null;
        public bool SavePassword=false;
        public string Description = null;
        public bool Inverted = false;
        public bool IsValid = false;
        private SaveFileDialog fileDialog;
        private static ILog m_logger = LogManager.GetLogger("MFLoginPlugin");
        public EncryptedPasswordFileKeyManagementForm(string userName)
        {
            InitializeComponent();
            fileDialog = new SaveFileDialog();
            fileDialog.CheckFileExists = false;
            fileDialog.CreatePrompt = false;
            fileDialog.Title = "Choose password file location";
            fileDialog.DefaultExt = ".wpf"; // windows password file
            fileDialog.FileName = Shared.GetUniqueKey(16);
            fileDialog.FileOk += fileDialog_fileChosen;
            description_textBox.Text += " for " + userName;
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            Inverted = inverted_checkBox.Checked;
            Description = description_textBox.Text;
            Path = path_textBox.Text;
            Password = password_textBox.Text;
            SavePassword = savePassword_checkBox.Checked;
            try
            {
                fileDialog.OpenFile().Close();
            }
            catch (Exception ex){ m_logger.Debug("Unable to use this file path "+ex.Message); return; }
            if (Path != "" && Password != "")
            {
                IsValid = true;
                Close();
            }
        }
        private void fileDialog_fileChosen(object sender, EventArgs e)
        {
            FileInfo fileInfo = new FileInfo(fileDialog.FileName);
            path_textBox.Text = fileInfo.FullName;
        }
        private void chooseFile_button_Click(object sender, EventArgs e)
        {
            fileDialog.ShowDialog();
        }
    }
}
