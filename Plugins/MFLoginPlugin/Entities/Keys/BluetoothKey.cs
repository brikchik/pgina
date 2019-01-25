using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using pGina.Plugin.MFLoginPlugin.Entities.KeyManagementForms;
namespace pGina.Plugin.MFLoginPlugin.Entities.Keys
{
    class BluetoothKey : IKey
    {
        private string Type = "BluetoothDevice";
        private string Serial = "";
        UInt64 IKey.KID() { return 0; }
        string[] IKey.GetInfo() { return new String[] { Type + Serial }; }// !!!!!!!!!!
        string IKey.Type() { return Type; }
        void IKey.AddKey(string newSerial) { Serial=newSerial; }// !!!!!!!!!!! has to be done in form
        void IKey.AddKey()
        {
            BluetoothManagementForm pmf = new BluetoothManagementForm();
            pmf.ShowDialog();
        }
        bool IKey.CheckKey(string password) { return false; } // !!!!!!!!!!

        string IKey.ReturnPassword() { return null; }  // !!!!!!!!!
    }
}