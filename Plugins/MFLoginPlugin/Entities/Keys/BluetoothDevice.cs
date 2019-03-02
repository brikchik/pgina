using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Management;
using log4net;
using pGina.Plugin.MFLoginPlugin.Entities.KeyManagementForms;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;

namespace pGina.Plugin.MFLoginPlugin.Entities.Keys
{
	class BluetoothDevice : Key
	{
		private static ILog m_logger = LogManager.GetLogger("MFLoginPlugin");
		public BluetoothDevice(ulong kid) : base(kid)
		{
			Type = "BluetoothDevice";
		}
		public BluetoothDevice() : base()
		{
			Type = "BluetoothDevice";
		}
		public new string[] GetInfo() { return new String[] { Type, Serial }; }// !!!!!!!!!!
		public override void AddKey()
		{
			BluetoothManagementForm umf = new BluetoothManagementForm(KID);
			umf.ShowDialog();
			Serial = umf.Serial;
			Description = umf.Description;
		}
		public override bool CheckKey(string password)
		{
			m_logger.Debug("Searching for bluetooth device - "+Serial);
			BluetoothClient bluetoothClient = new BluetoothClient();
			BluetoothDeviceInfo[] info = bluetoothClient.DiscoverDevices(100);
			BluetoothDeviceInfo[] paired = bluetoothClient.DiscoverDevices(255, true, false, false);
			foreach (BluetoothDeviceInfo device in info)
			{
				// !!!! my pc doesn't have a bluetooth module, implementation pending
				m_logger.Debug("Bluetooth not implemented!!!");
			}
			return false;
		}
	}
}
