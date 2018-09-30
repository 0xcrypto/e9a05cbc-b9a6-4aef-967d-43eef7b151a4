using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Parking.Common
{
    public class ConfigurationReader
    {
        private string ConfigFilePath { get; set; }

        public ConfigurationReader(string folder, string file)
        {
            ConfigFilePath = Path.Combine(Path.GetDirectoryName(folder), file);
        }

        public TDClientSetting Load()
        {
            TDClientSetting setting = null;

            if (!Directory.Exists(ConfigFilePath))
            {
                setting = new TDClientSetting();
            }

            using (StreamReader reader = new StreamReader(ConfigFilePath))
            {
                setting = JsonConvert.DeserializeObject<TDClientSetting>(reader.ReadToEnd());
            }

            return setting;
        }
    }
}
