namespace BreakTime
{
    partial class TimeSetter
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timeSeconds = new BreakTime.NumericUpDownMyDesign();
            this.timeMinutes = new BreakTime.NumericUpDownMyDesign();
            this.timeHours = new BreakTime.NumericUpDownMyDesign();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(104, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 50;
            this.label5.Tag = "SettingTime";
            this.label5.Text = "Секунды";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(52, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 49;
            this.label4.Tag = "SettingTime";
            this.label4.Text = "Минуты";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(0, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 48;
            this.label3.Tag = "SettingTime";
            this.label3.Text = "Часы";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeSeconds
            // 
            this.timeSeconds.Location = new System.Drawing.Point(104, 0);
            this.timeSeconds.Name = "timeSeconds";
            this.timeSeconds.Size = new System.Drawing.Size(46, 93);
            this.timeSeconds.TabIndex = 47;
            this.timeSeconds.Tag = "SettingTime";
            // 
            // timeMinutes
            // 
            this.timeMinutes.Location = new System.Drawing.Point(52, 0);
            this.timeMinutes.Name = "timeMinutes";
            this.timeMinutes.Size = new System.Drawing.Size(46, 93);
            this.timeMinutes.TabIndex = 46;
            this.timeMinutes.Tag = "SettingTime";
            // 
            // timeHours
            // 
            this.timeHours.Location = new System.Drawing.Point(0, 0);
            this.timeHours.Name = "timeHours";
            this.timeHours.Size = new System.Drawing.Size(46, 93);
            this.timeHours.TabIndex = 45;
            this.timeHours.Tag = "SettingTime";
            // 
            // SetTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.timeSeconds);
            this.Controls.Add(this.timeMinutes);
            this.Controls.Add(this.timeHours);
            this.Name = "SetTime";
            this.Size = new System.Drawing.Size(150, 108);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private NumericUpDownMyDesign timeSeconds;
        private NumericUpDownMyDesign timeMinutes;
        private NumericUpDownMyDesign timeHours;
    }
}
