namespace BreakTime
{
    partial class Settings
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMusicBreak = new System.Windows.Forms.Label();
            this.lblMusicWork = new System.Windows.Forms.Label();
            this.btnChooseSoundBreak = new System.Windows.Forms.Button();
            this.btnChooseSoundWork = new System.Windows.Forms.Button();
            this.setTime1 = new BreakTime.TimeSetter();
            this.setTime2 = new BreakTime.TimeSetter();
            this.volume1 = new BreakTime.SettingsMenu.Volume();
            this.musicIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblWorkMusicPath = new System.Windows.Forms.Label();
            this.lblBreakMusicPath = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.musicIOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(138, 143);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(94, 29);
            this.btnSaveSettings.TabIndex = 37;
            this.btnSaveSettings.Tag = "SettingTime";
            this.btnSaveSettings.Text = "Сохранить";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(260, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 30;
            this.label2.Tag = "SettingTime";
            this.label2.Text = "Перерыв";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(54, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 29;
            this.label1.Tag = "SettingTime";
            this.label1.Text = "Работа";
            // 
            // lblMusicBreak
            // 
            this.lblMusicBreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMusicBreak.Location = new System.Drawing.Point(239, 140);
            this.lblMusicBreak.Name = "lblMusicBreak";
            this.lblMusicBreak.Size = new System.Drawing.Size(79, 35);
            this.lblMusicBreak.TabIndex = 49;
            this.lblMusicBreak.Tag = "SettingTime";
            this.lblMusicBreak.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMusicWork
            // 
            this.lblMusicWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMusicWork.Location = new System.Drawing.Point(53, 140);
            this.lblMusicWork.Name = "lblMusicWork";
            this.lblMusicWork.Size = new System.Drawing.Size(79, 35);
            this.lblMusicWork.TabIndex = 48;
            this.lblMusicWork.Tag = "SettingTime";
            this.lblMusicWork.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnChooseSoundBreak
            // 
            this.btnChooseSoundBreak.BackgroundImage = global::BreakTime.Properties.Resources._16;
            this.btnChooseSoundBreak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChooseSoundBreak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseSoundBreak.Location = new System.Drawing.Point(323, 140);
            this.btnChooseSoundBreak.Name = "btnChooseSoundBreak";
            this.btnChooseSoundBreak.Size = new System.Drawing.Size(35, 35);
            this.btnChooseSoundBreak.TabIndex = 39;
            this.btnChooseSoundBreak.Tag = "SettingTime";
            this.btnChooseSoundBreak.UseVisualStyleBackColor = true;
            this.btnChooseSoundBreak.Click += new System.EventHandler(this.btnChooseSoundBreak_Click);
            // 
            // btnChooseSoundWork
            // 
            this.btnChooseSoundWork.BackgroundImage = global::BreakTime.Properties.Resources._16;
            this.btnChooseSoundWork.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChooseSoundWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseSoundWork.Location = new System.Drawing.Point(12, 140);
            this.btnChooseSoundWork.Name = "btnChooseSoundWork";
            this.btnChooseSoundWork.Size = new System.Drawing.Size(35, 35);
            this.btnChooseSoundWork.TabIndex = 38;
            this.btnChooseSoundWork.Tag = "SettingTime";
            this.btnChooseSoundWork.UseVisualStyleBackColor = true;
            this.btnChooseSoundWork.Click += new System.EventHandler(this.btnChooseSoundWork_Click);
            // 
            // setTime1
            // 
            this.setTime1.Location = new System.Drawing.Point(5, 32);
            this.setTime1.Name = "setTime1";
            this.setTime1.Size = new System.Drawing.Size(150, 108);
            this.setTime1.TabIndex = 52;
            this.setTime1.Time = "000000";
            // 
            // setTime2
            // 
            this.setTime2.Location = new System.Drawing.Point(214, 32);
            this.setTime2.Name = "setTime2";
            this.setTime2.Size = new System.Drawing.Size(150, 108);
            this.setTime2.TabIndex = 51;
            this.setTime2.Time = "000000";
            // 
            // volume1
            // 
            this.volume1.BackColor = System.Drawing.Color.Transparent;
            this.volume1.Location = new System.Drawing.Point(154, 23);
            this.volume1.Name = "volume1";
            this.volume1.Size = new System.Drawing.Size(62, 121);
            this.volume1.TabIndex = 53;
            this.volume1.Value = 0;
            // 
            // musicIOBindingSource
            // 
            this.musicIOBindingSource.DataSource = typeof(BreakTime.IO.Music.MusicIO);
            // 
            // lblWorkMusicPath
            // 
            this.lblWorkMusicPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWorkMusicPath.ForeColor = System.Drawing.SystemColors.Control;
            this.lblWorkMusicPath.Location = new System.Drawing.Point(9, 140);
            this.lblWorkMusicPath.Name = "lblWorkMusicPath";
            this.lblWorkMusicPath.Size = new System.Drawing.Size(123, 40);
            this.lblWorkMusicPath.TabIndex = 54;
            this.lblWorkMusicPath.Tag = "SettingTime";
            this.lblWorkMusicPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblWorkMusicPath.TextChanged += new System.EventHandler(this.WorkMusicPathChanged);
            // 
            // lblBreakMusicPath
            // 
            this.lblBreakMusicPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBreakMusicPath.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBreakMusicPath.Location = new System.Drawing.Point(241, 140);
            this.lblBreakMusicPath.Name = "lblBreakMusicPath";
            this.lblBreakMusicPath.Size = new System.Drawing.Size(117, 40);
            this.lblBreakMusicPath.TabIndex = 55;
            this.lblBreakMusicPath.Tag = "SettingTime";
            this.lblBreakMusicPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBreakMusicPath.TextChanged += new System.EventHandler(this.lblBreakMusicPath_TextChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.setTime1);
            this.Controls.Add(this.setTime2);
            this.Controls.Add(this.lblMusicBreak);
            this.Controls.Add(this.lblMusicWork);
            this.Controls.Add(this.btnChooseSoundBreak);
            this.Controls.Add(this.btnChooseSoundWork);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.volume1);
            this.Controls.Add(this.lblBreakMusicPath);
            this.Controls.Add(this.lblWorkMusicPath);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(370, 191);
            ((System.ComponentModel.ISupportInitialize)(this.musicIOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnChooseSoundBreak;
        private System.Windows.Forms.Button btnChooseSoundWork;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMusicBreak;
        private System.Windows.Forms.Label lblMusicWork;
        private TimeSetter setTime2;
        private TimeSetter setTime1;
        private SettingsMenu.Volume volume1;
        private System.Windows.Forms.BindingSource musicIOBindingSource;
        private System.Windows.Forms.Label lblWorkMusicPath;
        private System.Windows.Forms.Label lblBreakMusicPath;
    }
}
