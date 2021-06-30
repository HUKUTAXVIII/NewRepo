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
    public partial class SettingsForm : Form
    {


        public Color back;
        public Color panel;
        public Color fore;

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void ForeColorButton_Click(object sender, EventArgs e)
        {
            using (ColorDialog dialog = new ColorDialog()) {
                if (dialog.ShowDialog() == DialogResult.OK) {
                    this.fore = dialog.Color;
                }
            }
        }

        private void BackColorButton_Click(object sender, EventArgs e)
        {
            using (ColorDialog dialog = new ColorDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    this.back = dialog.Color;

                }
            }
        }

        private void PanelColorButton_Click(object sender, EventArgs e)
        {
            using (ColorDialog dialog = new ColorDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    this.panel = dialog.Color;

                }
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
