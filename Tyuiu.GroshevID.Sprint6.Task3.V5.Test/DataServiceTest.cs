using Tyuiu.GroshevID.Sprint6.Task3.V5.Lib;

namespace Tyuiu.GroshevID.Sprint6.Task3.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] wait = new int[,] { };
            int[,] matrix = new int[,] { { 30, -20, 7, -8, 9 }, { 32, 17, -14, -7, 33 }, { 19, -19, -13, 14, -20 }, { 11, 30, -1, 26, 6 }, { 30, -15, -20, -5, 15 } };
            int[,] res = ds.Calculate(matrix);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
