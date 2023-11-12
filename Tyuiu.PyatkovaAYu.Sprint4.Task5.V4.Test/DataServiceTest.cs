using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PyatkovaAYu.Sprint4.Task5.V4.Lib;

namespace Tyuiu.PyatkovaAYu.Sprint4.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] { { -4, 3, 5, 1, -2 },
                                          { 0, -4, 0, 6, 4 },
                                          { -4, -4, 2, -2, -1 },
                                          { 4, -3, 4, -1, 6 },
                                          { 1, 4, -1, 3, 0 } };

            int res = ds.Calculate(mas2);
            int wait = 12;

            Assert.AreEqual(wait, res);
        }
    }
}
