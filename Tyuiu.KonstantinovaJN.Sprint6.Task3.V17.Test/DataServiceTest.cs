using Tyuiu.KonstantinovaJN.Sprint6.Task3.V17.Lib;

namespace Tyuiu.KonstantinovaJN.Sprint6.Task3.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] mat = new int[5, 5] { { 22, 32, -16, 24, 27 }, { 3, -20, 24, -20, 25 }, { 21, 17, -8, -19, 17 }, { 8, 22, 28, 27, 19 }, { 11, 20, 12, 27, 29 } };
            int[,] res = new int[5, 5];
            res = ds.Calculate(mat);
            int[,] wait = new int[5, 5] { { 22, 32, -16, -20, 27 }, { 3, -20, 24, -19, 25 }, { 21, 17, -8, 24, 17 }, { 8, 22, 28, 27, 19 }, { 11, 20, 12, 27, 29 } };

            CollectionAssert.AreEqual(res, wait);
        }
    }
}