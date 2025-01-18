using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KonstantinovaJN.Sprint6.Task6.V13.Lib
{
    public class DataService : ISprint6Task6V13
    {
        public int len = 0;
        public string CollectTextFromFile(string path)
        {
            string strResult;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != "")
                {
                    len++;
                }
            }

            using (StreamReader reader = new StreamReader(path))
            {
                int index = 0;
                string[] res = new string[len];
                string line;
                while ((line = reader.ReadLine()) != "")
                {
                    string[] words = line.Split(' ');
                    res[index] = words[words.Length - 2];
                    index++;
                }
                strResult = string.Join(" ", res);
            }
            return strResult;
        }
    }
}
