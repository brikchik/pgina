using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Security.Cryptography;
namespace pGina.Plugin.MFLoginPlugin
{
	class Shared
	{
		public static void RunConsoleCommand(string command) //just in case you need it
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.FileName = "cmd.exe";
			processStartInfo.Arguments = "/C "+command;
			process.StartInfo = processStartInfo;
			process.Start();
		}
		public static string GetUniqueKey(int size)
		{
			char[] chars =
				"abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
			byte[] data = new byte[size];
			using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
			{
				crypto.GetBytes(data);
			}
			StringBuilder result = new StringBuilder(size);
			foreach (byte b in data)
			{
				result.Append(chars[b % (chars.Length)]);
			}
			return result.ToString();
		}
		public static string hashed(string text)
		{
			SHA256 sha = new SHA256CryptoServiceProvider();
			byte[] checkSum = sha.ComputeHash(Encoding.UTF8.GetBytes(text));
			string result = BitConverter.ToString(checkSum).Replace("-", String.Empty);
			return result;
		}
		
	}
}
