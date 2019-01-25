using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pGina.Plugin.MFLoginPlugin
{
    public partial class FirstRun : Form
    {
        bool chosen = false;
        public FirstRun(bool local, bool firstrun)
        {
            if (!local && !firstrun)
            {
                DialogResult dr = MessageBox.Show("Your pc is a part of network.\nPlease contact your system administrator.\nThis message means that network is unavailable.\n\nDo you want to use MFLoginPlugin locally anyway?", "pGina remote client", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (dr == DialogResult.No) return;
            }
            InitializeComponent();
            this.ShowDialog();
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
            }
        }

        private void changePath_button_Click(object sender, EventArgs e)
        {
            saveDBDialog.InitialDirectory=@"/"; // !!!!!!!!!!!
            saveDBDialog.Filter.Contains(".db");
            DialogResult dr=saveDBDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                changePath_button.BackColor = SystemColors.ActiveCaption;
                defaultPath_button.BackColor = SystemColors.ButtonFace;
            }
        }
        private void defaultPath_button_Click(object sender, EventArgs e)
        {
            changePath_button.BackColor = SystemColors.ButtonFace;
            defaultPath_button.BackColor = SystemColors.ActiveCaption;
        }
    }
}
