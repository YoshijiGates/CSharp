using System.Windows.Forms;

namespace DuplicateDataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // DataGridViewに初期値を設定
            dataGridView1.Rows.Add("Column1A", "Column1B", "Column1C");
            dataGridView1.Rows.Add("Column1A", "Column1B", "Column1C");
            dataGridView1.Rows.Add("Column1A", "Column1B", "Column1C");

            dataGridView2.Rows.Add("Column1A", "Column1B", "Column1C");
            dataGridView2.Rows.Add("Column1A", "Column1B", "Column1C");
            dataGridView2.Rows.Add("Column1A", "Column1B", "Column1C");
        }

        private void dataGridView1_Scroll(object sender, ScrollEventArgs e)
        {
            // dataGridView1 と dataGridView2 に同一の Scroll イベントを割り当てる
            dataGridView2.FirstDisplayedScrollingColumnIndex = dataGridView1.FirstDisplayedScrollingColumnIndex;
            dataGridView2.FirstDisplayedScrollingRowIndex = dataGridView1.FirstDisplayedScrollingRowIndex;
        }

        private void dataGridView2_Scroll(object sender, ScrollEventArgs e)
        {
            // dataGridView1 と dataGridView2 に同一の Scroll イベントを割り当てる
            dataGridView1.FirstDisplayedScrollingColumnIndex = dataGridView2.FirstDisplayedScrollingColumnIndex;
            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView2.FirstDisplayedScrollingRowIndex;
        }
    }
}