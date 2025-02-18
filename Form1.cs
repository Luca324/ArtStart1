namespace ArtStart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Form f2;
        private void colorMixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2 = new Form2();
            f2.Show();
        }
    }
}
