using System;
using System.Linq;
using System.Windows.Forms;
using static BreakTime.EventHandlers.SettingsViewEventHandler;

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
            DataBinders.BindSettings.BindControl(control: lblWorkMusicPath,  propertyName: "Text",  dataMemberName: "WorkSoundPath");
            DataBinders.BindSettings.BindControl(control: lblBreakMusicPath, propertyName: "Text",  dataMemberName: "BreakSoundPath");
            DataBinders.BindSettings.BindControl(control: volume1,           propertyName: "Value", dataMemberName: "Volume");
            DataBinders.BindSettings.BindControl(control: setTime1,          propertyName: "Time",  dataMemberName: "WorkTime");
            DataBinders.BindSettings.BindControl(control: setTime2,          propertyName: "Time",  dataMemberName: "BreakTime");
        }

        private void btnChooseSoundWork_Click(object sender, EventArgs e)
        {
            string chosenMusic = ChooseWorkMusicButtonClicked();
            if (chosenMusic is not null)
                lblWorkMusicPath.Text = chosenMusic;
        }

        private void btnChooseSoundBreak_Click(object sender, EventArgs e)
        {
            string chosenMusic = ChooseBreakMusicButtonClicked();
            if (chosenMusic is not null)
                lblBreakMusicPath.Text = chosenMusic;
        }

        private void btnSaveSettings_Click(object sender, EventArgs e) =>
            SaveSettingsClicked();

        private void WorkMusicPathChanged(object sender, EventArgs e) =>
            lblMusicWork.Text = ExtractFileNameFromPath(lblWorkMusicPath.Text);

        private void BreakMusicPathChanged(object sender, EventArgs e) =>
            lblMusicBreak.Text = ExtractFileNameFromPath(lblBreakMusicPath.Text);

        private string ExtractFileNameFromPath(string path) => 
            path.Split('\\').Last();
    }
}
