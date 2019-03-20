﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using pGina.Shared.Types;
using pGina.Shared.Interfaces;
using pGina.Plugin.MFLoginPlugin.Entities;
using log4net;
using pGina.Shared.Settings;
using System.Security.Cryptography;

namespace pGina.Plugin.MFLoginPlugin
{
    class AuthenticationManager
    {
        
		private static ILog m_logger = LogManager.GetLogger("MFLoginPlugin");
		public static BooleanResult Authenticate(UserInformation userInfo)
		{
			dynamic m_settings = new pGinaDynamicSettings(MFLoginPlugin.SimpleUuid);
			if ((bool)m_settings.FirstRun) return new BooleanResult() { Success=false, Message="MFLogin plugin is not configured"};
			BooleanResult connectionSuccess = new BooleanResult { Success = false };
			if ((bool)m_settings.Local)
			{
				string DBPassword = Encoding.ASCII.GetString(ProtectedData.Unprotect((byte[])m_settings.DBPassword, (byte[])m_settings.DBPasswordSalt, DataProtectionScope.LocalMachine));
				connectionSuccess = DBHelper.ConnectLocalDB((string)m_settings.LocalDatabasePath, DBPassword);
			}
			else
			{
				connectionSuccess = DBHelper.ConnectToRemoteDB((string)m_settings.RemoteDatabasePath);
			}
			if (!connectionSuccess.Success) return connectionSuccess;
			string inputPassword = userInfo.Password;
			User user = new User();
			if (!user.FillByName(userInfo.Username))
			{
				return new BooleanResult { Success = false, Message = "User doesn't exist" };
			}
			AuthMethod[] am = DBHelper.GetAuthMethods(user);
			for (int i = 0; i < am.Length; i++)
			{
				int number_of_valid_keys = 0;
				int number_of_keys_required = am[i].Number_of_keys;
				string usedKeys = "";
				m_logger.Debug("Auth_method loaded: " + am[i].AMID + "; Keys required: " + number_of_keys_required);
				// checking keys in auth method
				// getting password if it's stored in a key
				// last returned password is used
				try
				{
					bool keySuccess = am[i].K1.CheckKey(userInfo.Password);
					if (keySuccess)
					{
						usedKeys += "->" + am[i].K1.GetType();
						number_of_valid_keys++;
					}
					if (am[i].K1.ReturnWindowsPassword() != null) userInfo.Password = am[i].K1.ReturnWindowsPassword();
				}
				catch { }
				try
				{
					bool keySuccess = am[i].K2.CheckKey(userInfo.Password);
					if (keySuccess)
					{
						usedKeys += "->" + am[i].K2.GetType();
						number_of_valid_keys++;
					}
					if (am[i].K2.ReturnWindowsPassword() != null) userInfo.Password = am[i].K2.ReturnWindowsPassword();
				}
				catch { }
				try
				{
					bool keySuccess = am[i].K3.CheckKey(userInfo.Password);
					if (keySuccess)
					{
						usedKeys += "->" + am[i].K3.GetType();
						number_of_valid_keys++;
					}
					if (am[i].K3.ReturnWindowsPassword() != null) userInfo.Password = am[i].K3.ReturnWindowsPassword();
				}
				catch { }
				try
				{
					bool keySuccess = am[i].K4.CheckKey(userInfo.Password);
					if (keySuccess)
					{
						usedKeys += "->" + am[i].K4.GetType();
						number_of_valid_keys++;
					}
					if (am[i].K4.ReturnWindowsPassword() != null) userInfo.Password = am[i].K4.ReturnWindowsPassword();
				}
				catch { }
				try
				{
					bool keySuccess = am[i].K5.CheckKey(userInfo.Password);
					if (keySuccess)
					{
						usedKeys += "->" + am[i].K5.GetType();
						number_of_valid_keys++;
					}
					if (am[i].K5.ReturnWindowsPassword() != null) userInfo.Password = am[i].K5.ReturnWindowsPassword();
				}
				catch { }
				m_logger.Debug("Valid keys: " + number_of_valid_keys + " out of " + number_of_keys_required);
				if (number_of_valid_keys >= number_of_keys_required)
				{
					if (userInfo.Password == inputPassword && user.WindowsPassword != null)
						userInfo.Password = user.WindowsPassword;
					return new BooleanResult { Success = true, Message = "Logged via: " + usedKeys };
				}
				number_of_valid_keys = 0;
				userInfo.Password = userInfo.OriginalPassword;
			}
			return new BooleanResult { Success = false, Message = "MFLogin failed to authenticate you" };
		}
		
    }
}