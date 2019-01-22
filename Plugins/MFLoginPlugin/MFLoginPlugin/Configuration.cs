﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using pGina.Shared.Settings;

namespace pGina.Plugin.MFLoginPlugin
{
    public partial class Configuration : Form
    {
        dynamic m_settings = new pGinaDynamicSettings(MFLoginPlugin.MFLoginPluginUuid);

        public Configuration()
        {
            InitializeComponent();
            //txtDescription.Text = m_settings.Description;
            //chkShowDescription.Checked = m_settings.ShowDescription;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            //m_settings.Description = txtDescription.Text;
            //m_settings.ShowDescription = chkShowDescription.Checked;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
        private void Configuration_Load(object sender, EventArgs e)
        {

        }
    }
}
