using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace BreakTime.Model
{
    /// <summary>
    /// Static class <c>SettingsIO</c> allows to save and load <see cref="Interfaces.ISettingsStorage">ISettingsStorage</see>.
    /// </summary>
    public static class SettingsIO
    {
        /// <summary>
        /// Path to JSON file where settings are stored.
        /// </summary>
        public static string SettingsPath { get; set; } = "Settings.json";

        /// <summary>
        /// Saves <see cref="Interfaces.ISettingsStorage">ISettingsStorage</see> into file
        /// </summary>
        /// <param name="settings"><see cref="Interfaces.ISettingsStorage">ISettingsStorage</see> that stores settings to save.</param>
        public static void SaveSettings(Interfaces.ISettingsStorage settings) => 
            SaveSettings(SettingsPath, settings);

        /// <summary>
        /// Loads <see cref="Interfaces.ISettingsStorage">ISettingsStorage</see> from memory and returns it.
        /// </summary>
        /// <returns><see cref="Interfaces.ISettingsStorage">ISettingsStorage</see> that stores settings loaded from file.</returns>
        public static Interfaces.ISettingsStorage LoadSettings() =>
            LoadSettings(SettingsPath) ?? new Entities.SettingsStorage();

        private static void SaveSettings(string filePath, Interfaces.ISettingsStorage settings)
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
