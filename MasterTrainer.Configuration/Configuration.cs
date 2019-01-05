using System.Configuration;

namespace MasterTrainer.Configuration
{
    public static class Configuration
    {
        public static string GetAppSetting(string prefix, string setting, string fallback = null)
        {
            try
            {
                var appSetting = !string.IsNullOrWhiteSpace(prefix) ? $"{prefix}::{setting}" : setting;
                var value = ConfigurationManager.AppSettings[appSetting];
                return value ?? fallback;
            }
            catch (ConfigurationException)
            {
                return fallback;
            }
        }
    }
}
