using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using pGina.Plugin.MFLoginPlugin.Entities.KeyManagementForms;
namespace pGina.Plugin.MFLoginPlugin.Entities.Keys
{
    class USBDevice : Key
    {
		public USBDevice(UInt64 kid):base(kid)
		{
			Type = "USBDevice";
		}
		public USBDevice() : base()
		{
			Type = "USBDevice";
		}
		public new string[] GetInfo() { return new String[] { Type, Password }; }// !!!!!!!!!!
		public void AddKey(string newPassword) { Password = newPassword; }// has to be done in form //####
		public new void AddKey()
		{
			USBManagementForm umf = new USBManagementForm();
			umf.ShowDialog();
			Serial = "";
		}
		public new bool CheckKey(string password) { return (password == Password); } // !!!!!!!!!! hash
		public new string ReturnWindowsPassword() { return null; }
	}
}
