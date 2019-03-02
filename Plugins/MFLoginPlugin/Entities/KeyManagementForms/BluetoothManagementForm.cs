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
    public partial class BluetoothManagementForm : Form
    {
		public string Description = "BluetoothDevice N";
		public string Serial = "";
        public BluetoothManagementForm(ulong kid)
        {
            InitializeComponent();
			description_textBox.Text += kid;
        }

		private void description_textBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void description_label_Click(object sender, EventArgs e)
		{

		}

		private void ok_button_Click(object sender, EventArgs e)
		{

		}
	}
}
