using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KonstantinovaJN.Sprint6.Task5.V7.Lib
{
    public class DataService : ISprint6Task5V7
    {
        public int len = 0;

        public double[] LoadFromDataFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string trimmedLine = line.Trim();
                    if (!string.IsNullOrEmpty(trimmedLine))
                    {
                        // Пробуем конвертировать строку в число
                        if (double.TryParse(trimmedLine, out double number) && number > 5)
                        {
                            len++;
                        }
                    }
                }
            }

            double[] numsArray = new double[len];
            int i = 0;

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string trimmedLine = line.Trim();
                    if (!string.IsNullOrEmpty(trimmedLine))
                    {
                        // Пробуем конвертировать строку в число
                        if (double.TryParse(trimmedLine, out double number) && number > 5)
                        {
                            numsArray[i] = number; // Сохраняем число в массив
                            i++;
                        }
                    }
                }
            }

            return numsArray;
        }
    }
}
