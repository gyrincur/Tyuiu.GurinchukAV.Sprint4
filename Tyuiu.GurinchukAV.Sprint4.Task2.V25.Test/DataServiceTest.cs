using Tyuiu.GurinchukAV.Sprint4.Task2.V25.Lib;
namespace Tyuiu.GurinchukAV.Sprint4.Task2.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = { 4, 5, 6, 7, 8, 3, 4, 9, 6, 8, 4 };
            int wait = 4 * 6 * 8 * 4 * 6 * 8 * 4;
            int res = ds.Calculate(array);

            Assert.AreEqual(wait, res);
        }
    }
}

