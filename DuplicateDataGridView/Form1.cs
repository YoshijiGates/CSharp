using System.Windows.Forms;

namespace DuplicateDataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // DataGridView�ɏ����l��ݒ�
            dataGridView1.Rows.Add("Column1A", "Column1B", "Column1C");
            dataGridView1.Rows.Add("Column1A", "Column1B", "Column1C");
            dataGridView1.Rows.Add("Column1A", "Column1B", "Column1C");

            dataGridView2.Rows.Add("Column1A", "Column1B", "Column1C");
            dataGridView2.Rows.Add("Column1A", "Column1B", "Column1C");
            dataGridView2.Rows.Add("Column1A", "Column1B", "Column1C");
        }

        private void dataGridView1_Scroll(object sender, ScrollEventArgs e)
        {
            // dataGridView1 �� dataGridView2 �ɓ���� Scroll �C�x���g�����蓖�Ă�
            dataGridView2.FirstDisplayedScrollingColumnIndex = dataGridView1.FirstDisplayedScrollingColumnIndex;
            dataGridView2.FirstDisplayedScrollingRowIndex = dataGridView1.FirstDisplayedScrollingRowIndex;
        }

        private void dataGridView2_Scroll(object sender, ScrollEventArgs e)
        {
            // dataGridView1 �� dataGridView2 �ɓ���� Scroll �C�x���g�����蓖�Ă�
            dataGridView1.FirstDisplayedScrollingColumnIndex = dataGridView2.FirstDisplayedScrollingColumnIndex;
            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView2.FirstDisplayedScrollingRowIndex;
        }
    }
}