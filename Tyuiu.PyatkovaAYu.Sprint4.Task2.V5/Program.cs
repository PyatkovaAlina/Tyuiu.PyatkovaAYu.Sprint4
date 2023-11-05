using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PyatkovaAYu.Sprint4.Task2.V5.Lib;

namespace Tyuiu.PyatkovaAYu.Sprint4.Task2.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();

            Console.Title = "Спринт #3|Выполнил: Пяткова А. Ю. | ИИПб - 23 - 2";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы. (генератор случайных чисел)                   *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил Пяткова А. Ю. | ИИПб-23-2                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 14 элементов, заполненный        *");
            Console.WriteLine("* случайными цифрами в диапазоне от 3 до 9.                               *");
            Console.WriteLine("* Подсчитать произведение четных элементов массива.                       *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите количество элементов массива: ");
            int len = Convert.ToInt32(Console.ReadLine());
            
            int[] numsArray = new int[len];

            for (int i = 0; i < len; i++)
            {
                numsArray[i] = rnd.Next(3,10);
            }

            Console.WriteLine("Массив: ");
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine(numsArray[i] + "\t");
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Произведение чётных элементов массива: ");

            int res = ds.Calculate(numsArray);

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
