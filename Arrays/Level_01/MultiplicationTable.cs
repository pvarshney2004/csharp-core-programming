using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Arrays.Level_01
{
    internal class MultiplicationTable
    {
        public void PrintTable(int number)
        {
            int[] result = new int[10];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = number * (i + 1);
                Console.WriteLine(number + " x " + (i + 1) + " = " + result[i]);
            }
        }
    }
}
