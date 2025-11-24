using Tyuiu.PestrikovDD.Sprint2.Task4.V3.Lib;
namespace Tyuiu.PestrikovDD.Sprint2.Task4.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculateValid1()
        {
            DataService ds = new DataService();
            double x = 2, y = 4;
            Assert.AreEqual(ds.Calculate(x, y), 4.75);

        }
        [TestMethod]
        public void CalculateValid2()
        {
            DataService ds = new DataService();
            double x = 2, y = 3;
            Assert.AreEqual(ds.Calculate(x, y), 3);
        }
    }
}
