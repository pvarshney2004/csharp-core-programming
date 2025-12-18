using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Control_Flow.Level_01
{
    internal class PrintOddEven
    {
        public void PrintOddEvenNumbers(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} is Even");
                }
                else
                {
                    Console.WriteLine($"{i} is Odd");
                }
            }
        }
    }
}
