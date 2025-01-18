using Tyuiu.KonstantinovaJN.Sprint6.Task3.V17.Lib;

namespace Tyuiu.KonstantinovaJN.Sprint6.Task3.V17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] { { 22, 32, -16, 24, 27 }, 
                                     { 3, -20, 24, -20, 25 }, 
                                     { 21, 17, -8, -19, 17 }, 
                                     { 8, 22, 28, 27, 19 }, 
                                     { 11, 20, 12, 27, 29 } };

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнила студентка группы ИСПБ-24-1 Константинова Юлия Николаевна", "Сообщение");
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;
            dataGridViewRes.ColumnCount = columns;
            dataGridViewRes.RowCount = rows;
            for (int i = 0; i < columns; i++)
            {
                dataGridViewRes.Columns[i].Width = 50;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewRes.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            int[,] res = ds.Calculate(mtrx);
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewResult.ColumnCount = columns;
            dataGridViewResult.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewResult.Columns[i].Width = 50;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult.Rows[i].Cells[j].Value = Convert.ToString(res[i, j]);
                }
            }
        }
    }
}