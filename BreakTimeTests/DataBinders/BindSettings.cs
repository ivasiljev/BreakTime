using BreakTime.Interfaces;
using System;
using System.ComponentModel;
using Xunit;

namespace BreakTimeTests.DataBinders
{
    public class BindSettings
    {
        public class SubscribeShould
        {
            [Fact]
            public void SaveSettingsStorage_WhenArgumentIsCorrect()
            {
                var correctArgument = new SettingsStorage();
                BreakTime.DataBinders.BindSettings.Subscribe(correctArgument);
            }

            [Fact]
            public void ThrowArgumentNullException_WhenArgumentIsNull()
            {
                Action func = new Action(SubscribeWithNullArgument);
                Assert.Throws<ArgumentNullException>(func);
            }

            private void SubscribeWithNullArgument()
            {
                ISettingsStorage input = null;
                BreakTime.DataBinders.BindSettings.Subscribe(input);
            } 
        }
        public class BindControlShould
        {
            [Fact]
            public void ThrowArgumentNullException_WhenInputArgumentIsNull()
            {
                BreakTime.DataBinders.BindSettings.Subscribe(new SettingsStorage());
                Action action = new Action(CallBindControlWithControlEqualsNull);
                Assert.Throws<ArgumentNullException>(action);
            }

            private void CallBindControlWithControlEqualsNull() => BreakTime.DataBinders.BindSettings.BindControl(null, "", "");
        }

        private class SettingsStorage : ISettingsStorage
        {
            int ISettingsStorage.Volume { get; set; }
            string ISettingsStorage.WorkTime { get; set; }
            string ISettingsStorage.BreakTime { get; set; }
            string ISettingsStorage.WorkSoundPath { get; set; }
            string ISettingsStorage.BreakSoundPath { get; set; }

            event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged
            {
                add
                {
                }

                remove
                {
                }
            }

            void ISettingsStorage.DuplicateSettings(ISettingsStorage settingsStorage)
            {
                throw new NotImplementedException();
            }
        }
    }
}
