using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

using log4net;

using pGina.Shared.Interfaces;
using pGina.Shared.Types;
using pGina.Shared.Settings;
//
// NOTE: pGina.fork plugins work with "pGina created" non-admin accounts by default!!!
// net user LOGIN PASSWORD /ADD /COMMENT:"pGina created"
//

namespace pGina.Plugin.MFLoginPlugin
{
    public class MFLoginPlugin : IPluginConfiguration, IPluginAuthentication, IPluginAuthorization
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
                m_settings.SetDefault("ShowDescription", true);
                m_settings.SetDefault("Description", m_defaultDescription);

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
                throw;  // Allow pGina service to catch and handle exception
            }
        }

		public BooleanResult AuthorizeUser(SessionProperties properties)
		{
			// We elect to not do any authorization, let the user pass for us
			return new BooleanResult() { Success = true };
		}

		public void Configure()
        {
            bool local = true;
            bool firstrun = false;
            // read settings
            //
            // get 'local' setting
            if (local) {
				LocalConfiguration conf = new LocalConfiguration();
			}
            else { FirstRun fr = new FirstRun(local, firstrun); }
        }

        public void Starting() { }
        public void Stopping() { }
    }
}
