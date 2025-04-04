using ArtStart;
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
        private void challengesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormUtils._form2 = FormUtils.ShowForm<Form2>(() => new Form2());
        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUtils._form3 = FormUtils.ShowForm<Form3>(() => new Form3());
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        { }
        //private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    // «акрытие приложени€ только если нет открытых форм
        //    if (!FormUtils.IsFormOpen<Form2>() &&
        //        !FormUtils.IsFormOpen<Form3>() &&
        //        !FormUtils.IsFormOpen<MainForm>())
        //    {
        //        Application.Exit();
        //    }
        //}
    }
}