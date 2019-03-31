﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Management;
using log4net;
using pGina.Plugin.MFLoginPlugin.Entities.ManagementForms;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;

namespace pGina.Plugin.MFLoginPlugin.Entities.Keys
{
	class BluetoothDevice : Key
	{
		private static ILog m_logger = LogManager.GetLogger("MFLoginPlugin");
		public BluetoothDevice(ulong kid) : base(kid) { Type = "BluetoothDevice"; }
        public override bool AddKey(string userName = "")
		{
			BluetoothManagementForm umf = new BluetoothManagementForm(userName);
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
				BluetoothDeviceInfo[] info = bluetoothClient.DiscoverDevices();
				//BluetoothDeviceInfo[] paired = bluetoothClient.DiscoverDevices(255, true, false, false);
				foreach (BluetoothDeviceInfo device in info)
				{
					if (device.DeviceAddress.ToString() == Serial && device.LastSeen>DateTime.Now.Subtract(TimeSpan.FromSeconds(30)))
					{
						success = true;
						break;
					}
					//
					// This method is unreliable as bluetooth address can be copied.
					// It also has glitches sometimes (with false positives & false negatives)
					// Device should be paired for the key to be secure
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