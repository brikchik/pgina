using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Management;
using log4net;
using pGina.Plugin.MFLoginPlugin.Entities.ManagementForms;
namespace pGina.Plugin.MFLoginPlugin.Entities.Keys
{
    class ConnectedDevice : Key
    {
		private static ILog m_logger = LogManager.GetLogger("MFLoginPlugin");
		public ConnectedDevice(UInt64 kid):base(kid)
		{
			Type = "ConnectedDevice";
		}
		public ConnectedDevice() : base()
		{
			Type = "ConnectedDevice";
		}
		public override bool AddKey()
		{
			ConnectedDeviceManagementForm umf = new ConnectedDeviceManagementForm(KID);
			umf.ShowDialog();
			if (!umf.IsValid) return false;
			Serial = umf.Serial;
			Description = umf.Description;
			Inverted = umf.Inverted;
			return true;
		}
		public override bool CheckKey(string password) {
			bool success = false;
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity");
			foreach (ManagementBaseObject msObject in managementObjectSearcher.Get())
			{
				if (msObject["DeviceID"].ToString().Contains(Serial))
				{
					m_logger.Debug("Device with serial number "+msObject["DeviceID"].ToString() + " is connected");
					success = true;
				}
			}
			if (Inverted) success = !success;
			log4net.LogManager.GetLogger("MFLoginPlugin").Debug("ConnectedDevice " + Description + "; Inverted: " + Inverted + "; Success: " + success);
			return success;
		}
	}
}
