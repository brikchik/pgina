using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using InTheHand.Windows.Forms;
namespace pGina.Plugin.MFLoginPlugin.Entities.ManagementForms
{
    public partial class BluetoothManagementForm : Form
    {
		public string Description = "BluetoothDevice";
		public string Serial = null;
		public bool Inverted = false;
		public bool IsValid = false;
        public BluetoothManagementForm(string userName)
        {
            InitializeComponent();
			description_textBox.Text += " for "+userName;
            createdKeys_listBox.Items.AddRange(DBHelper.ReadKeys("BluetoothDevice"));
        }

		private void description_textBox_TextChanged(object sender, EventArgs e)
		{
			Description = description_textBox.Text;
		}

		private void ok_button_Click(object sender, EventArgs e)
		{
			Inverted = inverted_checkBox.Checked;
			if (Serial != null)
			{
				IsValid = true;
				Close();
			}
		}

		private void serial_textBox_TextChanged(object sender, EventArgs e)
		{
			Serial = serial_textBox.Text;
		}

        private void searchBTDevices_button_Click(object sender, EventArgs e)
        {
			try
			{
				SelectBluetoothDeviceDialog sbtd = new SelectBluetoothDeviceDialog();
				sbtd.ShowDialog();
				serial_textBox.Text = sbtd.SelectedDevice.DeviceAddress.ToString();
			}
			catch (Exception ex) { MessageBox.Show("Unable to use bluetooth. " + ex.Message); }
		}

        private void createdKeys_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Key key = ((Key)createdKeys_listBox.SelectedItem);
            serial_textBox.Text = key.Serial;
            inverted_checkBox.Checked = key.Inverted;
            description_textBox.Text = key.Description;
        }
	}
}
