using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Programming_Elements.Level_02
{
    internal class PrintQuotientRemainder
    {
        public void CalculateQuotientRemainder(int num1, int num2)
        {
            int quotient = num1 / num2;
            int remainder = num1 % num2;
            Console.WriteLine($"Quotient: {quotient} and Remainder: {remainder}");
        }
    }
}
