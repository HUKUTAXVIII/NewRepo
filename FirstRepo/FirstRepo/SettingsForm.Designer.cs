namespace FirstRepo
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ForeColorButton = new System.Windows.Forms.Button();
            this.BackColorButton = new System.Windows.Forms.Button();
            this.PanelColorButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.HourseCheck = new System.Windows.Forms.CheckBox();
            this.MinutesCheck = new System.Windows.Forms.CheckBox();
            this.SecondsCheck = new System.Windows.Forms.CheckBox();
            this.MillisecondsCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ForeColorButton
            // 
            this.ForeColorButton.Location = new System.Drawing.Point(12, 12);
            this.ForeColorButton.Name = "ForeColorButton";
            this.ForeColorButton.Size = new System.Drawing.Size(75, 23);
            this.ForeColorButton.TabIndex = 0;
            this.ForeColorButton.Text = "Fore Color";
            this.ForeColorButton.UseVisualStyleBackColor = true;
            this.ForeColorButton.Click += new System.EventHandler(this.ForeColorButton_Click);
            // 
            // BackColorButton
            // 
            this.BackColorButton.Location = new System.Drawing.Point(93, 12);
            this.BackColorButton.Name = "BackColorButton";
            this.BackColorButton.Size = new System.Drawing.Size(75, 23);
            this.BackColorButton.TabIndex = 1;
            this.BackColorButton.Text = "Back Color";
            this.BackColorButton.UseVisualStyleBackColor = true;
            this.BackColorButton.Click += new System.EventHandler(this.BackColorButton_Click);
            // 
            // PanelColorButton
            // 
            this.PanelColorButton.Location = new System.Drawing.Point(174, 12);
            this.PanelColorButton.Name = "PanelColorButton";
            this.PanelColorButton.Size = new System.Drawing.Size(75, 23);
            this.PanelColorButton.TabIndex = 2;
            this.PanelColorButton.Text = "Panel Color";
            this.PanelColorButton.UseVisualStyleBackColor = true;
            this.PanelColorButton.Click += new System.EventHandler(this.PanelColorButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(174, 175);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 3;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // HourseCheck
            // 
            this.HourseCheck.AutoSize = true;
            this.HourseCheck.Location = new System.Drawing.Point(12, 77);
            this.HourseCheck.Name = "HourseCheck";
            this.HourseCheck.Size = new System.Drawing.Size(60, 17);
            this.HourseCheck.TabIndex = 4;
            this.HourseCheck.Text = "Hourse";
            this.HourseCheck.UseVisualStyleBackColor = true;
            // 
            // MinutesCheck
            // 
            this.MinutesCheck.AutoSize = true;
            this.MinutesCheck.Location = new System.Drawing.Point(12, 112);
            this.MinutesCheck.Name = "MinutesCheck";
            this.MinutesCheck.Size = new System.Drawing.Size(63, 17);
            this.MinutesCheck.TabIndex = 5;
            this.MinutesCheck.Text = "Minutes";
            this.MinutesCheck.UseVisualStyleBackColor = true;
            // 
            // SecondsCheck
            // 
            this.SecondsCheck.AutoSize = true;
            this.SecondsCheck.Location = new System.Drawing.Point(169, 77);
            this.SecondsCheck.Name = "SecondsCheck";
            this.SecondsCheck.Size = new System.Drawing.Size(68, 17);
            this.SecondsCheck.TabIndex = 6;
            this.SecondsCheck.Text = "Seconds";
            this.SecondsCheck.UseVisualStyleBackColor = true;
            // 
            // MillisecondsCheck
            // 
            this.MillisecondsCheck.AutoSize = true;
            this.MillisecondsCheck.Location = new System.Drawing.Point(169, 112);
            this.MillisecondsCheck.Name = "MillisecondsCheck";
            this.MillisecondsCheck.Size = new System.Drawing.Size(83, 17);
            this.MillisecondsCheck.TabIndex = 7;
            this.MillisecondsCheck.Text = "Milliseconds";
            this.MillisecondsCheck.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 210);
            this.Controls.Add(this.MillisecondsCheck);
            this.Controls.Add(this.SecondsCheck);
            this.Controls.Add(this.MinutesCheck);
            this.Controls.Add(this.HourseCheck);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.PanelColorButton);
            this.Controls.Add(this.BackColorButton);
            this.Controls.Add(this.ForeColorButton);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ForeColorButton;
        private System.Windows.Forms.Button BackColorButton;
        private System.Windows.Forms.Button PanelColorButton;
        private System.Windows.Forms.Button OkButton;
        public System.Windows.Forms.CheckBox HourseCheck;
        public System.Windows.Forms.CheckBox MinutesCheck;
        public System.Windows.Forms.CheckBox SecondsCheck;
        public System.Windows.Forms.CheckBox MillisecondsCheck;
    }
}