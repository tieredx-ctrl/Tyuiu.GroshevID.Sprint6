using Tyuiu.GroshevID.Sprint6.Task1.V13.Lib;

namespace Tyuiu.GroshevID.Sprint6.Task1.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            double[] wait = { };
            double[] res = ds.GetMassFunction(-5, 5);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
