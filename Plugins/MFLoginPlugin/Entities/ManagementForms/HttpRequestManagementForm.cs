using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pGina.Plugin.MFLoginPlugin.Entities.ManagementForms
{
	public partial class HttpRequestManagementForm : Form
	{
		public HttpRequestManagementForm(string userName)
		{
			InitializeComponent();
			description_textBox.Text = "HttpRequest"+ " for " + userName;
		}
		public HttpRequestManagementForm(string address, string response, bool inverted, string description)
		{
			InitializeComponent();
			address_textBox.Text = address;
			response_textBox.Text = response;
			inverted_checkBox.Checked = inverted;
			description_textBox.Text = description;
		}
		public bool IsValid = false;
		public string Address = null;
		public string Response = null;
		public string Description = null;
		public bool Inverted = false;
		private void ok_button_Click(object sender, EventArgs e)
		{
			Address = address_textBox.Text;
			Response = response_textBox.Text;
			Inverted = inverted_checkBox.Checked;
			Description = description_textBox.Text;

			string receivedResponse = null;
			try
			{
				receivedResponse = Shared.HttpGet(Address);
			}
			catch (Exception ex){
				receivedResponse_textBox.Text = "Request failed: \n"+ex.Message;
				return;
			}
			receivedResponse_textBox.Text = receivedResponse;
			if (receivedResponse == Response)
			{
				IsValid = true;
				Close();
			}
			else
			{
				ok_button.Text = "Failed to get correct response.";
				setAnyway_button.Visible = true;
			}
		}

		private void setAnyway_button_Click(object sender, EventArgs e)
		{
			Address = address_textBox.Text;
			Response = response_textBox.Text;
			Inverted = inverted_checkBox.Checked;
			Description = description_textBox.Text;
			IsValid = true;
			Close();
		}

		private void address_textBox_TextChanged(object sender, EventArgs e)
		{
			if (!Shared.CheckHttpAddress(address_textBox.Text)) ok_button.Text = "Incorrect URL";
			else ok_button.Text = "Check and set";
		}

		private void response_textBox_TextChanged(object sender, EventArgs e)
		{
			ok_button.Text = "Check and set";
		}
	}
}
