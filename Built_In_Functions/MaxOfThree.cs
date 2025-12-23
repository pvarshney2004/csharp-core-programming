using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Built_In_Functions
{
    internal class MaxOfThree
    {
        /*
Maximum of Three Numbers:
Write a program that takes three integer inputs from the user and finds the maximum of the
three numbers.
         */
        public int FindMaximum(int num1, int num2, int num3)
        {
            return Math.Max(num1, Math.Max(num2, num3));

        }
    }
}
