using Tyuiu.GurinchukAV.Sprint4.Task7.V22.Lib;
namespace Tyuiu.GurinchukAV.Sprint4.Task7.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string value = "695324951753684";
            int n = 5;
            int m = 3;

            int wait = 6 * 2 * 4 * 6 * 8 * 4; 
            int res = ds.Calculate(n, m, value);

            Assert.AreEqual(wait, res);
        }
    }
}
