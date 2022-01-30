using System;
using System.Windows.Forms;
using BreakTime.Interfaces;

namespace BreakTime.DataBinders
{
    public static class BindSettings
    {
        /// <summary>
        /// Data object to bind.
        /// </summary>
        private static ISettingsStorage settingsStorage = null;

        /// <summary>
        /// Binds any object that implements <see cref="IBindableComponent"/> to <see cref="settingsStorage"/>.
        /// </summary>
        /// <param name="control">Object to bind.</param>
        /// <param name="propertyName">Name of property that <i>control</i> has.</param>
        /// <param name="dataMemberName">Name of property that <see cref="settingsStorage"/> has.</param>
        /// <exception cref="NullReferenceException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        public static void BindControl(IBindableComponent control, string propertyName, string dataMemberName)
        {
            if (settingsStorage == null) throw new NullReferenceException();
            if (control == null) throw new ArgumentNullException();
            control.DataBindings.Add(propertyName, settingsStorage, dataMemberName, false, DataSourceUpdateMode.OnPropertyChanged);
        }

        /// <summary>
        /// Gets link on data object to bind and save it.
        /// </summary>
        /// <param name="settingsStorage">Link on data object to bind.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void Subscribe(ISettingsStorage settingsStorage)
        {
            BindSettings.settingsStorage = settingsStorage ?? throw new ArgumentNullException();
        }
    }
}
