using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreakTime
{
    public partial class TimeSetter : UserControl
    {
        private string time = "000000";

        public string Time { get => GetTime(); set => SetTime(value); }
        
        public void UpdateTime()
        {
            Time = timeHours.GetTime() + timeMinutes.GetTime() + timeSeconds.GetTime();
        }

        public string GetTime()
        {
            return (time = timeHours.GetTime() + timeMinutes.GetTime() + timeSeconds.GetTime());
        }

        public void SetTime(string time = "000000")
        {
            if (time.Length == 6 && int.TryParse(time, out int result))
            {
                this.time = time;
                timeHours.SetTime(time.Substring(0, 2));
                timeMinutes.SetTime(time.Substring(2, 2));
                timeSeconds.SetTime(time.Substring(4, 2));
            }
        }

        public TimeSetter()
        {
            InitializeComponent();
        }
    }
}
