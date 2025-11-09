using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.GurinchukAV.Sprint4.Task7.V22.Lib
{
    public class DataService : ISprint4Task7V22
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] matrix = new int[n, m];
            int product = 1;
            bool hasEven = false;

           
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(value[i * m + j].ToString());
                    if (matrix[i, j] % 2 == 0)
                    {
                        product *= matrix[i, j];
                        hasEven = true;
                    }
                }
            }
            return hasEven ? product : 0;
        }
    }
}
