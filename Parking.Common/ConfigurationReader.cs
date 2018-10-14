using System.IO;
using Newtonsoft.Json;

namespace Parking.Common
{
    public sealed class ConfigurationReader
    {
        private const string configurationFileName = "DeviceConfig.json";
        private static readonly string ConfigFilePath = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase.Substring(8)), configurationFileName);

        private static TDClientSetting tDClientSetting = null;
        private static readonly object fileLock = new object();
      
        public static TDClientSetting GetConfigurationSettings()
        {
            try
            {
                lock (fileLock)
                {
                    if (tDClientSetting != null) return tDClientSetting;
                                       
                    if (!File.Exists(Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase.Substring(8)), "DeviceConfig.json")))
                    {
                        tDClientSetting = new TDClientSetting();
                    }
                    using (StreamReader reader = new StreamReader(ConfigFilePath))
                    {
                        tDClientSetting = JsonConvert.DeserializeObject<TDClientSetting>(reader.ReadToEnd());
                    }
                }                
            }
            catch (System.Exception e)
            {
                FileLogger.Log($"Configuration settings could not be loaded successfully as : {e.Message}");
                throw;
            }
            return tDClientSetting;
        }     
    }
}
