using Tyuiu.BrylinaVV.Sprint1.Task3.V12.Lib;
namespace Tyuiu.BrylinaVV.Sprint1.Task3.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3.5;
            double y = 4.5;
            var res = ds.TriangleArea(x, y);
            Assert.AreEqual(7.875, res);
        }
    }
}
