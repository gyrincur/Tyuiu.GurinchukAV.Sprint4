using Tyuiu.GurinchukAV.Sprint4.Task5.V25.Lib;
namespace Tyuiu.GurinchukAV.Sprint4.Task5.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5] {
                { -3,  2, -1,  0, -2 },
                {  1, -4,  3, -2,  2 },
                { -1,  0,  2, -3,  1 },
                { -2,  3, -4,  1,  0 },
                {  0, -1,  2, -2,  3 }
            };

            int wait = 2 + 1 + 3 + 2 + 2 + 1 + 3 + 1 + 2 + 3; 
            int res = ds.Calculate(matrix);

            Assert.AreEqual(wait, res);
        }
    }
}
