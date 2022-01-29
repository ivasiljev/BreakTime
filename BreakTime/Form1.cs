using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WMPLib;

namespace BreakTime
{
    public partial class BreakTimeForm : Form
    {
        // Файлы, где сохраняются настройки программы
        const string pathToTimeTXT = "time.txt";
        const string pathToMusicTXT = "music.txt";

        // Возможные состояния окна программы (режимы настроек и работы)
        public enum Mode
        {
            Work,
            Setting
        }

        // Возможные состояния таймера
        public enum State
        {
            Idle = 0,
            Work = 1,
            Break = 2
        }

        // Cостояние таймера
        State programState;
        State ProgramState
        {
            get
            {
                return programState;
            }
            set
            {
                logger.Write("Program state changed from " + ProgramState.ToString() + " to " + value.ToString(), Logger.Layers.ProgramState);

                programState = value;
            }
        }

        // Истинна, если во время работы таймера, нажата кнопка паузы
        bool pause = false;
        bool Pause
        {
            get
            {
                return pause;
            }
            set
            {
                logger.Write((value ? "Pause on" : "Pause off"), Logger.Layers.Timer);

                pause = value;
            }
        }
        // Продолжительности перерыва и работы соответственно, получаются из файла, если файл существует
        string breakTime = "000000";
        string workTime = "000000";
        // Истинна, если включен звук 
        bool sounds = true;
        bool Sounds
        {
            get
            {
                return sounds;
            }
            set
            {
                logger.Write((value ? "Sounds on" : "Sounds off"), Logger.Layers.MediaPlayer);

                sounds = value;
            }
        }
        // Пути до музыкальных файлов для звуков конца таймеров перерыва и работы соответственно
        string breakFinishedSound;
        string workFinishedSound;
        // Проигрыватель
        WindowsMediaPlayer myPlayer = new WindowsMediaPlayer();
        // Логгер программы
        public Logger logger = new Logger();

        public BreakTimeForm()
        {
            InitializeComponent();

            logger.AddDisabledLayer(Logger.Layers.Hotkeys);
            logger.AddDisabledLayer(Logger.Layers.FormLayers);

            ProgramState = State.Idle;

            // Создаем верхнее меню
            createMenuStrip();

            // Создание события на горячие клавиши (при нажатии горячих клавишь вызывается hook_KeyPressed)
            KeyboardHook hook = new KeyboardHook();
            hook.AddLogger(logger);
            hook.KeyPressed += new EventHandler<KeyPressedEventArgs>(hook_KeyPressed);
            hook.RegisterHotKey(ModKey.Alt, Keys.B); // Регистрируем необходимые нам горячие клавиши
            hook.RegisterHotKey(ModKey.Alt, Keys.W); // Регистрируем необходимые нам горячие клавиши

            // Начальное состояние программы это - рабочее окно
            turnOnMode(Mode.Work);

            // Получаем из файлов время и музыку
            getTimeFromTXT();
            getMusicFromTXT();

            hideForm();
        }

        // Событие на закрытие главной формы. Вместо закрытия программы сворачиваем ее в трей
        private void BreakTime_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)   // Сворачиваем в трей только, если это пользователь пытается закрыть программу
            {
                turnOnMode(Mode.Work);                      // Переходим в рабочий режим программы
                hideForm();
                e.Cancel = true;                            // Отменяем выключение программы
            }
        }



        // Создаем верхнее меню с выпадающими списками
        private void createMenuStrip()
        {
            ToolStripMenuItem menuItem = new ToolStripMenuItem("Меню");
            ToolStripItem soundsOn = new ToolStripMenuItem("Звуки") { Checked = true, CheckOnClick = true };
            soundsOn.Click += звукиToolStripMenuItem1_Click;
            menuItem.DropDownItems.Add(soundsOn);
            ToolStripItem exitItem = menuItem.DropDownItems.Add("Выход");
            exitItem.Click += выходToolStripMenuItem1_Click;
            menuStrip1.Items.Add(menuItem);

            ToolStripMenuItem modeItem = new ToolStripMenuItem("Режим");
            modeItem.Name = "tsmItemMode";  // Задаем имена элементами, чтобы их можно было легко найти по имени
            ToolStripItem workItem = new ToolStripMenuItem("Работа") { Checked = true};
            workItem.Name = "tsmItemWork";
            workItem.Click += работаToolStripMenuItem_Click;
            modeItem.DropDownItems.Add(workItem);
            ToolStripItem manageTimeItem = new ToolStripMenuItem("Настройка") { Checked = false };
            manageTimeItem.Name = "tsmItemManage";
            manageTimeItem.Click += установкаВремениToolStripMenuItem_Click;
            modeItem.DropDownItems.Add(manageTimeItem);
            menuStrip1.Items.Add(modeItem);
        }



        // Получаем время(продолжительность работы и перерыва) из текстового файла
        private void getTimeFromTXT()
        {
            string text = "Work time=\r\nBreak time=";                                                      // Содержимое файла по умолчанию
            if (File.Exists(pathToTimeTXT))                                                                 // Если файл существует 
            {
                using (FileStream fs = new FileStream(pathToTimeTXT, FileMode.Open, FileAccess.Read))       // Считываем из файла содержимое
                {
                    byte[] array = new byte[fs.Length];
                    fs.Read(array, 0, array.Length);
                    text = System.Text.Encoding.Default.GetString(array);
                    text = text.Replace("\r", "");                                                          // Убираю мешающий символ (каждый enter - \r\n, достаточно оставить только \n)
                    string[] splitedStrings = text.Split('\n', '=');                                        // Далее вычлиняются из текста файла нужные параметры

                    if (splitedStrings[1] != "")
                    {
                        workTime = splitedStrings[1];                                                       // И записываются в соответствующие переменные
                    }
                    if (splitedStrings[3] != "")
                    {
                        breakTime = splitedStrings[3];
                    }

                    logger.Write("File " + pathToTimeTXT + " exists. Successful read." , Logger.Layers.File);
                }
            }
            else                                                                                            // Если такого файла нет
            {
                using (FileStream fs = new FileStream(pathToTimeTXT, FileMode.CreateNew, FileAccess.Write)) // Создаем файл и записываем в него содержимое по умолчанию
                {
                    byte[] array = System.Text.Encoding.Default.GetBytes(text);
                    fs.Write(array, 0, array.Length);

                    logger.Write("File " + pathToTimeTXT + " doesn't exist. File was created with text: " + text, Logger.Layers.File);
                }
            }
        }

        // Сохраняем время(продолжительность работы и перерыва) в текстовый файл
        private void putTimeToTXT()
        {
            // Содержимое файла по умолчани
            string text = string.Concat(
                "Work time=", workTime, "\r\n", 
                "Break time=", breakTime);
            using (FileStream fs = new FileStream(pathToTimeTXT, FileMode.OpenOrCreate, FileAccess.Write))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(text);
                fs.Write(array, 0, array.Length);

                logger.Write("File " + pathToTimeTXT + " was open or created. Successful write.", Logger.Layers.File);
            }
        }

        // Получаем музыку(громкость звуков, расположение файлов звуков окончания перерыва и работы) из текстового файла
        private void getMusicFromTXT()
        {
            string text = "Volume=50\r\nWork finished sound=\r\nBreak finished sound=";                 // Содержимое файла по умолчанию
            if (File.Exists(pathToMusicTXT))                                                            // Если файл существует
            {
                using (FileStream fs = new FileStream(pathToMusicTXT, FileMode.Open, FileAccess.Read))  // Считываем из него весь текст
                {
                    byte[] array = new byte[fs.Length];
                    fs.Read(array, 0, array.Length);
                    text = System.Text.Encoding.Default.GetString(array);
                    text = text.Replace("\r", "");
                    string[] splitedStrings = text.Split('\n', '=');                                    // Вычлиняю из текста нужные мне части

                    if (splitedStrings[1] != "")
                    {
                        int result;
                        if (int.TryParse(splitedStrings[1], out result))                                // Пробуем преобразовать текст в число
                        {
                            tbVolume.Value = result;                                                    // Если получилось сохраняеи
                            myPlayer.settings.volume = result;
                        }
                        else                                                                            // Иначе выдаем ошибку с порядком действий для решения проблемы
                        {
                            logger.Write("Unable to read \"Volume\" from file: " + pathToMusicTXT, Logger.Layers.File);

                            MessageBox.Show("Ошибка чтения громкости звука из файла. Для исправления ошибки зайдите в настройки и нажмите кнопку \"Сохранить\" или удалите файл music.txt");
                        }
                    }
                    if (splitedStrings[3] != "")
                    {
                        workFinishedSound = splitedStrings[3];
                        string[] fileName = workFinishedSound.Split('\\');                              // Вычленяем из пути к файлу его имя 
                        lblMusicWork.Text = fileName[fileName.Length - 1];                              // и выводим его в поле на экране
                    }
                    if (splitedStrings[5] != "")
                    {
                        breakFinishedSound = splitedStrings[5];
                        string[] fileName = breakFinishedSound.Split('\\');
                        lblMusicBreak.Text = fileName[fileName.Length - 1];
                    }

                    logger.Write("File " + pathToMusicTXT + " exists. Successful read.", Logger.Layers.File);
                }
            }
            else                                                                                        // Если же файл не существует, то создаем его 
            {                                                                                           // и записываем в него содержимое по умолчанию
                using (FileStream fs = new FileStream(pathToMusicTXT, FileMode.CreateNew, FileAccess.Write))
                {
                    byte[] array = System.Text.Encoding.Default.GetBytes(text);
                    fs.Write(array, 0, array.Length);

                    logger.Write("File " + pathToMusicTXT + " doesn't exist. File was created with text: " + text, Logger.Layers.File);
                }
            }
        }

        // Сохраняем музыку(громкость звуков, расположение файлов звуков окончания перерыва и работы) в текстовый файл
        private void putMusicToTXT()
        {
            // Содержимое файла по умолчанию
            string text = string.Concat(
                "Volume=", tbVolume.Value.ToString(), "\r\n", 
                "Work finished sound=", workFinishedSound, "\r\n", 
                "Break finished sound=", breakFinishedSound);
            using (FileStream fs = new FileStream(pathToMusicTXT, FileMode.Create, FileAccess.Write))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(text);
                fs.Write(array, 0, array.Length);

                logger.Write("File " + pathToTimeTXT + " was open or created. Successful write.", Logger.Layers.File);
            }
        }



        // Событие на горячие клавиши
        public void hook_KeyPressed(object sender, KeyPressedEventArgs e)
        {
            if (e.Modifier == ModKey.Alt)
            {
                if (e.Key == Keys.W)            // Если нажата комбинация Alt + W 
                    startState(State.Work);     // включаем таймер работы
                if (e.Key == Keys.B)            // Если нажата комбинация Alt + B
                    startState(State.Break);    // включаем таймер перерыва
            }
            logger.Write("Hotkey " + e.Modifier.ToString() + " + " + e.Key.ToString() + " pressed", Logger.Layers.Hotkeys);
        }

        

        // Полностью закрываем программу
        private void closeApplication()
        {
            notifyIcon1.Visible = false;            // Убираем иконку программы из трея
            myPlayer.close();                       // Выключаем плеер

            logger.Write("Command to close application", Logger.Layers.Program);

            Application.Exit();                     // Закрываем программу
        }
        
        private void hideForm()
        {
            this.Hide();                                // Скрываем форму с экрана
            notifyIcon1.Visible = true;                 // Включаем отображение иконки программы в трее
        }

        // Реализуется переход между вкладками формы (между режимом настроек и режимом работы)
        private void turnOnMode(Mode mode)
        {
            logger.Write(mode + " mode is on", Logger.Layers.FormLayers);

            bool bWork = (mode == Mode.Work);

            // В верхнем выпадающем меню выставляем галочку, что включен режим настроек и выключен рабочий режим
            int indexMode = menuStrip1.Items.IndexOfKey("tsmItemMode");
            int indexWork = ((ToolStripMenuItem)menuStrip1.Items[indexMode]).DropDownItems.IndexOfKey("tsmItemWork");
            ((ToolStripMenuItem)((ToolStripMenuItem)menuStrip1.Items[indexMode]).DropDownItems[indexWork]).Checked = bWork;
            int indexManage = ((ToolStripMenuItem)menuStrip1.Items[indexMode]).DropDownItems.IndexOfKey("tsmItemManage");
            ((ToolStripMenuItem)((ToolStripMenuItem)menuStrip1.Items[indexMode]).DropDownItems[indexManage]).Checked = !bWork;

            for (int i = 0; i < this.Controls.Count; i++)                                               // Перебираем все элементы на форме
            {
                if (this.Controls[i].Tag != null && this.Controls[i].Tag.ToString() != (bWork ? "Work" : "SettingTime"))   // если тег не пустой и не соответствует включенному режиму
                    this.Controls[i].Visible = false;                                                   // то скрываем с формы этот элемент
                else                                                                                    // иначе включаем видимость элемента
                    if (!this.Controls[i].Visible)
                    this.Controls[i].Visible = true;

                logger.Write(Controls[i].ToString() + " (" + Controls[i].Name + ") become " + (Controls[i].Visible == true ? "visible" : "invisible"), Logger.Layers.FormLayers);
            }

            if (!bWork)
            {
                // Выставляем нужное время на счетчиках
                numericUpDownMyDesign1.time.Text = workTime.Substring(0, 2);
                numericUpDownMyDesign2.time.Text = workTime.Substring(2, 2);
                numericUpDownMyDesign3.time.Text = workTime.Substring(4, 2);
                numericUpDownMyDesign4.time.Text = breakTime.Substring(0, 2);
                numericUpDownMyDesign5.time.Text = breakTime.Substring(2, 2);
                numericUpDownMyDesign6.time.Text = breakTime.Substring(4, 2);
            }
        }
        
        private void startState(State newState)
        {
            if (newState == State.Break || newState == State.Work)
            {
                if (pause) toPause();
                btnPause.Enabled = true;                                                    // Кнопка паузы таймера становится доступна

                bool bStateBreak = newState == State.Break;
                string activeTime = (bStateBreak ? breakTime : workTime);
                ProgramState = newState;                                                    // Перевод таймера в режим перерыва
                timerPanel.ForeColor = (bStateBreak ? Color.YellowGreen : Color.Crimson);   // Окрашиваем текст на панели в цвет режима работы
                lblTimerTitle.Text = (bStateBreak ? "Перерыв" : "Работа");                  // Выводим для пользователя активный режим
                lblHours.Text = activeTime.Substring(0, 2);                                 // Выставляем время на таймере
                lblMinutes.Text = activeTime.Substring(2, 2);                               //
                lblSeconds.Text = activeTime.Substring(4, 2);                               //
                timer1.Start(logger);                                                       // Запускаем таймер
            }
            else
            {
                string errorMessage = "Упс. Возникла непредвиденная ошибка";
                logger.Write(this.ToString() + ", MyDialogResult| Error message: " + errorMessage, Logger.Layers.Error);

                MessageBox.Show(errorMessage);
            }
        }

        // Сбрасывает текущее значение таймера и переводит его в режим ожидания
        private void reset()
        {
            ProgramState = State.Idle;
            timerPanel.ForeColor = Color.FromArgb(64, 64, 64);
            lblTimerTitle.Text = "Таймер";
            btnPause.Enabled = false;
            lblHours.Text = "00";
            lblMinutes.Text = "00";
            lblSeconds.Text = "00";
            if (Pause) toPause();
            timer1.Stop(logger);
            notifyIcon1.Text = "Break Time";
        }

        // Действие, чтобы снять/поставить паузу на таймере
        private void toPause()
        {
            Pause = !Pause;
            if (Pause)
            {
                timer1.Stop(logger);
                btnPause.BackColor = Color.Crimson;
            }
            else
            {
                timer1.Start(logger);
                btnPause.BackColor = Color.WhiteSmoke;
            }
        }

        // Событие на шаг таймера (шаг установлен в 1 сек)
        private void timer1_Tick(object sender, EventArgs e)
        {
            int seconds = Convert.ToInt32(lblSeconds.Text);             // Получаем значение секунд таймера
            if (seconds % 5 == 0)
                notifyIcon1.Text = (lblHours.Text + ":" + lblMinutes.Text + ":" + lblSeconds.Text);
            seconds--;                                                  // уменьшаем секунды на 1
            if (seconds < 0)                                            // если значение секунд стало меньше 0
            {
                seconds = 59;                                           // то выставляем секунды равными 59
                int minutes = Convert.ToInt32(lblMinutes.Text);         // получаем значение минут
                minutes--;                                              // уменьшаем минуты на 1
                if (minutes < 0)                                        // если значение минут стало меньше 0
                {
                    minutes = 59;                                       // то выставляем минуты равными 59
                    int hours = Convert.ToInt32(lblHours.Text);         // получаем значение часов
                    hours--;                                            // уменьшаем часы на 1
                    if (hours < 0)                                      // если значение часов стало меньше 0
                    {                                                   // то время на таймере закончилось и значения
                        seconds = 0;                                    // секунд,
                        minutes = 0;                                    // минут,
                        hours = 0;                                      // часов выствляем по 0
                                                                        // если текущее состояние таймера - работа или перерыв
                        if (ProgramState == State.Work || programState == State.Break)  
                        {
                            TimeIsOver(programState);                   // вызываем функцию на окончание таймера
                            return;
                        }
                        else                                            // если по какой-то причине таймер находится в состояние ожидание или в неизвестном нам состоянии
                        {
                            string errorMessage = "Упс. Что-то пошло не так";
                            logger.Write(this.ToString() + ", timer1_Tick| Error message: " + errorMessage, Logger.Layers.Error);

                            MessageBox.Show(errorMessage);
                        }
                    }
                    lblHours.Text = hours.ToString();                   // выводим значение часов на экран
                    if (lblHours.Text.Length == 1)
                        lblHours.Text = "0" + lblHours.Text;
                }
                lblMinutes.Text = minutes.ToString();                   // выводим значение минут на экран
                if (lblMinutes.Text.Length == 1)
                    lblMinutes.Text = "0" + lblMinutes.Text;
            }
            lblSeconds.Text = seconds.ToString();                       // выводим значение секунд на экран
            if (lblSeconds.Text.Length == 1)
                lblSeconds.Text = "0" + lblSeconds.Text;
        }

        // Вызывается, когда время на таймере закончилось
        private void TimeIsOver(State state)
        {
            bool workState = (state == State.Work);
            string currentSound = (workState ? workFinishedSound : breakFinishedSound);

            reset();                                        // сбрасываем значение таймера
            if (Sounds && currentSound != null)             // Если звук включен и путь до музыкального файла не пуст
            {
                logger.Write("URL = " + currentSound, Logger.Layers.MediaPlayer);
                myPlayer.URL = currentSound;                // передаем плееру путь до музыки
                logger.Write("Play music", Logger.Layers.MediaPlayer);
                myPlayer.controls.play();                   // и воспроизводим ее
            }

            logger.Write("Создание MyDialog", Logger.Layers.Program);
            MyDialog md = new MyDialog(                     // Создаем диалоговое окно
                (workState ? "Время работы закончилось" : "Время перерыва закончилось"),
                (workState ? "Нужен перерыв. Начать перерыв сейчас?" : "Нужно приступить к работе. Начать работать сейчас?"),
                (workState ? "Отдыхать" : "Работать"),
                (workState ? State.Break : State.Work));
            md.Owner = this;                                // задаем текущую форму, как родительскую для диалогового окна
            md.ShowDialog();                                // вызываем отображение на экран диалогового окна
        }
        
        // При окончании времени на таймере вызывается диалоговое окно. При нажатии НЕ кнопки "Отмена" в диалогово окне вызывается данная функция, 
        // в которую передается в какое состояние должен перейти таймер и вызывается функция перехода в это состояние
        public void MyDialogResult(State state)
        {
            startState(state);
        }


        //-----------------------Меню программы в трее------------------------------
        #region
        // Пункт "Развернуть" из меню программы в трее. Разворачивает окно программы из трея
        private void развернутьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logger.Write(развернутьToolStripMenuItem.ToString() + " (" + развернутьToolStripMenuItem.Name + ") pressed", Logger.Layers.Click);
            logger.Write("Show form", Logger.Layers.Program);

            this.Show();                        // Включаем отображение формы
            logger.Write("Tray icon become invisible", Logger.Layers.TrayIcon);
            notifyIcon1.Visible = false;        // Убираем иконку программы из трея
        }

        // Пункт "выход" из меню программы в трее. Завершает работу программы 
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logger.Write(выходToolStripMenuItem.ToString() + " (" + выходToolStripMenuItem.Name + ") pressed", Logger.Layers.Click);

            closeApplication();
        }
        #endregion
        //-----------------------Верхнее выпадающее меню------------------------------
        #region
        // Пункт "Звуки" из верхнего меню программы. Включает/выключает звуки программы
        private void звукиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            logger.Write("(звукиToolStripMenuItem1) pressed", Logger.Layers.Click);
            
            Sounds = !Sounds;
            if (!Sounds) myPlayer.controls.stop();
        }

        // Пункт "Выход" из верхнего меню программы. Завершает работу программы
        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            logger.Write("(выходToolStripMenuItem1) pressed", Logger.Layers.Click);

            closeApplication();
        }


        // Пункт "Работа" из верхнего меню программы. Вызываем функцию отображения интерфейса рабочего режима
        private void работаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logger.Write("(работаToolStripMenuItem) pressed", Logger.Layers.Click);
            
            turnOnMode(Mode.Work);
        }

        // Пункт "Настройка" из верхнего меню программы. Вызываем функцию отображения интерфейса режима настройки
        private void установкаВремениToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logger.Write("(установкаВремениToolStripMenuItem) pressed", Logger.Layers.Click);
            
            turnOnMode(Mode.Setting);
        }
        #endregion
        //-----------------------Элементы формы в рабочем режиме------------------------------
        #region
        // Нажата кнопка "Начать работу". Вызывает функцию запуска таймера рабочего времени
        private void btnStartWork_Click(object sender, EventArgs e)
        {
            logger.Write(btnStartWork.ToString() + " (" + btnStartWork.Name + ") pressed", Logger.Layers.Click);
            
            startState(State.Work);
        }

        // Нажата кнопка "Начать перерыв". Вызывает функцию запуска таймера времени перерыва
        private void btnStartBreak_Click(object sender, EventArgs e)
        {
            logger.Write(btnStartBreak.ToString() + " (" + btnStartBreak.Name + ") pressed", Logger.Layers.Click);

            startState(State.Break);
        }

        // Нажата кнопка "Сбросить". Вызывает функцию для сбрасывания таймера
        private void btnReset_Click(object sender, EventArgs e)
        {
            logger.Write(btnReset.ToString() + " (" + btnReset.Name + ") pressed", Logger.Layers.Click);

            reset();
        }

        // Нажата кнопка паузы
        private void btnPause_Click(object sender, EventArgs e)
        {
            logger.Write(btnPause.ToString() + " (" + btnPause.Name + ") pressed", Logger.Layers.Click);

            toPause();
        }
        #endregion
        //-----------------------Элементы формы в режиме настроек------------------------------
        #region
        // Нажата кнопка "Сохранить" из режима настроек. Сохраняет все настройки и возвращает в режим работы
        private void btnSaveTime_Click(object sender, EventArgs e)
        {
            logger.Write(btnSaveTime.ToString() + " (" + btnSaveTime.Name + ") pressed", Logger.Layers.Click);

            workTime = string.Concat(numericUpDownMyDesign1.time.Text, numericUpDownMyDesign2.time.Text, numericUpDownMyDesign3.time.Text);
            breakTime = string.Concat(numericUpDownMyDesign4.time.Text, numericUpDownMyDesign5.time.Text, numericUpDownMyDesign6.time.Text);
            putTimeToTXT();
            putMusicToTXT();
            turnOnMode(Mode.Work);
        }

        // Нажата кнопка выбора мелодии для окончания работы, выбирается музыкальный файл
        private void btnChooseSoundWork_Click(object sender, EventArgs e)
        {
            logger.Write(btnChooseSoundWork.ToString() + " (" + btnChooseSoundWork.Name + ") pressed", Logger.Layers.Click);

            FileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                if (fd.CheckFileExists)
                {
                    workFinishedSound = fd.FileName;
                    string[] fileName = workFinishedSound.Split('\\');
                    lblMusicWork.Text = fileName[fileName.Length - 1];
                }
            }
        }

        // Нажата кнопка выбора мелодии для окончания перерыва, выбирается музыкальный файл
        private void btnChooseSoundBreak_Click(object sender, EventArgs e)
        {
            logger.Write(btnChooseSoundBreak.ToString() + " (" + btnChooseSoundBreak.Name + ") pressed", Logger.Layers.Click);

            FileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                if (fd.CheckFileExists)
                {
                    breakFinishedSound = fd.FileName;
                    string[] fileName = breakFinishedSound.Split('\\');
                    lblMusicBreak.Text = fileName[fileName.Length - 1];
                }
            }
        }

        // Событие на передвежение ползунка изменения громкости звуков
        private void tbVolume_ValueChanged(object sender, EventArgs e)
        {
            logger.Write(tbVolume.ToString() + " (" + tbVolume.Name + ") pressed", Logger.Layers.Click);

            lblVolume.Text = tbVolume.Value.ToString();         // Изменяем цифру под трекбаром
            myPlayer.settings.volume = tbVolume.Value;          // Изменяем громкость мелодии плеера
        }
        #endregion
    }

    public static class ExtensionsMethods
    {
        public static void Start(this Timer timer, Logger logger)
        {
            logger.Write("Start timer", Logger.Layers.Timer);

            timer.Start();
        }

        public static void Stop(this Timer timer, Logger logger)
        {
            logger.Write("Stop timer", Logger.Layers.Timer);

            timer.Stop();
        }

        
    }
}
