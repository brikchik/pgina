// 
// Written by Gleb Rudometov
// github.com/brikchik
// under BSD 3-Clause License
// 2019
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

using log4net;

using pGina.Shared.Interfaces;
using pGina.Shared.Types;
using pGina.Shared.Settings;
using pGina.Plugin.MFLoginPlugin.Entities;

namespace pGina.Plugin.MFLoginPlugin
{
    public class MFLoginPlugin : IPluginConfiguration, IPluginAuthentication
    {
        private ILog m_logger = LogManager.GetLogger("MFLoginPlugin");
        public static Guid SimpleUuid = new Guid("{98EF7D32-20B2-421F-A68D-5BFA8E3BAFA6}");
        private string m_defaultDescription = "Multi-factor authentication plugin.";
        private dynamic m_settings = null;

        public MFLoginPlugin()
        {
            using(Process me = Process.GetCurrentProcess())
            {
                m_settings = new pGinaDynamicSettings(SimpleUuid);
				// bsic settings:
                m_settings.SetDefault("FirstRun",true);
                m_settings.SetDefault("Local", false);
				m_settings.SetDefault("LocalDatabasePath", "C:/Program Files/pGina.fork/MFLoginDB.db");
				m_settings.SetDefault("RemoteDatabasePath", "");
				m_settings.SetDefault("Description", m_defaultDescription);
                m_settings.SetDefault("DBPassword", new byte[] { });
				m_settings.SetDefault("DBPasswordSalt", new byte[] { });
				
                // advanced setings:
                m_settings.SetDefault("OnLoadBackupEnabled", true);
                m_settings.SetDefault("AlwaysCheckSelectedKey", false);
                m_settings.SetDefault("RequireAtLeastOneKeyInAuthMethod", false);
				m_settings.SetDefault("AlwaysOpenSummaryTabCollapsed", false);
				m_settings.SetDefault("ShowPGinaLogs", false);
                m_settings.SetDefault("MaxAuthTimeSeconds", 20); // for every auth method

                // key settings
                m_settings.SetDefault("AllowOnlyPairedBluetoothDevices", false);

				m_logger.DebugFormat("Plugin initialized on {0} in PID: {1} Session: {2}", Environment.MachineName, me.Id, me.SessionId);
            }
        }

        public string Name
        {
            get { return "MFLoginPlugin"; }
        }

        public string Description
        {
            get { return m_settings.Description; }
        }

        public string Version
        {
            get
            {
                return System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public Guid Uuid
        {
            get { return SimpleUuid; }
        }

        BooleanResult IPluginAuthentication.AuthenticateUser(SessionProperties properties)
        {
            try
            {
                m_logger.DebugFormat("AuthenticateUser({0})", properties.Id.ToString());
                // Get user info
                UserInformation userInfo = properties.GetTrackedSingle<UserInformation>();
                m_logger.DebugFormat("Found username: {0}", userInfo.Username);
                // Start authentication process
                BooleanResult success = AuthenticationManager.Authenticate(userInfo);
                if (success.Success)
                    m_logger.Info(success.Message);
                else
                    m_logger.ErrorFormat(success.Message);
                return success;
            }
            catch (Exception e)
            {
                m_logger.ErrorFormat("AuthenticateUser exception: {0}", e);
				return new BooleanResult { Success = false, Message=e.Message };  
				// Allow pGina service to show the exception
            }
        }

		public void Configure()
        {
			if ((bool)m_settings.FirstRun)
			{
				FirstRun fr = new FirstRun();
			}
			else
			{
				bool local = (bool)m_settings.Local;
				if (local)
				{
					LocalConfiguration conf = new LocalConfiguration();
					conf.ShowDialog();
				}
				else
				{
					BooleanResult connectionSuccess=DBHelper.ConnectToRemoteDB((string)m_settings.RemoteDatabasePath);
					if (!connectionSuccess.Success)
					{
						m_logger.Error("Unable to connect to remote database");
						FirstRun fr = new FirstRun();
					}
				}
			}
		}
        public void Starting() { }
        public void Stopping() { }
    }
}
