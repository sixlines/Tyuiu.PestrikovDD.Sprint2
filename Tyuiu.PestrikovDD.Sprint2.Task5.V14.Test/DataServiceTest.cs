using Tyuiu.PestrikovDD.Sprint2.Task5.V14.Lib;
namespace Tyuiu.PestrikovDD.Sprint2.Task5.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            Assert.AreEqual("Ïîíåäåëüíèê", ds.FindDayName(1, 1));
            Assert.AreEqual("Âòîðíèê", ds.FindDayName(2, 2));
            Assert.AreEqual("Ñðåäà", ds.FindDayName(3, 3));
            Assert.AreEqual("×åòâåðã", ds.FindDayName(4, 4));
            Assert.AreEqual("Ïÿòíèöà", ds.FindDayName(5, 5));
            Assert.AreEqual("Ñóááîòà", ds.FindDayName(6, 6));
            Assert.AreEqual("Âîñêðåñåíüå", ds.FindDayName(7, 7));

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDayName(-1, -1);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDayName(368, 369);
            });
        }
    }
}
