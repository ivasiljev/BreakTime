namespace BreakTime
{
    partial class BreakTimeForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BreakTimeForm));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.развернутьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStartWork = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStartBreak = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.режимToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.установкаВремениToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveTime = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timerPanel = new System.Windows.Forms.Panel();
            this.lblTimerTitle = new System.Windows.Forms.Label();
            this.btnPause = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.менюToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.режимToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.работаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиВремениToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnChooseSoundWork = new System.Windows.Forms.Button();
            this.btnChooseSoundBreak = new System.Windows.Forms.Button();
            this.lblMusicWork = new System.Windows.Forms.Label();
            this.lblMusicBreak = new System.Windows.Forms.Label();
            this.tbVolume = new System.Windows.Forms.TrackBar();
            this.lblVolume = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDownMyDesign6 = new BreakTime.NumericUpDownMyDesign();
            this.numericUpDownMyDesign5 = new BreakTime.NumericUpDownMyDesign();
            this.numericUpDownMyDesign4 = new BreakTime.NumericUpDownMyDesign();
            this.numericUpDownMyDesign3 = new BreakTime.NumericUpDownMyDesign();
            this.numericUpDownMyDesign2 = new BreakTime.NumericUpDownMyDesign();
            this.numericUpDownMyDesign1 = new BreakTime.NumericUpDownMyDesign();
            this.contextMenuStrip1.SuspendLayout();
            this.timerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Break Time";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.развернутьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(136, 48);
            // 
            // развернутьToolStripMenuItem
            // 
            this.развернутьToolStripMenuItem.Name = "развернутьToolStripMenuItem";
            this.развернутьToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.развернутьToolStripMenuItem.Text = "Развернуть";
            this.развернутьToolStripMenuItem.Click += new System.EventHandler(this.развернутьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // btnStartWork
            // 
            this.btnStartWork.Location = new System.Drawing.Point(12, 149);
            this.btnStartWork.Name = "btnStartWork";
            this.btnStartWork.Size = new System.Drawing.Size(120, 29);
            this.btnStartWork.TabIndex = 1;
            this.btnStartWork.Tag = "Work";
            this.btnStartWork.Text = "Начать работу";
            this.btnStartWork.UseVisualStyleBackColor = true;
            this.btnStartWork.Click += new System.EventHandler(this.btnStartWork_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(264, 149);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(94, 29);
            this.btnReset.TabIndex = 2;
            this.btnReset.Tag = "Work";
            this.btnReset.Text = "Сбросить";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStartBreak
            // 
            this.btnStartBreak.Location = new System.Drawing.Point(138, 149);
            this.btnStartBreak.Name = "btnStartBreak";
            this.btnStartBreak.Size = new System.Drawing.Size(120, 29);
            this.btnStartBreak.TabIndex = 3;
            this.btnStartBreak.Tag = "Work";
            this.btnStartBreak.Text = "Начать перерыв";
            this.btnStartBreak.UseVisualStyleBackColor = true;
            this.btnStartBreak.Click += new System.EventHandler(this.btnStartBreak_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(67, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Tag = "SettingTime";
            this.label1.Text = "Работа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(257, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Tag = "SettingTime";
            this.label2.Text = "Перерыв";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // выходToolStripMenuItem1
            // 
            this.выходToolStripMenuItem1.Name = "выходToolStripMenuItem1";
            this.выходToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.выходToolStripMenuItem1.Text = "Выход";
            this.выходToolStripMenuItem1.Click += new System.EventHandler(this.выходToolStripMenuItem1_Click);
            // 
            // режимToolStripMenuItem
            // 
            this.режимToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.работаToolStripMenuItem,
            this.установкаВремениToolStripMenuItem});
            this.режимToolStripMenuItem.Name = "режимToolStripMenuItem";
            this.режимToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.режимToolStripMenuItem.Text = "Режим";
            // 
            // работаToolStripMenuItem
            // 
            this.работаToolStripMenuItem.Name = "работаToolStripMenuItem";
            this.работаToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.работаToolStripMenuItem.Text = "Работа";
            this.работаToolStripMenuItem.Click += new System.EventHandler(this.работаToolStripMenuItem_Click);
            // 
            // установкаВремениToolStripMenuItem
            // 
            this.установкаВремениToolStripMenuItem.Name = "установкаВремениToolStripMenuItem";
            this.установкаВремениToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.установкаВремениToolStripMenuItem.Text = "Установка времени";
            this.установкаВремениToolStripMenuItem.Click += new System.EventHandler(this.установкаВремениToolStripMenuItem_Click);
            // 
            // btnSaveTime
            // 
            this.btnSaveTime.Location = new System.Drawing.Point(138, 152);
            this.btnSaveTime.Name = "btnSaveTime";
            this.btnSaveTime.Size = new System.Drawing.Size(94, 29);
            this.btnSaveTime.TabIndex = 13;
            this.btnSaveTime.Tag = "SettingTime";
            this.btnSaveTime.Text = "Сохранить";
            this.btnSaveTime.UseVisualStyleBackColor = true;
            this.btnSaveTime.Click += new System.EventHandler(this.btnSaveTime_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 14;
            this.label3.Tag = "SettingTime";
            this.label3.Text = "Часы";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(64, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 15;
            this.label4.Tag = "SettingTime";
            this.label4.Text = "Минуты";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(116, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 16;
            this.label5.Tag = "SettingTime";
            this.label5.Text = "Секунды";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(208, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 17;
            this.label6.Tag = "SettingTime";
            this.label6.Text = "Часы";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(260, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 18;
            this.label7.Tag = "SettingTime";
            this.label7.Text = "Минуты";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(312, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 19;
            this.label8.Tag = "SettingTime";
            this.label8.Text = "Секунды";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerPanel
            // 
            this.timerPanel.Controls.Add(this.lblTimerTitle);
            this.timerPanel.Controls.Add(this.btnPause);
            this.timerPanel.Controls.Add(this.label12);
            this.timerPanel.Controls.Add(this.lblHours);
            this.timerPanel.Controls.Add(this.label14);
            this.timerPanel.Controls.Add(this.label13);
            this.timerPanel.Controls.Add(this.lblSeconds);
            this.timerPanel.Controls.Add(this.lblMinutes);
            this.timerPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.timerPanel.Location = new System.Drawing.Point(0, 0);
            this.timerPanel.Name = "timerPanel";
            this.timerPanel.Size = new System.Drawing.Size(370, 143);
            this.timerPanel.TabIndex = 20;
            this.timerPanel.Tag = "Work";
            // 
            // lblTimerTitle
            // 
            this.lblTimerTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTimerTitle.Location = new System.Drawing.Point(63, 24);
            this.lblTimerTitle.Name = "lblTimerTitle";
            this.lblTimerTitle.Size = new System.Drawing.Size(235, 46);
            this.lblTimerTitle.TabIndex = 6;
            this.lblTimerTitle.Text = "Таймер";
            this.lblTimerTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPause.Enabled = false;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Image = global::BreakTime.Properties.Resources.pause;
            this.btnPause.Location = new System.Drawing.Point(312, 27);
            this.btnPause.Name = "btnPause";
            this.btnPause.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.btnPause.Size = new System.Drawing.Size(55, 55);
            this.btnPause.TabIndex = 21;
            this.btnPause.Tag = "Work";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(91, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 22);
            this.label12.TabIndex = 3;
            this.label12.Text = "часов";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHours
            // 
            this.lblHours.Font = new System.Drawing.Font("Garamond", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHours.Location = new System.Drawing.Point(17, 60);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(90, 65);
            this.lblHours.TabIndex = 0;
            this.lblHours.Text = "00";
            this.lblHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(299, 100);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 22);
            this.label14.TabIndex = 5;
            this.label14.Text = "секунд";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(196, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 22);
            this.label13.TabIndex = 4;
            this.label13.Text = "минут";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeconds
            // 
            this.lblSeconds.Font = new System.Drawing.Font("Garamond", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSeconds.Location = new System.Drawing.Point(228, 60);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(90, 65);
            this.lblSeconds.TabIndex = 2;
            this.lblSeconds.Text = "00";
            this.lblSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMinutes
            // 
            this.lblMinutes.Font = new System.Drawing.Font("Garamond", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMinutes.Location = new System.Drawing.Point(126, 60);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(90, 65);
            this.lblMinutes.TabIndex = 1;
            this.lblMinutes.Text = "00";
            this.lblMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // менюToolStripMenuItem1
            // 
            this.менюToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem2});
            this.менюToolStripMenuItem1.Name = "менюToolStripMenuItem1";
            this.менюToolStripMenuItem1.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem1.Text = "Меню";
            // 
            // выходToolStripMenuItem2
            // 
            this.выходToolStripMenuItem2.Name = "выходToolStripMenuItem2";
            this.выходToolStripMenuItem2.Size = new System.Drawing.Size(108, 22);
            this.выходToolStripMenuItem2.Text = "Выход";
            this.выходToolStripMenuItem2.Click += new System.EventHandler(this.выходToolStripMenuItem1_Click);
            // 
            // режимToolStripMenuItem1
            // 
            this.режимToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.работаToolStripMenuItem1,
            this.настройкиВремениToolStripMenuItem});
            this.режимToolStripMenuItem1.Name = "режимToolStripMenuItem1";
            this.режимToolStripMenuItem1.Size = new System.Drawing.Size(57, 20);
            this.режимToolStripMenuItem1.Text = "Режим";
            // 
            // работаToolStripMenuItem1
            // 
            this.работаToolStripMenuItem1.Name = "работаToolStripMenuItem1";
            this.работаToolStripMenuItem1.Size = new System.Drawing.Size(185, 22);
            this.работаToolStripMenuItem1.Text = "Работа";
            this.работаToolStripMenuItem1.Click += new System.EventHandler(this.работаToolStripMenuItem_Click);
            // 
            // настройкиВремениToolStripMenuItem
            // 
            this.настройкиВремениToolStripMenuItem.Name = "настройкиВремениToolStripMenuItem";
            this.настройкиВремениToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.настройкиВремениToolStripMenuItem.Text = "Настройки времени";
            this.настройкиВремениToolStripMenuItem.Click += new System.EventHandler(this.установкаВремениToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(370, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnChooseSoundWork
            // 
            this.btnChooseSoundWork.BackgroundImage = global::BreakTime.Properties.Resources._16;
            this.btnChooseSoundWork.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChooseSoundWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseSoundWork.Location = new System.Drawing.Point(12, 149);
            this.btnChooseSoundWork.Name = "btnChooseSoundWork";
            this.btnChooseSoundWork.Size = new System.Drawing.Size(35, 35);
            this.btnChooseSoundWork.TabIndex = 22;
            this.btnChooseSoundWork.Tag = "SettingTime";
            this.btnChooseSoundWork.UseVisualStyleBackColor = true;
            this.btnChooseSoundWork.Click += new System.EventHandler(this.btnChooseSoundWork_Click);
            // 
            // btnChooseSoundBreak
            // 
            this.btnChooseSoundBreak.BackgroundImage = global::BreakTime.Properties.Resources._16;
            this.btnChooseSoundBreak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChooseSoundBreak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseSoundBreak.Location = new System.Drawing.Point(323, 149);
            this.btnChooseSoundBreak.Name = "btnChooseSoundBreak";
            this.btnChooseSoundBreak.Size = new System.Drawing.Size(35, 35);
            this.btnChooseSoundBreak.TabIndex = 23;
            this.btnChooseSoundBreak.Tag = "SettingTime";
            this.btnChooseSoundBreak.UseVisualStyleBackColor = true;
            this.btnChooseSoundBreak.Click += new System.EventHandler(this.btnChooseSoundBreak_Click);
            // 
            // lblMusicWork
            // 
            this.lblMusicWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMusicWork.Location = new System.Drawing.Point(53, 149);
            this.lblMusicWork.Name = "lblMusicWork";
            this.lblMusicWork.Size = new System.Drawing.Size(79, 35);
            this.lblMusicWork.TabIndex = 24;
            this.lblMusicWork.Tag = "SettingTime";
            this.lblMusicWork.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMusicBreak
            // 
            this.lblMusicBreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMusicBreak.Location = new System.Drawing.Point(239, 149);
            this.lblMusicBreak.Name = "lblMusicBreak";
            this.lblMusicBreak.Size = new System.Drawing.Size(79, 35);
            this.lblMusicBreak.TabIndex = 25;
            this.lblMusicBreak.Tag = "SettingTime";
            this.lblMusicBreak.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbVolume
            // 
            this.tbVolume.AutoSize = false;
            this.tbVolume.Location = new System.Drawing.Point(164, 40);
            this.tbVolume.Maximum = 100;
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbVolume.Size = new System.Drawing.Size(45, 100);
            this.tbVolume.TabIndex = 26;
            this.tbVolume.Tag = "SettingTime";
            this.tbVolume.TickFrequency = 10;
            this.tbVolume.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbVolume.Value = 100;
            this.tbVolume.ValueChanged += new System.EventHandler(this.tbVolume_ValueChanged);
            // 
            // lblVolume
            // 
            this.lblVolume.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVolume.Location = new System.Drawing.Point(162, 133);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(46, 13);
            this.lblVolume.TabIndex = 27;
            this.lblVolume.Tag = "SettingTime";
            this.lblVolume.Text = "100";
            this.lblVolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(142, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 28;
            this.label9.Tag = "SettingTime";
            this.label9.Text = "Громкость";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownMyDesign6
            // 
            this.numericUpDownMyDesign6.Location = new System.Drawing.Point(312, 41);
            this.numericUpDownMyDesign6.Name = "numericUpDownMyDesign6";
            this.numericUpDownMyDesign6.Size = new System.Drawing.Size(46, 93);
            this.numericUpDownMyDesign6.TabIndex = 11;
            this.numericUpDownMyDesign6.Tag = "SettingTime";
            // 
            // numericUpDownMyDesign5
            // 
            this.numericUpDownMyDesign5.Location = new System.Drawing.Point(260, 41);
            this.numericUpDownMyDesign5.Name = "numericUpDownMyDesign5";
            this.numericUpDownMyDesign5.Size = new System.Drawing.Size(46, 93);
            this.numericUpDownMyDesign5.TabIndex = 10;
            this.numericUpDownMyDesign5.Tag = "SettingTime";
            // 
            // numericUpDownMyDesign4
            // 
            this.numericUpDownMyDesign4.Location = new System.Drawing.Point(208, 41);
            this.numericUpDownMyDesign4.Name = "numericUpDownMyDesign4";
            this.numericUpDownMyDesign4.Size = new System.Drawing.Size(46, 93);
            this.numericUpDownMyDesign4.TabIndex = 9;
            this.numericUpDownMyDesign4.Tag = "SettingTime";
            // 
            // numericUpDownMyDesign3
            // 
            this.numericUpDownMyDesign3.Location = new System.Drawing.Point(116, 41);
            this.numericUpDownMyDesign3.Name = "numericUpDownMyDesign3";
            this.numericUpDownMyDesign3.Size = new System.Drawing.Size(46, 93);
            this.numericUpDownMyDesign3.TabIndex = 8;
            this.numericUpDownMyDesign3.Tag = "SettingTime";
            // 
            // numericUpDownMyDesign2
            // 
            this.numericUpDownMyDesign2.Location = new System.Drawing.Point(64, 41);
            this.numericUpDownMyDesign2.Name = "numericUpDownMyDesign2";
            this.numericUpDownMyDesign2.Size = new System.Drawing.Size(46, 93);
            this.numericUpDownMyDesign2.TabIndex = 7;
            this.numericUpDownMyDesign2.Tag = "SettingTime";
            // 
            // numericUpDownMyDesign1
            // 
            this.numericUpDownMyDesign1.Location = new System.Drawing.Point(12, 41);
            this.numericUpDownMyDesign1.Name = "numericUpDownMyDesign1";
            this.numericUpDownMyDesign1.Size = new System.Drawing.Size(46, 93);
            this.numericUpDownMyDesign1.TabIndex = 6;
            this.numericUpDownMyDesign1.Tag = "SettingTime";
            // 
            // BreakTimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 190);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.lblMusicBreak);
            this.Controls.Add(this.lblMusicWork);
            this.Controls.Add(this.btnChooseSoundBreak);
            this.Controls.Add(this.btnChooseSoundWork);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStartWork);
            this.Controls.Add(this.btnSaveTime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownMyDesign6);
            this.Controls.Add(this.numericUpDownMyDesign5);
            this.Controls.Add(this.numericUpDownMyDesign4);
            this.Controls.Add(this.numericUpDownMyDesign3);
            this.Controls.Add(this.numericUpDownMyDesign2);
            this.Controls.Add(this.numericUpDownMyDesign1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStartBreak);
            this.Controls.Add(this.tbVolume);
            this.Controls.Add(this.timerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "BreakTimeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Break Time";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BreakTime_FormClosing);
            this.contextMenuStrip1.ResumeLayout(false);
            this.timerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem развернутьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Button btnStartWork;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStartBreak;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private NumericUpDownMyDesign numericUpDownMyDesign1;
        private NumericUpDownMyDesign numericUpDownMyDesign2;
        private NumericUpDownMyDesign numericUpDownMyDesign3;
        private NumericUpDownMyDesign numericUpDownMyDesign4;
        private NumericUpDownMyDesign numericUpDownMyDesign5;
        private NumericUpDownMyDesign numericUpDownMyDesign6;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem режимToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem работаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem установкаВремениToolStripMenuItem;
        private System.Windows.Forms.Button btnSaveTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel timerPanel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblTimerTitle;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem режимToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem работаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem настройкиВремениToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnChooseSoundWork;
        private System.Windows.Forms.Button btnChooseSoundBreak;
        private System.Windows.Forms.Label lblMusicWork;
        private System.Windows.Forms.Label lblMusicBreak;
        private System.Windows.Forms.TrackBar tbVolume;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label label9;
    }
}

