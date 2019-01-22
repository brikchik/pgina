using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

using log4net;

using pGina.Shared.Interfaces;
using pGina.Shared.Types;
using pGina.Shared.Settings;

namespace pGina.Plugin.MFLoginPlugin
{
    public class MFLoginPlugin : IPluginConfiguration, IPluginAuthentication, IPluginAuthorization, IPluginAuthenticationGateway, IPluginChangePassword
    {
        private ILog m_logger = LogManager.GetLogger("MFLoginPlugin");
        public static Guid MFLoginPluginUuid = new Guid("{A633385F-BE0B-410C-9271-D80C215EC324}");
        private string m_Description = "A plugin for multi-factor authentication.";
        private dynamic m_settings = null;

        public MFLoginPlugin()
        {
            using (Process me = Process.GetCurrentProcess())
            {
                m_settings = new pGinaDynamicSettings(MFLoginPluginUuid);
                m_settings.SetDefault("ShowDescription", true);
                m_settings.SetDefault("Description", m_Description);

                m_logger.DebugFormat("Plugin initialized on {0} in PID: {1} Session: {2}", Environment.MachineName, me.Id, me.SessionId);
            }
        }

        public string Name
        {
            get { return "MFLogin"; }
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
            get { return MFLoginPluginUuid; }
        }

        BooleanResult IPluginAuthentication.AuthenticateUser(SessionProperties properties)
        {
            try
            {
                m_logger.DebugFormat("AuthenticateUser({0})", properties.Id.ToString());
                // Get user info
                UserInformation userInfo = properties.GetTrackedSingle<UserInformation>();
                m_logger.DebugFormat("Found username: {0}", userInfo.Username);
                //

                // auth code

                //
                m_logger.ErrorFormat("Failed to authenticate user: {0}", userInfo.Username);
                return new BooleanResult() { Success = false, Message = string.Format("Unable to log in") };
            }
            catch (Exception e)
            {
                m_logger.ErrorFormat("AuthenticateUser exception: {0}", e);
                throw;  // Allow pGina service to catch and handle exception
            }
        }
        BooleanResult IPluginAuthorization.AuthorizeUser(SessionProperties properties)
        {
            try
            {
                m_logger.DebugFormat("Authorize({0})", properties.Id.ToString());
                // Get user info
                UserInformation userInfo = properties.GetTrackedSingle<UserInformation>();
               
                return new BooleanResult() { Success = false, Message = string.Format("Not implemented") };
            }
            catch (Exception e)
            {
                m_logger.ErrorFormat("AuthorizeUser exception: {0}", e);
                throw;  // Allow pGina service to catch and handle exception
            }
        }
        BooleanResult IPluginAuthenticationGateway.AuthenticatedUserGateway(SessionProperties properties)
        {
            try
            {
                m_logger.DebugFormat("Processing gateway ({0})", properties.Id.ToString());
                return new BooleanResult() { Success = false, Message = string.Format("Not implemented") };
            }
            catch (Exception e)
            {
                m_logger.ErrorFormat("Gateway exception: {0}", e);
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
