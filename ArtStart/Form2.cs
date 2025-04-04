

namespace ArtStart
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit(); // Закрываем приложение, когда Form2 закрыта
        }

        private void colorMixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUtils._form1 = FormUtils.ShowForm<Form1>(() => new Form1());
        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUtils._form3 = FormUtils.ShowForm<Form3>(() => new Form3());
        }
    }
}
