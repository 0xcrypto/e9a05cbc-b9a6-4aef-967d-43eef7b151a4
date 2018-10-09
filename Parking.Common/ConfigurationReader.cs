using System.IO;
using Newtonsoft.Json;

namespace Parking.Common
{
    public sealed class ConfigurationReader
    {
        private static ConfigurationReader configurationReader = null;
        private const string configurationFileName = "DeviceConfig.json";
        private readonly string ConfigFilePath = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase.Substring(8)), configurationFileName);
        private ConfigurationReader()
        {

        }

        public TDClientSetting GetConfigurationSettings()
        {
            TDClientSetting setting = null;
            try
            {
                if (!File.Exists(Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase.Substring(8)), "DeviceConfig.json")))
                {
                    setting = new TDClientSetting();
                }

                using (StreamReader reader = new StreamReader(ConfigFilePath))
                {
                    setting = JsonConvert.DeserializeObject<TDClientSetting>(reader.ReadToEnd());
                }
            }
            catch (System.Exception e)
            {
                FileLogger.Log($"Configuration settings could not be loaded successfully as : {e.Message}");
                throw;
            }

            return setting;

        }
        public static ConfigurationReader Instance
        {
            get
            {
                if (configurationReader == null)
                {
                    configurationReader = new ConfigurationReader();
                }
                return configurationReader;
            }
        }
    }
}
