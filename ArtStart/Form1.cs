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
            Application.Exit(); // ��������� ����������, ����� Form2 �������
        }

        private void challengesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // ���������, ���������� �� ��� f2 � ���������� ���, ���� ��
            if (f3 == null || f3.IsDisposed)
            {
                f3 = new Form2(); // ������� ����� ���������, ���� ��� ���
                f3.Show(); // ���������� ���
            }
            else
            {
                // ���� ����� ��� �������, ������ ���������� �
                f3.BringToFront(); // ��������� ����� �� �������� ����
                f3.Activate(); // ���������� �����
            }
        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
 // ���������, ���������� �� ��� f2 � ���������� ���, ���� ��
            if (f2 == null || f2.IsDisposed)
            {
                f2 = new Form2(); // ������� ����� ���������, ���� ��� ���
                f2.Show(); // ���������� ���
            }
            else
            {
                // ���� ����� ��� �������, ������ ���������� �
                f2.BringToFront(); // ��������� ����� �� �������� ����
                f2.Activate(); // ���������� �����
            }
        }
    }
}
