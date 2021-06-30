using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstRepo
{
    public partial class Form1 : Form
    {
        private bool hasHourse = true;
        private bool hasMinutes = true;
        private bool hasSeconds = true;
        private bool hasMilliseconds = true;
        public Form1()
        {
            InitializeComponent();

            this.TimeLabel.Text = DateTime.Now.ToShortTimeString();

        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            using (SettingsForm form = new SettingsForm()) {
                form.panel = this.panel1.BackColor;
                form.fore = this.TimeLabel.ForeColor;
                form.back = this.BackColor;
                form.HourseCheck.Checked = hasHourse;
                form.MinutesCheck.Checked = hasMinutes;
                form.SecondsCheck.Checked = hasSeconds;
                form.MillisecondsCheck.Checked = hasMilliseconds;


                form.ShowDialog();
                this.panel1.BackColor = form.panel;
                this.TimeLabel.ForeColor = form.fore;
                this.TimeLabel.BackColor = form.panel;
                this.BackColor = form.back;

                hasHourse = form.HourseCheck.Checked;
                hasMinutes =form.MinutesCheck.Checked;
                hasSeconds =form.SecondsCheck.Checked;
                hasMilliseconds =  form.MillisecondsCheck.Checked;

            }
        }
    }
}
