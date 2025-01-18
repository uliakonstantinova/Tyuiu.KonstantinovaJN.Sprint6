using Tyuiu.KonstantinovaJN.Sprint6.Task6.V13.Lib;

namespace Tyuiu.KonstantinovaJN.Sprint6.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            DataService ds = new DataService();
            string path = $@"C:\DataSprint6\InPutDataFileTask6V13.txt";
            string res = ds.CollectTextFromFile(path);
            string[] resArray = res.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string[] wait = new string[] { "WLCdQb", "ehWGn", "McJC", "lhTKeblSG", "dXbj" };
            CollectionAssert.AreEqual(wait, resArray);
        }
    }
}