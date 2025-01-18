using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KonstantinovaJN.Sprint6.Task7.V11.Lib
{
    public class DataService : ISprint6Task7V11
    {
        public int[,] GetMatrix(string path)
        {
            string[] lines = System.IO.File.ReadAllLines(path);
            lines = lines.Where(line => !string.IsNullOrWhiteSpace(line)).ToArray();

            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            int[,] matrix = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] values = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    if (!string.IsNullOrWhiteSpace(values[c]))
                    {
                        matrix[r, c] = int.Parse(values[c]);
                    }
                    else
                    {
                        matrix[r, c] = 0;
                    }
                }
            }

            int targetRow = 4;

            for (int c = 0; c < columns; c++)
            {
                if (matrix[targetRow, c] < 0)
                {
                    matrix[targetRow, c] = 9;
                }
            }

            return matrix;
        }
    }
}
