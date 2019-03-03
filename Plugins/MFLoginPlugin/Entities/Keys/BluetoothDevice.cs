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
		public override bool AddKey()
		{
			BluetoothManagementForm umf = new BluetoothManagementForm(KID);
			umf.ShowDialog();
			if (!umf.IsValid) return false;
			Serial = umf.Serial;
			Description = umf.Description;
			Inverted = umf.Inverted;
			return true;
		}
		public override bool CheckKey(string password)
		{
			bool success = false;
			try
			{
				m_logger.Debug("Searching for bluetooth device " + Serial);
				BluetoothClient bluetoothClient = new BluetoothClient();
				BluetoothDeviceInfo[] info = bluetoothClient.DiscoverDevices(100);
				//BluetoothDeviceInfo[] paired = bluetoothClient.DiscoverDevices(255, true, false, false);
				foreach (BluetoothDeviceInfo device in info)
				{
					if (device.DeviceAddress.ToString() == Serial)
					{
						success = true;
						break;
					}
					//
					//
					//
					// !!!! my pc doesn't have a bluetooth module to develop this key, proper implementation pending
					// This method is __COMPLETELY__ unreliable.
					// It works sometimes though (with false positives & false negatives)
					// Device should be paired in some way for a proper key implementation
					// m_logger.Debug("Bluetooth not implemented!!!");
					//
					//
					//
				}
			}
			catch { m_logger.Debug("Bluetooth key problem. "+Description); }
			if (Inverted) success = !success;
			m_logger.Debug("BluetoothDevice " + Description + "; Inverted: " + Inverted + "; Success: " + success);
			return success; // !!!!
		}
	}
}