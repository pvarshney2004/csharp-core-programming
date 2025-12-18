using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Control_Flow.Level_01
{
    internal class FactorialUsingWhile
    {
        public void CalculateFactorial(int n)
        {
            int factorial = 1;
            int i = 1;
            while (i <= n)
            {
                factorial *= i;
                i++;
            }
            Console.WriteLine($"Factorial of {n} is {factorial}");
        }
    }
}
