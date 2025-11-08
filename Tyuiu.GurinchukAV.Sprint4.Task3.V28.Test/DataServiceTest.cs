using Tyuiu.GurinchukAV.Sprint4.Task3.V28.Lib;
namespace Tyuiu.GurinchukAV.Sprint4.Task3.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] array = new int[5, 5] {
                { 5, 4, 9, 8, 5 },
                { 4, 6, 6, 9, 9 },
                { 9, 8, 4, 8, 8 },
                { 6, 8, 6, 8, 9 },
                { 9, 4, 6, 6, 7 }
            };

            int wait = 6; 
            int res = ds.Calculate(array);

            Assert.AreEqual(wait, res);
        }
    }
}