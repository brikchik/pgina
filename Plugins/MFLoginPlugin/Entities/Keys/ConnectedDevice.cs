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
		public ConnectedDevice(UInt64 kid):base(kid) { Type = "ConnectedDevice"; }
        public override bool AddKey(string userName = "")
		{
			ConnectedDeviceManagementForm umf = new ConnectedDeviceManagementForm(userName);
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
					success = true;
				}
			}
			if (Inverted) success = !success;
			m_logger.Info("ConnectedDevice " + Description + "; Inverted: " + Inverted + "; Success: " + success);
			return success;
		}
	}
}
