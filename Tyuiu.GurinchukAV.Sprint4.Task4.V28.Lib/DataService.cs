using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.GurinchukAV.Sprint4.Task4.V28.Lib
{
    public class DataService : ISprint4Task4V28
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            int[,] resultMatrix = (int[,])matrix.Clone();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (resultMatrix[i, j] % 2 == 0) 
                    {
                        resultMatrix[i, j] = 1;
                    }
                }
            }

            return resultMatrix;
        }
    }
}