using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.PyatkovaAYu.Sprint4.Task3.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3|Выполнил: Пяткова А. Ю. | ИИПб - 23 - 2";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                             *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнил Пяткова А. Ю. | ИИПб-23-2                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 4 до 9.                          *");
            Console.WriteLine("* Найдите минимальный элемент в четвертом столбце массива.                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("{ 5, 4, 9, 8, 5 },\r\n{ 4, 6, 6, 9, 9 },\r\n{ 9, 8, 4, 8, 8 },\r\n{ 6, 8, 6, 8, 9 },\r\n{ 9, 4, 6, 6, 7 }");

            int[,] arr = {
            {5,4,9,8,5 },
            {4,6,6,9,9 },
            {9,8,4,8,8 },
            {6,8,6,8,9 },
            {9,4,6,6,7 } };
            int column = 3;
            int min = arr[0, column];
            for (int row = 0; row < arr.GetLength(0); row++)
            {
                int tpm = arr[row, column];
                if (tpm < min)
                {
                    min = tpm;
                }
            }
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Минимальный элемент в четвертом столбце массива: ");
            Console.WriteLine($"{min}");
            Console.ReadKey();
        }
    }
}
