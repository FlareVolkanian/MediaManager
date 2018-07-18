using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageTagII
{
    static class Application
    {
        public static Settings AppSettings { get; set; }
        public static string RootDir => Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\MediaManager";

        public static void LoadApplication()
        {
            if(!Directory.Exists(RootDir))
            {
                Directory.CreateDirectory(RootDir);
            }
            LoadSettings();
        }

        private static void LoadSettings()
        {
            try
            {
                if(File.Exists(RootDir + "\\Settings.json"))
                {
                    string data = File.ReadAllText(RootDir + "\\Settings.json");
                    AppSettings = Newtonsoft.Json.JsonConvert.DeserializeObject<Settings>(data);
                }
            }
            catch (Exception) { }
        }
    }
}
