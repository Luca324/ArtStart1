using ArtStart;
using Scrtwpns.Mixbox;
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
            // Ваша логика смешивания цветов
            Color color1 = Color.FromArgb(0, 33, 133);
            Color color2 = Color.FromArgb(252, 211, 0);
            Color colorMix = Color.FromArgb(Mixbox.Lerp(color1.ToArgb(), color2.ToArgb(), 0.5f));
            label1.BackColor = colorMix;
        }

        private void challengesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUtils.ShowForm<Form2>(() => new Form2(), this);
        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUtils.ShowForm<Form3>(() => new Form3(), this);
        }

        private void colorMixToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormUtils.ShowForm<Form1>(() => new Form1(), this);
        }
    }
}