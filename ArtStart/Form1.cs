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
        Form f3;

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Закрываем приложение, когда Form2 закрыта
        }

        private void challengesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Проверяем, существует ли уже f2 и отображаем его, если да
            if (f3 == null || f3.IsDisposed)
            {
                f3 = new Form2(); // Создаем новый экземпляр, если его нет
                f3.Show(); // Показываем его
            }
            else
            {
                // Если форма уже открыта, просто активируем её
                f3.BringToFront(); // Переносим форму на передний план
                f3.Activate(); // Активируем форму
            }
        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
 // Проверяем, существует ли уже f2 и отображаем его, если да
            if (f2 == null || f2.IsDisposed)
            {
                f2 = new Form2(); // Создаем новый экземпляр, если его нет
                f2.Show(); // Показываем его
            }
            else
            {
                // Если форма уже открыта, просто активируем её
                f2.BringToFront(); // Переносим форму на передний план
                f2.Activate(); // Активируем форму
            }
        }
    }
}
