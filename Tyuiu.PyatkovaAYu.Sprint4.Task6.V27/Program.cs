using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PyatkovaAYu.Sprint4.Task6.V27.Lib;

namespace Tyuiu.PyatkovaAYu.Sprint4.Task6.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4|Выполнил: Пяткова А. Ю. | ИИПб - 23 - 2";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил Пяткова А. Ю. | ИИПб-23-2                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных.                                            *");
            Console.WriteLine("* Используя класс Array, подсчитайте количество элементов,                *");
            Console.WriteLine("* длина которых меньше 7                                                  *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            var shapes = new string[] {"Квадрат", "Прямоугольник", "Круг", "Треугольник", "Пятиугольник", "Шестиугольник", "Восьмиугольник"};
           
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < shapes.Length; i++)
            {
                Console.WriteLine(shapes[i]);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Количество элементов, длина которых меньше 7: ");

            int nums = ds.Calculate(shapes);

            Console.WriteLine(nums);
            Console.ReadKey();
        }
    }
}
