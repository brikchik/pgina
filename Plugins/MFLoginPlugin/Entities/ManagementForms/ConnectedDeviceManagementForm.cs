using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pGina.Plugin.MFLoginPlugin.Entities.ManagementForms
{
    public partial class ConnectedDeviceManagementForm : Form
    {
		public string Description="ConnectedDevice N";
		public string Serial="";
		public bool Inverted = false;
		public bool IsValid = false;
        public ConnectedDeviceManagementForm(ulong kid)
        {
            InitializeComponent();
			description_textBox.Text += kid;
        }

		private void ok_button_Click(object sender, EventArgs e)
		{
			Inverted = inverted_checkBox.Checked;
			IsValid = true;
			Close();
		}

		private void serial_textBox_TextChanged(object sender, EventArgs e)
		{
			Serial = serial_textBox.Text;
		}

		private void description_textBox_TextChanged(object sender, EventArgs e)
		{
			Description = description_textBox.Text;
		}
	}
}
