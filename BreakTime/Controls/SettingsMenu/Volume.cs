using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreakTime.SettingsMenu
{
    public partial class Volume : UserControl
    {
        private int _value = 0;
        public int Value { get => _value; set { _value = value; SetVolume(value); } }

        public Volume()
        {
            InitializeComponent();
        }

        public void SetVolume(int volume)
        {
            tbVolume.Value = volume;
            lblVolume.Text = volume.ToString();
        }

        private void OnVolumeChange(object sender, EventArgs e)
        {
            if (Value != tbVolume.Value)
            {
                Value = tbVolume.Value;
                lblVolume.Text = tbVolume.Value.ToString();
            }
        }
    }
}
