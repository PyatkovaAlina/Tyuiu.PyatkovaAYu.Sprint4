using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.PyatkovaAYu.Sprint4.Task3.V28.Lib
{
    public class DataService : ISprint4Task3V28
    {
        public int Calculate(int[,] array)
        {
            int columns = 3;
            int min = array[0, columns];
            
            for (int rows = 0; rows < array.GetLength(0); rows++)
            {
                int tpm = array[rows, columns];
                
                if (tpm < min)
                {
                    min = tpm;
                }
            }
            return min;
        }
    }
}
