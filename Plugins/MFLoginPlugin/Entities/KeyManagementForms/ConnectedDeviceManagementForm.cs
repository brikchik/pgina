using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pGina.Plugin.MFLoginPlugin.Entities.KeyManagementForms
{
    public partial class ConnectedDeviceManagementForm : Form
    {
		public string Description="ConnectedDevice N";
		public string Serial="";
        public ConnectedDeviceManagementForm(ulong kid)
        {
            InitializeComponent();
			description_textBox.Text += kid;
        }

		private void button1_Click(object sender, EventArgs e)
		{

		}
	}
}
