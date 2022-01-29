using System.ComponentModel;

namespace BreakTime.Interfaces
{
    public interface ISettingsStorage : INotifyPropertyChanged
    {
        int Volume { get; set; }
        string WorkTime { get; set; }
        string BreakTime { get; set; }
        string WorkSoundPath { get; set; }
        string BreakSoundPath { get; set; }

        void DuplicateSettings(ISettingsStorage settingsStorage);
    }
}
