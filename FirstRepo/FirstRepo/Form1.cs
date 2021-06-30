using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace FirstRepo
{
    public partial class Form1 : Form
    {
        private bool hasHourse = true;
        private bool hasMinutes = true;
        private bool hasSeconds = false;
        private bool hasMilliseconds = false;
        public Form1()
        {
            InitializeComponent();

            XmlSerializer xml = new XmlSerializer(typeof(List<bool>));
            List<bool> TimeSettings = new List<bool>();
            //using (FileStream fs = new FileStream("Settings.xml", FileMode.OpenOrCreate))
            //{
            //    if (File.Exists("Settings.xml"))
            //    {
            //        TimeSettings = (List<bool>)xml.Deserialize(fs);
            //        if (TimeSettings.Count != 0)
            //        {
            //            hasHourse = TimeSettings[0];
            //            hasMinutes = TimeSettings[1];
            //            hasSeconds = TimeSettings[2];
            //            hasMilliseconds = TimeSettings[3];
            //        }
            //    }
            //}


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
                xml = new XmlSerializer(typeof(List<Color>));
                //List<Color> ColorSettings = new List<Color>();
                //ColorSettings.Add(this.panel1.BackColor);
                ////ColorSettings.Add(this.panel1.);
                //using (FileStream fs = new FileStream("ColorSettings.xml", FileMode.OpenOrCreate))
                //{
                //    xml.Serialize(fs, ColorSettings);
                //}


            }
        }
    }
}
