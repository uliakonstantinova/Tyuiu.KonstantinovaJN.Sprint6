using Tyuiu.KonstantinovaJN.Sprint6.Task0.V12.Lib;

namespace Tyuiu.KonstantinovaJN.Sprint6.Task0.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            double wait = 1.741;
            Assert.AreEqual(wait, res);
        }
    }
}