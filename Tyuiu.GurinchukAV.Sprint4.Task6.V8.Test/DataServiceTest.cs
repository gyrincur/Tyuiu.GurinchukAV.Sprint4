using Tyuiu.GurinchukAV.Sprint4.Task6.V8.Lib;
namespace Tyuiu.GurinchukAV.Sprint4.Task6.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string[] array = new string[] { "Пицца", "Борщ", "Пельмени", "Омлет", "Салат", "Суп", "Роллы" };

            string[] wait = new string[] { "Пицца", "Пельмени", "Омлет", "Салат", "Роллы" };
            string[] res = ds.Calculate(array);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
