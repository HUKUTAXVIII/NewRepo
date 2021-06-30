
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

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
            this.components = new System.ComponentModel.Container();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SettingsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.BackColor = this.panel1.BackColor;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.TimeLabel.Location = new System.Drawing.Point(352, 218);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(0, 31);
            this.TimeLabel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Location = new System.Drawing.Point(236, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 185);
            this.panel1.TabIndex = 1;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 100;
            this.timer.Tick += Timer_Tick;
            // 
            // SettingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(713, 12);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(75, 23);
            this.SettingsButton.TabIndex = 2;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.TimeLabel.BackColor = this.panel1.BackColor;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

            this.FormClosed += Form1_FormClosed;

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<bool>));
            List<bool> TimeSettings = new List<bool>();
            TimeSettings.Add(hasHourse);
            TimeSettings.Add(hasMinutes);
            TimeSettings.Add(hasSeconds);
            TimeSettings.Add(hasMilliseconds);
            using (FileStream fs = new FileStream("Settings.xml", FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, TimeSettings);
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateTime();
        }

        #endregion
        private void UpdateTime() {
            //this.TimeLabel.Text = DateTime.Now.ToShortTimeString();
            this.TimeLabel.Text = "";
            if (hasHourse) {
                this.TimeLabel.Text += DateTime.Now.Hour+ ":";
            }
            if (hasMinutes)
            {
                this.TimeLabel.Text += DateTime.Now.Minute + ":";
            }
            if (hasSeconds)
            {
                this.TimeLabel.Text += DateTime.Now.Second + ":";
            }
            if (hasMilliseconds)
            {
                this.TimeLabel.Text += DateTime.Now.Millisecond + ":";
            }
            this.TimeLabel.Text = this.TimeLabel.Text.Remove(this.TimeLabel.Text.Length-1,1);

            this.TimeLabel.BackColor = this.panel1.BackColor;
        }
        private Timer timer;
        private System.Windows.Forms.Label TimeLabel;
        private Panel panel1;
        private Button SettingsButton;
    }
}

