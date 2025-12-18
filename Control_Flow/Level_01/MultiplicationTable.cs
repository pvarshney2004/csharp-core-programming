using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Control_Flow.Level_01
{
    internal class MultiplicationTable
    {
        public void PrintMultiplicationTableFrom6To9(int num)
        {
            for (int i = 6; i <= 9; i++)
            {
                Console.WriteLine($"Multiplication Table of {i}:");
                for (int j = 1; j <= num; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
                Console.WriteLine();
            }
        }
    }
}
