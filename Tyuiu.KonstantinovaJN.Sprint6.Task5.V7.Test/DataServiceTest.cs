using Tyuiu.KonstantinovaJN.Sprint6.Task5.V7.Lib;

namespace Tyuiu.KonstantinovaJN.Sprint6.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();
            string path = $@"C:\DataSprint6\InPutDataFileTask5V7.txt";
            double[] res = ds.LoadFromDataFile(path);
            double[] wait = new double[] { 13, 11.49, 10, 14.52, 16, 13.66, 19, 11, 11.28 };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}