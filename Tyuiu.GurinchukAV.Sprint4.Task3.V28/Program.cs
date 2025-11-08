using Tyuiu.GurinchukAV.Sprint4.Task3.V28.Lib;
namespace Tyuiu.GurinchukAV.Sprint4.Task3.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Гуринчук А. В. | ИБКСб 25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                              *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнил: Гуринчук Анастасия Витальевна | ИБКСб 25-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 4 до 9. Найдите минимальный      *");
            Console.WriteLine("* элемент в четвертом столбце массива.                                    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] array = new int[5, 5] {
                { 5, 4, 9, 8, 5 },
                { 4, 6, 6, 9, 9 },
                { 9, 8, 4, 8, 8 },
                { 6, 8, 6, 8, 9 },
                { 9, 4, 6, 6, 7 }
            };

            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            Console.WriteLine("Массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.Calculate(array);
            Console.WriteLine("Минимальный элемент в четвертом столбце = " + result);

            Console.ReadKey();
        }
    }
}
