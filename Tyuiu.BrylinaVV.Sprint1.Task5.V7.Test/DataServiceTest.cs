using Tyuiu.BrylinaVV.Sprint1.Task5.V7.Lib;
namespace Tyuiu.BrylinaVV.Sprint1.Task5.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 30;
            int wait = 1;
            int res = ds.AngleToHoursMinutes(x);
            Assert.AreEqual(wait, res);
        }
    }
}
