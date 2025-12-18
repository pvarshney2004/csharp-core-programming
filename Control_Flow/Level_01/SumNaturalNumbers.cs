using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Control_Flow.Level_01
{
    internal class SumNaturalNumbers
    {
        public void SumNumbers(int n) 
        {
            int sumUsingWhileLoop = 0;
            int sumUsingFormula = 0;
            int i = 1;
            while(i<=n) 
            {
                sumUsingWhileLoop += i;
                i++;
            }
            sumUsingFormula = n * (n + 1) / 2;
            Console.WriteLine($"Sum of first {n} natural numbers using while loop: {sumUsingWhileLoop}");
            Console.WriteLine($"Sum of first {n} natural numbers using formula: {sumUsingFormula}");
        }
    }
}
