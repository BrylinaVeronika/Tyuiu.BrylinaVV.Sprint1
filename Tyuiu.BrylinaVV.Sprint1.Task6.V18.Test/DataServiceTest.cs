using Tyuiu.BrylinaVV.Sprint1.Task6.V18.Lib;
namespace Tyuiu.BrylinaVV.Sprint1.Task6.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string s = "234";
            Assert.AreEqual(true, ds.CheckNumber(s));
        }
    }
}
