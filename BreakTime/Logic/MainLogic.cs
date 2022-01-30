using BreakTime.Interfaces;

namespace BreakTime.Logic
{
    /// <summary>
    /// <c>MainLogic</c> initializes objects, defines how different parts of code communicate between each other, 
    /// controls data access.
    /// </summary>
    public class MainLogic : IMainLogic
    {
        private SettingsView SettingsViewImp;
        private ISettingsStorage SettingsStorage;

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

        /// <summary>
        /// Saves stored settings.
        /// </summary>
        public void SaveSettings() => Model.SettingsIO.SaveSettings(new Entities.SettingsStorage(SettingsStorage));
    }
}
