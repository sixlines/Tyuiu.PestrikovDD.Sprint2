using Tyuiu.PestrikovDD.Sprint2.Task0.V12.Lib;
namespace Tyuiu.PestrikovDD.Sprint2.Task0.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(6, res);
        }
    }
}
