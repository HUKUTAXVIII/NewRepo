
using System;
using System.Windows.Forms;

namespace FirstRepo
{
    partial class Form1
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.TimeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.TimeLabel.Location = new System.Drawing.Point(352, 218);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(0, 31);
            this.TimeLabel.TabIndex = 0;
            //this.TimeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TimeLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

            timer = new Timer();
            timer.Tick += Timer_Tick;
            timer.Interval = 10;
            timer.Start();
         

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateTime();
        }

        #endregion
        private void UpdateTime() {
            this.TimeLabel.Text = DateTime.Now.ToShortTimeString();
        }
        private Timer timer;
        private System.Windows.Forms.Label TimeLabel;
    }
}

