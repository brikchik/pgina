using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pGina.Plugin.MFLoginPlugin
{
    class USBDevice
    {
        private string Serial = "";
        private string Type = "USBDevice";
        //
        string[] IKey.GetInfo() { return new String[] { Type, Serial }; }// !!!!!!!!!!
        string IKey.Type() { return Type; }

        void IKey.AddKey(string newSerial) { Serial=newSerial; }// !!!!!!!!!!! has to be done in form

        bool IKey.CheckKey(string password) { return isPluggedIn(); } // !!!!!!!!!!
        private bool isPluggedIn()
        {
            return false; // !!!!!!!!!! check if USB device is connected and has the Serial SN;
        }
    }
}
