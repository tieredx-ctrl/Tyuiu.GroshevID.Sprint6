using Tyuiu.GroshevID.Sprint6.Task0.V7.Lib;

namespace Tyuiu.GroshevID.Sprint6.Task0.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            double wait = 0.211;
            Assert.AreEqual(wait, res);
        }
    }
}
