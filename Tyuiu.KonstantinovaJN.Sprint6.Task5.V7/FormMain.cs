using Tyuiu.KonstantinovaJN.Sprint6.Task5.V7.Lib;

namespace Tyuiu.KonstantinovaJN.Sprint6.Task5.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        string path = $@"C:\DataSprint6\InPutDataFileTask5V7.txt";

        private void buttonDone_Click(object sender, EventArgs e)
        {
            dataGridViewResult.ColumnCount = 2;
            dataGridViewResult.Columns[0].Width = 20;
            dataGridViewResult.Columns[1].Width = 50;

            this.chartFunction.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartFunction.ChartAreas[0].AxisY.Title = "Ось Y";

            chartFunction.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResult.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartFunction.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнила студентка группы ИСПБ-24-1 Константинова Юлия Николаевна", "Сообщение");
        }
    }
}
