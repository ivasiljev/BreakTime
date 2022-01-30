using System;

namespace BreakTime.EventHandlers
{
    /// <summary>
    /// Agregates events that provide communication between settings view and SettingsView.
    /// </summary>
    public static class SettingsViewEventHandler
    {
        /// <summary>
        /// Method that should be called when clicked button to choose 'work finished' music
        /// </summary>
        /// <returns>Path to music file that was chosen.</returns>
        public static string ChooseWorkMusicButtonClicked()
        {
            return OnChooseWorkMusicButtonClicked?.Invoke();
        }
        /// <summary>
        /// Raises the SettingsViewEventHandler.ChooseWorkMusicButtonClicked event.
        /// </summary>
        public static Func<string> OnChooseWorkMusicButtonClicked;

        /// <summary>
        /// Method that should be called when clicked button to choose 'break finished' music
        /// </summary>
        /// <returns>Path to music file that was chosen.</returns>
        public static string ChooseBreakMusicButtonClicked()
        {
            return OnChooseBreakMusicButtonClicked?.Invoke();
        }
        /// <summary>
        /// Raises the SettingsViewEventHandler.ChooseBreakMusicButtonClicked event.
        /// </summary>
        public static Func<string> OnChooseBreakMusicButtonClicked;

        /// <summary>
        /// Method that should be called when clicked button to save settings
        /// </summary>
        public static void SaveSettingsClicked()
        {
            OnSavingSettings?.Invoke();
        }
        /// <summary>
        /// Raises the SettingsViewEventHandler.SaveSettingsClicked event.
        /// </summary>
        public static Action OnSavingSettings;
    }
}
