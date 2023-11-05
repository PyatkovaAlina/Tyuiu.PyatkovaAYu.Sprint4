using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PyatkovaAYu.Sprint4.Task2.V5.Lib;


namespace Tyuiu.PyatkovaAYu.Sprint4.Task2.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            DataService ds = new DataService();

            int[] numsArray = { 4, 8, 6, 3, 7, 3, 7, 4, 9, 5, 6, 3, 4, 9 };

            int res = ds.Calculate(numsArray);
            int wait = 18432;

            Assert.AreEqual(wait, res);
        }
    }
}
