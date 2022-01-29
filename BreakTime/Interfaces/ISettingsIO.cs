namespace BreakTime.Interfaces
{
    public interface ISettingsIO
    {
        string SettingsPath { get; set; }
        void SaveSetting(ISettingsStorage settingsStorage);
        ISettingsStorage LoadSettings();
    }
}
