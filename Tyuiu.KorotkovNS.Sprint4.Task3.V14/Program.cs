using Tyuiu.KorotkovNS.Sprint4.Task3.V14.Lib;
namespace Tyuiu.KorotkovNS.Sprint4.Task3.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int[,] array = new int[5, 5] { { 3, 2, 3, 3, 5 },
                                          { 2, 3, 3, 7, 3 },
                                          { 7, 5, 2, 7, 3 },
                                          { 4, 2, 7, 5, 2 },
                                          { 3, 5, 4, 2, 6 } };
            int rows = array.GetUpperBound(0) + 1; // кол-во строк
            int colms = array.Length / rows; // кол-во столбцов

            Console.Title = "Спринт #4 | Выполнил: Коротков Н. С. | ИСТНб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод         )                    *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #14                                                              *");
            Console.WriteLine("* Выполнил: Коротков Никита Сергеевич | ИСТНб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Найти максимальный элемент в четвертой строке массива                   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Массив");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colms;  j++)
                {
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Максимальный элемент = " + ds.Calculate(array));


            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
