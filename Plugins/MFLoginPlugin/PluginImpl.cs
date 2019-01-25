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
    public class MFLoginPlugin : IPluginConfiguration, IPluginAuthentication, IPluginChangePassword
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
                if (AuthenticationManager.Authenticate(userInfo))
                    return new BooleanResult() { Success = true };
                else
                {
                    m_logger.ErrorFormat("Failed to authenticate user: {0}", userInfo.Username);
                    return new BooleanResult() { Success = false, Message = string.Format("Failed to authenticate") };
                }
            }
            catch (Exception e)
            {
                m_logger.ErrorFormat("AuthenticateUser exception: {0}", e);
                throw;  // Allow pGina service to catch and handle exception
            }
        }

        public void Configure()
        {
            Configuration conf = new Configuration();
            conf.ShowDialog();
        }

        public void Starting() { }
        public void Stopping() { }

        public BooleanResult ChangePassword(SessionProperties properties, ChangePasswordPluginActivityInfo pluginInfo)
        {
            return new BooleanResult() { Success = false, Message = "Not implemented" };
        }
    }
}
