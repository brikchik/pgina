using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
namespace pGina.Plugin.MFLoginPlugin
{
	class Shared
	{
		public static void RunConsoleCommand(string command)
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.FileName = "cmd.exe";
			processStartInfo.Arguments = "/C "+command;
			process.StartInfo = processStartInfo;
			process.Start();
		}
	}
}
