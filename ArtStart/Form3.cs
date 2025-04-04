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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        { }
        private void colorMixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUtils._form1 = FormUtils.ShowForm<Form1>(() => new Form1());

        }

        private void challengesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUtils._form2 = FormUtils.ShowForm<Form2>(() => new Form2());

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
