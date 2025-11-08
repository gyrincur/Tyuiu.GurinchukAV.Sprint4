using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.GurinchukAV.Sprint4.Task3.V28.Lib
{
    public class DataService : ISprint4Task3V28
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetLength(0);
            int minValue = int.MaxValue;
            int columnIndex = 3;

            for (int i = 0; i < rows; i++)
            {
                if (array[i, columnIndex] < minValue)
                {
                    minValue = array[i, columnIndex];
                }
            }

            return minValue;
        }
    }
}
