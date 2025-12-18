using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Control_Flow.Level_01
{
    internal class SumNaturalNumbersFor
    {
        public void SumUsingFor(int n) {
            int sumUsingForLoop = 0;
            int sumUsingFormula = 0;
            for(int i=1; i<=n; i++) 
            {
                sumUsingForLoop += i;
            }
            sumUsingFormula = n * (n + 1) / 2;
            Console.WriteLine($"Sum of first {n} natural numbers using for loop: {sumUsingForLoop}");
            Console.WriteLine($"Sum of first {n} natural numbers using formula: {sumUsingFormula}");
        }
    }
}
