using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PyatkovaAYu.Sprint4.Task6.V27.Lib;

namespace Tyuiu.PyatkovaAYu.Sprint4.Task6.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            var shapes = new string[] { "Квадрат", "Прямоугольник", "Круг", "Треугольник", "Пятиугольник", "Шестиугольник", "Восьмиугольник" };
            int res = ds.Calculate(shapes);
            int wait = 1;
            Assert.AreEqual(wait, res);
        }
    }
}
