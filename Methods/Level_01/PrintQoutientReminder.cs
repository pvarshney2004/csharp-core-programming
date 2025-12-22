using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Methods.Level_01
{
    internal class PrintQoutientReminder
    {
        /*
         * Write a program to take 2 numbers and print their quotient and reminder
        */
        public int[] CalculateQuotientAndRemainder(int dividend, int divisor)
        {
            int quotient = dividend / divisor;
            int remainder = dividend % divisor;
            return new int[] { quotient, remainder };
        }

    }
}
