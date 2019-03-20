using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using pGina.Plugin.MFLoginPlugin.Entities.ManagementForms;

namespace pGina.Plugin.MFLoginPlugin.Entities.Keys
{
	class HttpRequestKey : Key
	{
		// Data field has URL
		// Password field has the correct response
		public HttpRequestKey(ulong kid) : base(kid) { Type = "HttpRequest";  IsConfigurable = true; } // specific key
		public HttpRequestKey() : base(0) { Type = "HttpRequest"; IsConfigurable = true; } // empty key
		public override bool AddKey()
		{
			HttpRequestManagementForm httpr = new HttpRequestManagementForm(KID);
			httpr.ShowDialog();
			if (!httpr.IsValid) return false;
			Data = httpr.Address;
			Password = httpr.Response;
			Description = httpr.Description;
			Inverted = httpr.Inverted;
			return true;
		}
		public override void Configure()
		{
			HttpRequestManagementForm httpr = new HttpRequestManagementForm(Data, Password, Inverted, Description);
			httpr.ShowDialog();
			if (!httpr.IsValid) return;
			Data = httpr.Address;
			Password = httpr.Response;
			Description = httpr.Description;
			Inverted = httpr.Inverted;
		}
		public override bool CheckKey(string password)
		{
			bool success = false;
			string answer = Shared.HttpGet(Data);
			success = (answer==Password);
			if (Inverted) success = !success;
			log4net.LogManager.GetLogger("MFLoginPlugin").Debug("HttpRequest " + Description + "; Inverted: " + Inverted + "; Success: " + success);
			return success;
		}
	}
}
