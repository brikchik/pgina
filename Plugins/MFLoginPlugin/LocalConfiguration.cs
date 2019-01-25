using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using pGina.Shared.Settings;
using pGina.Plugin.MFLoginPlugin.Entities.Keys;

namespace pGina.Plugin.MFLoginPlugin
{
    public partial class LocalConfiguration : Form
    {
        dynamic m_settings = new pGinaDynamicSettings(MFLoginPlugin.SimpleUuid);

        public LocalConfiguration()
        {
            InitializeComponent();
            this.ShowDialog();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PasswordKey pk=new PasswordKey();
            USBDevice usbd = new USBDevice();
            IKey[] ik=new IKey[2];
            ik[0]=pk;
            ik[1] = usbd;
            listBox1.Items.AddRange (ik[0].GetInfo());
            listBox1.Items.AddRange(ik[1].GetInfo());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IKey pk = new PasswordKey();
            pk.AddKey();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IKey pk = new USBDevice();
            pk.AddKey();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IKey pk = new BluetoothKey();
            pk.AddKey();
        }
    }
}
