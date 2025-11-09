using Tyuiu.GurinchukAV.Sprint4.Task4.V28.Lib;
namespace Tyuiu.GurinchukAV.Sprint4.Task4.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Гуринчук А. В. | ИБКСб 25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (ввод с клавиатуры)                             *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнил: Гуринчук Анастасия Витальевна | ИБКСб 25-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 1 до 5. Заменить четные          *");
            Console.WriteLine("* элементы массива на 1.                                                  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите элементы массива 5x5 (значения от 1 до 5):");

            int rows = 5;
            int columns = 5;
            int[,] array = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Введите элемент [{i},{j}]: ");
                    int value = Convert.ToInt32(Console.ReadLine());
                    while (value < 1 || value > 5)
                    {
                        Console.Write("Ошибка! Введите значение от 1 до 5: ");
                        value = Convert.ToInt32(Console.ReadLine());
                    }
                    array[i, j] = value;
                }
            }

            Console.WriteLine("\nИсходный массив:");
            PrintMatrix(array);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int[,] result = ds.Calculate(array);

            Console.WriteLine("Массив после замены чётных элементов на 1:");
            PrintMatrix(result);

            Console.ReadKey();
        }

        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}