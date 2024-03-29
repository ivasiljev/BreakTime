﻿using BreakTime.Interfaces;
using System;
using System.Windows.Forms;
using static BreakTime.EventHandlers.SettingsViewEventHandler;

namespace BreakTime.Logic
{
    /// <summary>
    /// Manages settings view logic. Reacts on clicking settings view buttons.
    /// </summary>
    public class SettingsView
    {
        private IMainLogic MainLogic;

        public SettingsView(IMainLogic mainLogic)
        {
            _ = mainLogic ?? throw new ArgumentNullException();
            MainLogic = mainLogic;
            OnChooseWorkMusicButtonClicked += ChooseWorkMusic;
            OnChooseBreakMusicButtonClicked += ChooseBreakMusic;
            OnSavingSettings += SaveSettings;
        }

        private void SaveSettings()
        {
            MainLogic.SaveSettings();
        }

        private string ChooseWorkMusic()
        {
            string chosenFilePath = OpenDialogAndChooseMusicFile();
            return chosenFilePath;
        }

        private string ChooseBreakMusic()
        {
            string chosenFilePath = OpenDialogAndChooseMusicFile();
            return chosenFilePath;
        }

        private string OpenDialogAndChooseMusicFile()
        {
            string ChosenFile = null;
            FileDialog fd = new OpenFileDialog();
            fd.Filter = "mp3 files | *.mp3";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                if (fd.CheckFileExists)
                {
                    ChosenFile = fd.FileName;
                }
            }
            return ChosenFile;
        }
    }
}
