﻿using Tyuiu.KorotkovNS.Sprint4.Task5.V24.Lib;
namespace Tyuiu.KorotkovNS.Sprint4.Task5.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();

            Console.Title = "Спринт #4 | Выполнил: Коротков Н. С. | ИСТНб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (генератор случайных чисел)                    *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Коротков Никита Сергеевич | ИСТНб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Найти количество положительных элементов массива                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите количество строк в массиве: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов в массиве: ");
            int colms = Convert.ToInt32(Console.ReadLine());

            int[,] mtrx = new int[rows, colms];

            Console.WriteLine();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colms; j++)
                {
                    mtrx[i, j] = rnd.Next(-7, 6);
                }
            }

            Console.WriteLine("\nМассив: ");
            for (int i = 0; i < colms; i++)
            {
                for (int j = 0; j < colms; j++)
                {
                    Console.Write($"{mtrx[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Количество положительных чисел = " + ds.Calculate(mtrx));


            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
