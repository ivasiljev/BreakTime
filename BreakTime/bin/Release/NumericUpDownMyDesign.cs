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
    public partial class NumericUpDownMyDesign : UserControl
    {
        private string _time = "00";

        public NumericUpDownMyDesign()
        {
            InitializeComponent();
        }

        private void time_TextChanged(object sender, EventArgs e)
        {
            int result;
            if (!int.TryParse(time.Text, out result) && time.Text != "" || time.Text.Length > 2)
                time.Text = _time;
        }

        private void checkConditionsForTime()
        {
            int result;
            if (int.TryParse(time.Text, out result))
            {
                if (result > 59)
                {
                    time.Text = "59";
                }
                else if (result < 0)
                {
                    time.Text = "00";
                }
                else
                {
                    if (time.Text.Length == 1)
                        time.Text = "0" + time.Text;
                    _time = time.Text;
                }
            }
            else
            {
                time.Text = _time;
            }
        }

        private void time_Leave(object sender, EventArgs e)
        {
            checkConditionsForTime();
        }

        private void up_Click(object sender, EventArgs e)
        {
            int iTime = Convert.ToInt32(time.Text);
            iTime++;
            if (iTime > 59) iTime = 0; else
            if (iTime < 0) iTime = 59;
            time.Text = (iTime < 10 ? "0" : "") + iTime.ToString();
        }

        private void down_Click(object sender, EventArgs e)
        {
            int iTime = Convert.ToInt32(time.Text);
            iTime--;
            if (iTime > 59) iTime = 0; else
            if (iTime < 0) iTime = 59;
            time.Text = (iTime < 10 ? "0" : "") + iTime.ToString();
        }

        private void time_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                checkConditionsForTime();
                System.Windows.Forms.SendKeys.Send("{TAB}");
            }
        }
    }
}
