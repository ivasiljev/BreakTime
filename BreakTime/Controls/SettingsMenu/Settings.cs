using System;
using System.Linq;
using System.Windows.Forms;
using static BreakTime.EventHandlers.SettingsViewEventHandler;
using BreakTime.Entities;
using System.ComponentModel;

namespace BreakTime
{
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
            BindControls();
        }

        private void BindControls()
        {
            DataBinders.BindSettings.BindControl(lblWorkMusicPath, "Text", "WorkSoundPath");
            DataBinders.BindSettings.BindControl(lblBreakMusicPath, "Text", "BreakSoundPath");
            DataBinders.BindSettings.BindControl(volume1, "Value", "Volume");
            DataBinders.BindSettings.BindControl(setTime1, "Time", "WorkTime");
            DataBinders.BindSettings.BindControl(setTime2, "Time", "BreakTime");
        }

        // Нажата кнопка выбора мелодии для окончания работы, выбирается музыкальный файл
        private void btnChooseSoundWork_Click(object sender, EventArgs e)
        {
            lblWorkMusicPath.Text = ChooseWorkMusicButtonClicked();
        }

        // Нажата кнопка выбора мелодии для окончания перерыва, выбирается музыкальный файл
        private void btnChooseSoundBreak_Click(object sender, EventArgs e)
        {
            lblBreakMusicPath.Text = ChooseBreakMusicButtonClicked();
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            SaveSettingsClicked();
        }

        private void WorkMusicPathChanged(object sender, EventArgs e)
        {
            lblMusicWork.Text = ExtractFileNameFromPath(lblWorkMusicPath.Text);
        }

        private void lblBreakMusicPath_TextChanged(object sender, EventArgs e)
        {
            lblMusicBreak.Text = ExtractFileNameFromPath(lblBreakMusicPath.Text);
        }

        private string ExtractFileNameFromPath(string path) => path.Split('\\').Last();
    }
}
