using Tyuiu.KonstantinovaJN.Sprint6.Task7.V11.Lib;

namespace Tyuiu.KonstantinovaJN.Sprint6.Task7.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            
        }
        static int rows;
        static int columns;
        static string openFilePath;

        DataService ds = new DataService();
        public int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace("\n", "\r");
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;
            int[,] arrayValues = new int[rows, columns];
            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;

            rows = 10;
            columns = 10;
            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInPut.ColumnCount = columns;
            dataGridViewInPut.RowCount = rows;
            dataGridViewOutPut.ColumnCount = columns;
            dataGridViewOutPut.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInPut.Columns[i].Width = 50;
                dataGridViewOutPut.Columns[i].Width = 50;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInPut.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone.Enabled = true;
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            int[,] arraysValues = new int[rows, columns];
            arraysValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutPut.Rows[r].Cells[c].Value = arraysValues[r, c];
                }
            }

            buttonSaveFile.Enabled = true;
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix.FileName = "OutPutFileTask7V11.csv";
            saveFileDialogMatrix.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix.ShowDialog();

            string path = saveFileDialogMatrix.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutPut.RowCount;
            int columns = dataGridViewOutPut.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutPut.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutPut.Rows[i].Cells[j].Value;
                    }
                }

                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }
        
        private void FormMainLoad_Load(object sender, EventArgs e)
        {
            dataGridViewInPut.ColumnCount = 50;
            dataGridViewInPut.RowCount = 50;
            dataGridViewOutPut.ColumnCount = 50;
            dataGridViewOutPut.ColumnCount = 50;

            //panelLeft.Width = this.Width / 2;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewInPut.Columns[i].Width = 25;
                dataGridViewOutPut.Columns[i].Width = 25;
            }
        }
    }
}
