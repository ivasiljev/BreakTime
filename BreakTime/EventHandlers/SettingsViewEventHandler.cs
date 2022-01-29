using System;

namespace BreakTime.EventHandlers
{
    public static class SettingsViewEventHandler
    {
        public static string ChooseWorkMusicButtonClicked()
        {
            return OnChooseWorkMusicButtonClicked?.Invoke();
        }
        public static Func<string> OnChooseWorkMusicButtonClicked;


        public static string ChooseBreakMusicButtonClicked()
        {
            return OnChooseBreakMusicButtonClicked?.Invoke();
        }
        public static Func<string> OnChooseBreakMusicButtonClicked;


        public static void SaveSettingsClicked()
        {
            OnSavingSettings?.Invoke();
        }
        public static Action OnSavingSettings;
    }
}
