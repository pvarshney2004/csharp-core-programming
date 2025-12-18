using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Control_Flow.Level_01
{
    internal class FactorialUsingFor
    {
        public void CalculateFactorial(int n)
        {
            int factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"Factorial of {n} is {factorial}");
        }
    }
}
