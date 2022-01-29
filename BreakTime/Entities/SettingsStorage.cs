using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using BreakTime.Interfaces;

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

        public SettingsStorage(int volume, string workTime, string breakTime, string workSoundPath, string breakSoundPath)
        {
            SetSettings(volume, workTime, breakTime, workSoundPath, breakSoundPath);
        }

        public SettingsStorage()
        {
            SetSettings(100, "010000", "000500", "", "");
        }

        public SettingsStorage(ISettingsStorage settings)
        {
            DuplicateSettings(settings);
        }

        public void SetSettings(int volume, string workTime, string breakTime, string workSoundPath, string breakSoundPath)
        {
            Volume = volume;
            WorkTime = workTime;
            BreakTime = breakTime;
            WorkSoundPath = workSoundPath;
            BreakSoundPath = breakSoundPath;
        }

        public void DuplicateSettings(ISettingsStorage settings)
        {
            Volume = settings.Volume;
            WorkTime = settings.WorkTime;
            BreakTime = settings.BreakTime;
            WorkSoundPath = settings.WorkSoundPath;
            BreakSoundPath = settings.BreakSoundPath;
        }

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
