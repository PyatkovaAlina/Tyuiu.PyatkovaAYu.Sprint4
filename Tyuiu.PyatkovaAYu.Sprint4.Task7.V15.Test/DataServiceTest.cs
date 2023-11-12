using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PyatkovaAYu.Sprint4.Task7.V15.Lib;

namespace Tyuiu.PyatkovaAYu.Sprint4.Task7.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            int n = 4;
            int m = 2;
            int[,] mtrx = new int[n, m];
            string str = "10293847";
            DataService ds = new DataService();
            int res = ds.Calculate(n, m, str);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}
