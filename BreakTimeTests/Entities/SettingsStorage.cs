using System;
using Xunit;

namespace BreakTimeTests.Entities.SettingsStorage
{
    public class Should
    {
        [Fact]
        public void AssignClassPropertiesWithInputSettingsObject_WhenSettingsStoragePassed()
        {
            // Assign
            var inputSettings = new BreakTime.Entities.SettingsStorage();
            var input = (70, "a", "b", "c", "d");
            inputSettings.SetSettings(input.Item1, input.Item2, input.Item3, input.Item4, input.Item5);

            // Act
            var settings = new BreakTime.Entities.SettingsStorage(inputSettings);

            // Assert
            Assert.Equal(input.Item1, settings.Volume);
            Assert.Equal(input.Item2, settings.WorkTime);
            Assert.Equal(input.Item3, settings.BreakTime);
            Assert.Equal(input.Item4, settings.WorkSoundPath);
            Assert.Equal(input.Item5, settings.BreakSoundPath);
        }

        [Fact]
        public void ThrowArgumentNullException_WhenInputSettingsStorageIsNull()
        {
            // Assert

            // Act
            var action = new Action(() => new BreakTime.Entities.SettingsStorage(null));

            // Assert
            Assert.Throws<ArgumentNullException>(action);
        }
    }

    public class SetSettingsShould
    {
        [Fact]
        public void AssignClassPropertiesWithInputArguments_WhenInputArgumentsPassed()
        {
            // Assign
            var settings = new BreakTime.Entities.SettingsStorage();
            var input = (70, "a", "b", "c", "d");

            // Act
            settings.SetSettings(input.Item1, input.Item2, input.Item3, input.Item4, input.Item5);

            // Assert
            Assert.Equal(input.Item1, settings.Volume);
            Assert.Equal(input.Item2, settings.WorkTime);
            Assert.Equal(input.Item3, settings.BreakTime);
            Assert.Equal(input.Item4, settings.WorkSoundPath);
            Assert.Equal(input.Item5, settings.BreakSoundPath);
        }

        [Fact]
        public void AssignClassPropertiesWithInputSettingsObject_WhenSettingsStoragePassed()
        {
            // Assign
            var inputSettings = new BreakTime.Entities.SettingsStorage();
            var input = (70, "a", "b", "c", "d");
            inputSettings.SetSettings(input.Item1, input.Item2, input.Item3, input.Item4, input.Item5);
            var settings = new BreakTime.Entities.SettingsStorage();

            // Act
            settings.SetSettings(inputSettings);

            // Assert
            Assert.Equal(input.Item1, settings.Volume);
            Assert.Equal(input.Item2, settings.WorkTime);
            Assert.Equal(input.Item3, settings.BreakTime);
            Assert.Equal(input.Item4, settings.WorkSoundPath);
            Assert.Equal(input.Item5, settings.BreakSoundPath);
        }

        [Fact]
        public void ThrowArgumentNullException_WhenInputSettingsStorageIsNull()
        {
            // Assert
            var settings = new BreakTime.Entities.SettingsStorage();

            // Act
            var action = new Action(() => settings.SetSettings(null));

            // Assert
            Assert.Throws<ArgumentNullException>(action);
        }
    }
}
