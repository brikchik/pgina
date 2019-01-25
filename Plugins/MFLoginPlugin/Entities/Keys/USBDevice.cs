using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using pGina.Plugin.MFLoginPlugin.Entities.KeyManagementForms;
namespace pGina.Plugin.MFLoginPlugin.Entities.Keys
{
    class USBDevice : IKey
    {
        private string Serial = "";
        private string Type = "USBDevice";
        UInt64 IKey.KID() { return 0; }
        //
        string[] IKey.GetInfo() { return new String[] { Type, Serial }; }// !!!!!!!!!!
        string IKey.Type() { return Type; }

        void IKey.AddKey(string newSerial) { Serial=newSerial; }// !!!!!!!!!!! has to be done in form
        void IKey.AddKey()
        {
            USBManagementForm pmf = new USBManagementForm();
            pmf.ShowDialog();
        }
        bool IKey.CheckKey(string password) { return isPluggedIn(); } // !!!!!!!!!!
        private bool isPluggedIn()
        {
            return false; // !!!!!!!!!! check if USB device is connected and has the Serial SN;
        }
        string IKey.ReturnPassword() { return null; }
    }
}
