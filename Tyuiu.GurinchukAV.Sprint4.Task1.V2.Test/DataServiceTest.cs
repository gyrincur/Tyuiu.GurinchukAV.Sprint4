using Tyuiu.GurinchukAV.Sprint4.Task1.V2.Lib;
namespace Tyuiu.GurinchukAV.Sprint4.Task1.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = { 1, 7, 2, 2, 6, 2, 3, 2, 3, 5, 7, 7, 1, 2 };
            int wait = 34; 
            int res = ds.Calculate(array);

            Assert.AreEqual(wait, res);
        }
    }
}