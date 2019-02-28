using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Management;
using log4net;
using pGina.Plugin.MFLoginPlugin.Entities.KeyManagementForms;
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
		public new string[] GetInfo() { return new String[] { Type, Serial }; }// !!!!!!!!!!
		public void AddKey(string serial) { if (serial!="")Serial = serial; }// has to be done in form //####
		public new void AddKey()
		{
			DeviceManagementForm umf = new DeviceManagementForm();
			umf.ShowDialog();
			Serial = "";
		}
		public override bool CheckKey(string password) {
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity");
			foreach (ManagementBaseObject msObject in managementObjectSearcher.Get())
			{
				if (msObject["DeviceID"].ToString().Contains(Serial))
				{
					m_logger.Debug(msObject["DeviceID"].ToString() + " is connected");
					return true;
				}
			}
			return false;
		}
	}
}
