using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PyatkovaAYu.Sprint4.Task7.V15.Lib;

namespace Tyuiu.PyatkovaAYu.Sprint4.Task7.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            int m = 2;
            int[,] mtrx = new int[n, m];

            string str = "10293847";

            DataService ds = new DataService();

            Console.Title = "Спринт #4|Выполнил: Пяткова А. Ю. | ИИПб - 23 - 2";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил Пяткова А. Ю. | ИИПб-23-2                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр '10293847'.                           *");
            Console.WriteLine("* Преобразуйте ее в матрицу 4 на 2                                        *");
            Console.WriteLine("* и подсчитайте количество нечетных чисел в матрице.                      *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int index = 0;

            Console.WriteLine("\nМассив:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{str[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(n, m, str);

            Console.WriteLine("Количество нечетных чисел в матрице: " + res);
            Console.ReadKey();
        }
    }
}
