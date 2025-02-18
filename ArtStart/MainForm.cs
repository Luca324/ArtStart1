using Scrtwpns.Mixbox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtStart
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }



        private void MainForm_Load(object sender, EventArgs e)
        {
            Color color1 = Color.FromArgb(0, 33, 133);  // blue
            Color color2 = Color.FromArgb(252, 211, 0); // yellow
            float t = 0.5f;                             // mixing ratio

            Color colorMix = Color.FromArgb(Mixbox.Lerp(color1.ToArgb(), color2.ToArgb(), t));

            label1.BackColor = colorMix;
        }
        private void challengesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Открываем Form2 и скрываем MainForm
            Form2 f2 = new();
            f2.Show();
            this.Hide();
        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Открываем Form3 и скрываем MainForm
            Form3 f3 = new();
            f3.Show();
            this.Hide();
        }

        private void colorMixToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Открываем Form1 и скрываем MainForm
            Form1 f1 = new();
            f1.Show();
            this.Hide();
        }
    }
}
