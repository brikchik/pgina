using System;
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
        public static BooleanResult TryAuthMethod(AuthMethod am,UserInformation userInfo, bool logAttempt=true)
        {
            try
            {
                User user = new User();
                user.FillByName(userInfo.Username);
                int number_of_valid_keys = 0;
                int number_of_keys_required = am.Number_of_keys;
                string usedKeys = "";
                m_logger.Debug("Auth_method loaded: " + am.AMID + "; Keys required: " + number_of_keys_required);
                // checking keys in auth method
                // getting password if it's stored in a key
                // last returned password is used
                try
                {
                    bool keySuccess = am.K1.CheckKey(userInfo.OriginalPassword);
                    if (keySuccess)
                    {
                        usedKeys += "->" + am.K1.GetType();
                        number_of_valid_keys++;
                    }
                    if (am.K1.ReturnWindowsPassword() != null) userInfo.Password = am.K1.ReturnWindowsPassword();
                }
                catch { }
                try
                {
                    bool keySuccess = am.K2.CheckKey(userInfo.OriginalPassword);
                    if (keySuccess)
                    {
                        usedKeys += "->" + am.K2.GetType();
                        number_of_valid_keys++;
                    }
                    if (am.K2.ReturnWindowsPassword() != null) userInfo.Password = am.K2.ReturnWindowsPassword();
                }
                catch { }
                try
                {
                    bool keySuccess = am.K3.CheckKey(userInfo.OriginalPassword);
                    if (keySuccess)
                    {
                        usedKeys += "->" + am.K3.GetType();
                        number_of_valid_keys++;
                    }
                    if (am.K3.ReturnWindowsPassword() != null) userInfo.Password = am.K3.ReturnWindowsPassword();
                }
                catch { }
                try
                {
                    bool keySuccess = am.K4.CheckKey(userInfo.OriginalPassword);
                    if (keySuccess)
                    {
                        usedKeys += "->" + am.K4.GetType();
                        number_of_valid_keys++;
                    }
                    if (am.K4.ReturnWindowsPassword() != null) userInfo.Password = am.K4.ReturnWindowsPassword();
                }
                catch { }
                try
                {
                    bool keySuccess = am.K5.CheckKey(userInfo.OriginalPassword);
                    if (keySuccess)
                    {
                        usedKeys += "->" + am.K5.GetType();
                        number_of_valid_keys++;
                    }
                    if (am.K5.ReturnWindowsPassword() != null) userInfo.Password = am.K5.ReturnWindowsPassword();
                }
                catch { }
                m_logger.Debug("Valid keys: " + number_of_valid_keys + " out of " + number_of_keys_required);

                if (number_of_valid_keys >= number_of_keys_required)
                {
                    if (userInfo.Password == userInfo.OriginalPassword && user.WindowsPassword != null)
                        userInfo.Password = user.WindowsPassword;
					if (logAttempt)
					{
						LogEntity loginAttempt = new LogEntity(user, am, true);
						loginAttempt.Save();
					}
                    return new BooleanResult { Success = true, Message = "Logged via: " + usedKeys };
                }
                number_of_valid_keys = 0;
                userInfo.Password = userInfo.OriginalPassword;
				if (logAttempt)
				{
					LogEntity failedLoginAttempt = new LogEntity(user, am, false);
					failedLoginAttempt.Save();
				}
                return new BooleanResult() { Success = false, Message = "This authentication method has failed" };
            }
            catch
            { return new BooleanResult() { Success = false, Message = "Error in this authentication method" }; }
        }
		private static ILog m_logger = LogManager.GetLogger("MFLoginPlugin");
		public static BooleanResult Authenticate(UserInformation userInfo)
		{
			dynamic m_settings = new pGinaDynamicSettings(MFLoginPlugin.SimpleUuid);
			if ((bool)m_settings.FirstRun) return new BooleanResult() { Success=false, Message="MFLogin plugin is not configured"};
			BooleanResult connectionSuccess = new BooleanResult { Success = false };
			if ((bool)m_settings.Local)
			{
				string DBPassword = Encoding.ASCII.GetString(ProtectedData.Unprotect((byte[])m_settings.DBPassword, (byte[])m_settings.DBPasswordSalt, DataProtectionScope.LocalMachine));
				connectionSuccess = DBHelper.ConnectOrCreateLocalDB((string)m_settings.LocalDatabasePath, DBPassword);
			}
			else
			{
				connectionSuccess = DBHelper.ConnectToRemoteDB((string)m_settings.RemoteDatabasePath);
			}
			if (!connectionSuccess.Success) return connectionSuccess;
			User user = new User();
			if (!user.FillByName(userInfo.Username))
			{
				return new BooleanResult { Success = false, Message = "User doesn't exist" };
			}
			AuthMethod[] am = DBHelper.GetAuthMethods(user);
			for (int i = 0; i < am.Length; i++)
			{
                BooleanResult amResult=TryAuthMethod(am[i], userInfo);
                if (amResult.Success) return amResult;
			}
            // case no auth method succeeded:
			return new BooleanResult { Success = false, Message = "MFLogin failed to authenticate you" };
		}
		
    }
}