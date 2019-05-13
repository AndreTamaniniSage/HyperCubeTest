using System;
using System.Configuration;
using System.IO;
using System.Reflection;
using Framework.Configuration;
using Framework.Interfaces;

namespace HyperCubeTest
{
    public class AppConfigReader : IConfig
    {
        ExeConfigurationFileMap config = new ExeConfigurationFileMap { ExeConfigFilename = "../../../App.config" };

        public BrowserType GetBrowser()
        {
            System.Configuration.Configuration configuration = ConfigurationManager.OpenMappedExeConfiguration(config, ConfigurationUserLevel.None);

            string browser = configuration.AppSettings.Settings[AppConfigKeys.Browser].Value;
            return (BrowserType)Enum.Parse(typeof (BrowserType), browser);
        }

        public string GetPassword()
        {
            System.Configuration.Configuration configuration = ConfigurationManager.OpenMappedExeConfiguration(config, ConfigurationUserLevel.None);
            return configuration.AppSettings.Settings[AppConfigKeys.Password].Value;
        }

        public string GetUsername()
        {
            System.Configuration.Configuration configuration = ConfigurationManager.OpenMappedExeConfiguration(config, ConfigurationUserLevel.None);
            return configuration.AppSettings.Settings[AppConfigKeys.Username].Value;
        }

        public string GetWebSite()
        {
            System.Configuration.Configuration configuration = ConfigurationManager.OpenMappedExeConfiguration(config, ConfigurationUserLevel.None);
            return configuration.AppSettings.Settings[AppConfigKeys.Website].Value;
        }
    }    
}