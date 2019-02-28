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
		public BluetoothDevice(UInt64 kid) : base(kid)
		{
			Type = "Device";
		}
		public BluetoothDevice() : base()
		{
			Type = "Device";
		}
		public new string[] GetInfo() { return new String[] { Type, Serial }; }// !!!!!!!!!!
		public void AddKey(string serial) { if (serial != "") Serial = serial; }// has to be done in form //####
		public new void AddKey()
		{
			DeviceManagementForm umf = new DeviceManagementForm();
			umf.ShowDialog();
			Serial = "";
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
