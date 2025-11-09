using Tyuiu.GurinchukAV.Sprint4.Task6.V8.Lib;
namespace Tyuiu.GurinchukAV.Sprint4.Task6.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Гуринчук А. В. | ИБКСб 25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Гуринчук Анастасия Витальевна | ИБКСб 25-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [\"Пицца\", \"Борщ\", \"Пельмени\",         *");
            Console.WriteLine("* \"Омлет\", \"Салат\", \"Суп\", \"Роллы\"], используя класс Array,       *");
            Console.WriteLine("* выведите элементы массива, длина которых больше 4 символов.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string[] array = new string[] { "Пицца", "Борщ", "Пельмени", "Омлет", "Салат", "Суп", "Роллы" };

            Console.WriteLine("Исходный массив:");
            PrintArray(array);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string[] result = ds.Calculate(array);

            Console.WriteLine("Элементы массива с длиной больше 4 символов:");
            PrintArray(result);

            Console.ReadKey();
        }

        static void PrintArray(string[] array)
        {
            foreach (string element in array)
            {
                Console.WriteLine($"[{element}] (длина: {element.Length})");
            }
            Console.WriteLine();
        }
    }
}