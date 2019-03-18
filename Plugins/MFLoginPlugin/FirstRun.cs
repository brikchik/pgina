using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using pGina.Shared.Settings;

namespace pGina.Plugin.MFLoginPlugin
{
    public partial class FirstRun : Form
    {
		dynamic m_settings = new pGinaDynamicSettings(MFLoginPlugin.SimpleUuid);
		bool chosen = false;
        public FirstRun()
        {
            if (!(bool)m_settings.FirstRun && !(bool)m_settings.Local)
            {
                DialogResult dr = MessageBox.Show("Your pc is a part of network.\nPlease contact your system administrator.\nThis message means that network is unavailable.\n\nDo you want to use MFLoginPlugin locally anyway?", "pGina remote client", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (dr == DialogResult.No) return;
            }
            InitializeComponent();
            ShowDialog();
        }
        private void buttonContinue_local_Click(object sender, EventArgs e)
        {
            if (!chosen)
            {
                chosen = true;
                buttonContinue_network.Visible = false;
                passwordField.Focus();
            }
            else
            {
                string path = dbPath_textBox.Text;
                try
                {
                    if (File.Exists(path)) DBHelper.ConnectLocalDB(path, passwordField.Text);
                    else
                        DBHelper.CreateLocalDB(path, passwordField.Text);
					m_settings.LocalDatabasePath = path;
					m_settings.Local = true;
					m_settings.FirstRun = false;
					LocalConfiguration localConfiguration = new LocalConfiguration();
				}
                catch (System.Data.SQLite.SQLiteException sqle) { MessageBox.Show(sqle.Message, "Unable to use database"); }
            }
        }

        private void buttonContinue_network_Click(object sender, EventArgs e)
        {
            if (!chosen)
            {
                chosen = true;
                buttonContinue_local.Visible = false;
                serverPath_textbox.Focus();
            }
            else
            {
                DBHelper.ConnectToRemoteDB(serverPath_textbox.Text);
				m_settings.RemoteDatabasePath = serverPath_textbox.Text;
				m_settings.FirstRun = false;
				m_settings.Local = false;
				MessageBox.Show("Connected to remote db. Configuration successful");
				Close();
            }
        }

        private void changePath_button_Click(object sender, EventArgs e)
        {
            saveDBDialog.InitialDirectory=@"";
            saveDBDialog.Filter.Contains(".db");
            DialogResult dr=saveDBDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                changePath_button.BackColor = SystemColors.ActiveCaption;
                defaultPath_button.BackColor = SystemColors.ButtonFace;
				dbPath_textBox.Text = saveDBDialog.FileName;
            }
        }
        private void defaultPath_button_Click(object sender, EventArgs e)
        {
            changePath_button.BackColor = SystemColors.ButtonFace;
            defaultPath_button.BackColor = SystemColors.ActiveCaption;
            dbPath_textBox.Text = "C:/Program files/pGina.fork/Plugins/MFLoginDB.db";
        }
    }
}
