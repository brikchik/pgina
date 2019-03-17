using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.Runtime.InteropServices;

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
			Description = description_textBox.Text;
			fillSerialsList(serials);
			createdKeys_listBox.Items.AddRange(DBHelper.ReadKeys("ConnectedDevice"));
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

		private void serials_listBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (serials_listBox.SelectedIndex!=-1)
				serial_textBox.Text = serials_listBox.SelectedItem.ToString();
		}

		private void fillSerialsList(List<string> serials)
		{
			serials.Clear();
			try
			{
				int pdnDevInst = 0;
				if (Win32Api.CM_Locate_DevNodeA(ref pdnDevInst, null, Win32Api.CM_LOCATE_DEVNODE_NORMAL) != Win32Api.CR_SUCCESS) throw new Exception();
				if (Win32Api.CM_Reenumerate_DevNode(pdnDevInst, Win32Api.CM_REENUMERATE_NORMAL) != Win32Api.CR_SUCCESS) throw new Exception();
			}
			catch { MessageBox.Show("Unable to update device list", "Some problems"); }
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity");
			foreach (ManagementBaseObject msObject in managementObjectSearcher.Get())
			{
				serials.Add(msObject["DeviceID"].ToString());
			}
		}
		private List<string> serials = new List<string>();
		private List<string> newSerials = new List<string>();
		private void reset_button_Click(object sender, EventArgs e)
		{
			fillSerialsList(serials);
			serials_listBox.Items.Clear();
		}

		private void detectKey_button_Click(object sender, EventArgs e)
		{
			fillSerialsList(newSerials);
			serials_listBox.Items.Clear();
			string[] keyIDs = newSerials.Except(serials).ToArray();
			serials_listBox.Items.AddRange(keyIDs);
			if (keyIDs.Count() > 0) serials_listBox.SelectedIndex = 0;
		}

		private void createdKeys_listBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			Key key = (Key)createdKeys_listBox.SelectedItem;
			serial_textBox.Text = key.Serial;
			description_textBox.Text = key.Description;
		}
	}
	public static class Win32Api // handles plug&play devices list update
	{
		public const int CM_LOCATE_DEVNODE_NORMAL = 0x00000000;
		public const int CM_REENUMERATE_NORMAL = 0x00000000;
		public const int CR_SUCCESS = 0x00000000;

		[DllImport("CfgMgr32.dll", SetLastError = true)]
		public static extern int CM_Locate_DevNodeA(ref int pdnDevInst, string pDeviceID, int ulFlags);

		[DllImport("CfgMgr32.dll", SetLastError = true)]
		public static extern int CM_Reenumerate_DevNode(int dnDevInst, int ulFlags);
	}
}
