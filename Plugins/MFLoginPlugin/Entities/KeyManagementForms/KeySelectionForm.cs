using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using pGina.Plugin.MFLoginPlugin.Entities.Keys;

namespace pGina.Plugin.MFLoginPlugin.Entities.KeyManagementForms
{
	public partial class KeySelectionForm : Form
	{
		private String Type;
		public KeySelectionForm(string type)
		{
			Type = type;
			InitializeComponent();
			if (Type == "Password")
			{
				IKey pk = new PasswordKey();
				pk.AddKey();
				Key = pk;
				Close();
			}
			else
			{
				ShowDialog();
			}
		}
		public Object Key { get; set; }

		private void KeySelectionForm_Load(object sender, EventArgs e)
		{
			
		}
	}
}
