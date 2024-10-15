using Tyuiu.AkhmedullovRR.Sprint2.Task5.V11.Lib;
namespace Tyuiu.AkhmedullovRR.Sprint2.Task5.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay()
        {
            DataService ds = new DataService();
            int g = 2024;
            int m = 9;
            int n = 9;
            var res = ds.FindDateOfNextDay(g, m, n);
            string wait = "10.09.2024";
            Assert.AreEqual(wait, res);
        }
    }
}