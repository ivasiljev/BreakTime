namespace BreakTime.Logic
{
    public class MainLogic
    {
        private SettingsView SettingsViewImp;
        private Entities.SettingsStorage SettingsStorage;

        public MainLogic()
        {
            InitializeSettings();
        }

        private void InitializeSettings()
        {
            SettingsViewImp = new SettingsView(this);
            SettingsStorage = Model.SettingsIO.LoadSettings();
            DataBinders.BindSettings.Subscribe(SettingsStorage);
        }

        public void SaveSettings() => Model.SettingsIO.SaveSettings(new Entities.SettingsStorage(SettingsStorage));
    }
}
