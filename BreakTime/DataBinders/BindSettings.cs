using System;
using System.Windows.Forms;
using BreakTime.Interfaces;

namespace BreakTime.DataBinders
{
    public static class BindSettings
    {
        // Data object that we want to bind
        private static ISettingsStorage settingsStorage = null;

        // With this method you can bind any object that implements IBindableComponent to 'settingsStorage'
        public static void BindControl(IBindableComponent control, string propertyName, string dataMemberName)
        {
            if (settingsStorage == null) throw new NullReferenceException();
            if (control == null) throw new ArgumentNullException();
            control.DataBindings.Add(propertyName, settingsStorage, dataMemberName, false, DataSourceUpdateMode.OnPropertyChanged);
        }

        // Get link on data object that we want to bind and save it (settingsStorage have to implement ISettingsStorage)
        public static void Subscribe(ISettingsStorage settingsStorage)
        {
            BindSettings.settingsStorage = settingsStorage ?? throw new ArgumentNullException();
        }
    }
}
