using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakTime.Interfaces
{
    public interface ISettingsIO
    {
        string SettingsPath { get; set; }
        void SaveSetting(ISettingsStorage settingsStorage);
        ISettingsStorage LoadSettings();
    }
}
