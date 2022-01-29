using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace BreakTime.Model
{
    public static class SettingsIO
    {
        public static string SettingsPath { get; set; } = "Settings.json";

        public static void SaveSettings(Entities.SettingsStorage settings) => 
            SaveSettings(SettingsPath, settings);

        public static Entities.SettingsStorage LoadSettings() =>
            LoadSettings(SettingsPath) ?? new Entities.SettingsStorage();

        private static void SaveSettings(string filePath, Entities.SettingsStorage settings)
        {
            JsonSerializer serializer = new JsonSerializer();
            try
            {
                using (TextWriter textWriter = new StreamWriter(filePath))
                {
                    using (JsonWriter writer = new JsonTextWriter(textWriter))
                    {
                        serializer.Serialize(writer, settings);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private static Entities.SettingsStorage LoadSettings(string filePath)
        {
            Entities.SettingsStorage loadedSettings = null;

            JsonSerializer serializer = new JsonSerializer();
            try
            {
                using (TextReader textReader = new StreamReader(filePath))
                {
                    using (JsonReader reader = new JsonTextReader(textReader))
                    {
                        loadedSettings = (Entities.SettingsStorage)serializer.Deserialize(reader, typeof(Entities.SettingsStorage));
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return loadedSettings;
        }
    }
}
