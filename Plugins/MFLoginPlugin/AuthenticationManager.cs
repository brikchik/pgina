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
using System.Threading;

namespace pGina.Plugin.MFLoginPlugin
{
    class AuthenticationManager
    {
        private static ILog m_logger = LogManager.GetLogger("MFLoginPlugin");
        private static dynamic m_settings = new pGinaDynamicSettings(MFLoginPlugin.SimpleUuid);
        private static void TestKey(Key key, string originalPassword, List<Tuple<bool, bool, string, string>> CheckedKeys)
        {
            try
            {
                bool keySuccess = key.CheckKey(originalPassword);
                string windowsPassword = null;
                if (key.ReturnWindowsPassword() != null) windowsPassword = key.ReturnWindowsPassword();
                Tuple<bool, bool, string, string> result =
                    new Tuple<bool, bool, string, string>(true, keySuccess, "--->" + key.ToString(), windowsPassword);
                CheckedKeys.Add(result);
            }
            catch (Exception ex)
            {
                m_logger.Error("Error in key " + key.Description + ex.Message);
                CheckedKeys.Add(new Tuple<bool,bool,string,string>(true, false,"",null));
            }
        }
        public static BooleanResult TryAuthMethod(AuthMethod am,UserInformation userInfo, bool logAttempt=true)
        {
            User user = new User();
            if (!user.FillByName(userInfo.Username)) return new BooleanResult() { Success=false, Message="User doesn't exist in MFLogin database."};
            m_logger.Info("Auth_method loaded: " + am.AMID + "; Keys required: " + am.Number_of_keys);
            // checking keys in auth method
            // getting password if it's stored in a key
            // last returned password is used
            
            List<Tuple<bool, bool, string, string>> CheckedKeys = new List<Tuple<bool, bool, string, string>>();
            // contains: KEY_CHECKED, KEY_SUCCESS, KEY_DESCRIPTION, WindowsPassword
            
            // start the job
            List<Thread> threads = new List<Thread>();
            if (am.K1 != null) threads.Add(new Thread(() => TestKey(am.K1, userInfo.OriginalPassword, CheckedKeys)));
            if (am.K2 != null) threads.Add(new Thread(() => TestKey(am.K2, userInfo.OriginalPassword, CheckedKeys)));
            if (am.K3 != null) threads.Add(new Thread(() => TestKey(am.K3, userInfo.OriginalPassword, CheckedKeys)));
            if (am.K4 != null) threads.Add(new Thread(() => TestKey(am.K4, userInfo.OriginalPassword, CheckedKeys)));
            if (am.K5 != null) threads.Add(new Thread(() => TestKey(am.K5, userInfo.OriginalPassword, CheckedKeys)));
            foreach (Thread thread in threads)
            {
                thread.Start();
                Thread.Sleep(5);
            }
            // we wait for predefined amount of time and stop the process if it's way too slow
            int MAX_AUTH_TIME_SECONDS = 10;
            int max_auth_time_seconds = (int)m_settings.MaxAuthTimeSeconds;
            if (max_auth_time_seconds > 0) MAX_AUTH_TIME_SECONDS = max_auth_time_seconds;
            // security measure: registry may be damaged
            for (int i = 0; i < MAX_AUTH_TIME_SECONDS*20; i++)
            {
                bool allChecked = CheckedKeys.All(tuple=>tuple.Item1==true) && CheckedKeys.Count==threads.Count;
                if (allChecked) break;
                Thread.Sleep(50); // try to log in every 50ms
            }
            // all the keys are checked now. we analyze the results
            int number_of_valid_keys = 0;
            string keysUsed = "";
            string windowsPassword = null;
            foreach (Tuple<bool, bool, string, string> tuple in CheckedKeys)
            {
                if (tuple.Item2) // key checked
                {
                    if (tuple.Item4 != null && tuple.Item4!=user.WindowsPassword) 
                    {
                        windowsPassword = tuple.Item4; // overwrite internal password for this login
                    }
                    keysUsed += tuple.Item3;
                    number_of_valid_keys++;
                    if (number_of_valid_keys >= am.Number_of_keys) break; // success
                }
            }
            m_logger.Info("Valid keys: " + number_of_valid_keys + " out of " + am.Number_of_keys);
            if (number_of_valid_keys >= am.Number_of_keys)
            {
                if (windowsPassword == null) windowsPassword = user.WindowsPassword;
                // no password from keys

                if (Abstractions.WindowsApi.pInvokes.ValidateCredentials(userInfo.Username, windowsPassword))
                {
                    userInfo.Password = windowsPassword;
                    if (logAttempt)
                    {
                        LogEntity loginAttempt = new LogEntity(user, am, keysUsed, true);
                        loginAttempt.Save();
                    }
                    return new BooleanResult { Success = true, Message = "Logged via: " + keysUsed };   
                }
                else
                    return new BooleanResult { Success = false, Message = "Authorized by MFLogin plugin but Windows Password is incorrect" };
            }
            else
            {
                if (logAttempt)
				{
					LogEntity failedLoginAttempt = new LogEntity(user, am, false);
					failedLoginAttempt.Save();
				}
                return new BooleanResult() { Success = false, Message = "This authentication method has failed" };
            }
        }

		public static BooleanResult Authenticate(UserInformation userInfo)
		{
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
                userInfo.Password = userInfo.OriginalPassword;
                BooleanResult amResult=TryAuthMethod(am[i], userInfo);
                // successful auth method puts Windows Password into userInfo
                if (amResult.Success) return amResult;
			}
            // case no auth method succeeded:
			return new BooleanResult { Success = false, Message = "MFLogin failed to authenticate you" };
		}
		
    }
}