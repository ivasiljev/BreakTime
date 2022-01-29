namespace BreakTime
{
    partial class NumericUpDownMyDesign
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
            this.up = new System.Windows.Forms.Button();
            this.down = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // up
            // 
            this.up.BackgroundImage = global::BreakTime.Properties.Resources.up;
            this.up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.up.Location = new System.Drawing.Point(10, 3);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(25, 25);
            this.up.TabIndex = 0;
            this.up.TabStop = false;
            this.up.UseVisualStyleBackColor = true;
            this.up.Click += new System.EventHandler(this.up_Click);
            // 
            // down
            // 
            this.down.BackgroundImage = global::BreakTime.Properties.Resources.down;
            this.down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.down.Location = new System.Drawing.Point(10, 65);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(25, 25);
            this.down.TabIndex = 2;
            this.down.TabStop = false;
            this.down.UseVisualStyleBackColor = true;
            this.down.Click += new System.EventHandler(this.down_Click);
            // 
            // time
            // 
            this.time.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time.Location = new System.Drawing.Point(3, 34);
            this.time.MaxLength = 3;
            this.time.Multiline = true;
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(40, 25);
            this.time.TabIndex = 1;
            this.time.Text = "00";
            this.time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.time.TextChanged += new System.EventHandler(this.time_TextChanged);
            this.time.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.time_KeyPress);
            this.time.Leave += new System.EventHandler(this.time_Leave);
            // 
            // NumericUpDownMyDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.time);
            this.Controls.Add(this.down);
            this.Controls.Add(this.up);
            this.Name = "NumericUpDownMyDesign";
            this.Size = new System.Drawing.Size(46, 93);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button up;
        private System.Windows.Forms.Button down;
        internal System.Windows.Forms.TextBox time;
    }
}
