using System;
using System.IO;

namespace Parking.Common
{
    public class FileLogger
    {
        private static string filePath = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase.Substring(8)), "logs.txt");
        public static void Log(string message)
        {
            using (StreamWriter streamWriter = new StreamWriter(filePath))
            {
                try
                {
                    streamWriter.WriteLine(DateTime.Now + " :: " + message);
                    streamWriter.Close();
                }
                catch (System.Exception)
                {

                }
            }
        }
    }
}
