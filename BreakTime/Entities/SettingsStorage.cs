using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using BreakTime.Interfaces;
using System;

namespace BreakTime.Entities
{
    [JsonObject(MemberSerialization.OptIn)]
    public class SettingsStorage : ISettingsStorage
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int _volume = 0;
        [JsonProperty]
        public int Volume
        {
            get => _volume;
            set
            {
                _volume = value;
                OnPropertyChanged("Volume");
            }
        }

        private string _workTime = "";
        [JsonProperty]
        public string WorkTime
        {
            get => _workTime;
            set
            {
                _workTime = value;
                OnPropertyChanged("WorkTime");
            }
        }

        private string _breakTime = "";
        [JsonProperty]
        public string BreakTime
        {
            get => _breakTime;
            set
            {
                _breakTime = value;
                OnPropertyChanged("BreakTime");
            }
        }

        private string _workSoundPath = "";
        [JsonProperty]
        public string WorkSoundPath
        {
            get => _workSoundPath;
            set
            {
                _workSoundPath = value;
                OnPropertyChanged("WorkSoundPath");
            }
        }

        private string _breakSoundPath = "";
        [JsonProperty]
        public string BreakSoundPath
        {
            get => _breakSoundPath;
            set
            {
                _breakSoundPath = value;
                OnPropertyChanged("BreakSoundPath");
            }
        }

        public SettingsStorage() => 
            SetSettings(volume: 100, workTime: "010000", breakTime: "000500", workSoundPath: "", breakSoundPath: "");

        public SettingsStorage(ISettingsStorage settings) => SetSettings(settings);

        public void SetSettings(int volume, string workTime, string breakTime, string workSoundPath, string breakSoundPath) =>
            (Volume, WorkTime, BreakTime, WorkSoundPath, BreakSoundPath) =
            (volume, workTime, breakTime, workSoundPath, breakSoundPath);

        public void SetSettings(ISettingsStorage settings)
        {
            if (settings is null) throw new ArgumentNullException();
            SetSettings(settings.Volume, settings.WorkTime, settings.BreakTime, settings.WorkSoundPath, settings.BreakSoundPath);
        }

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
