using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Built_In_Functions
{
    internal class FactorialUsingRecursion
    {
        /*
          Factorial Using Recursion: Write a program that calculates the factorial of a number using a recursive function
         */
        public int FindFactorial(int number)
        {
            if (number == 1) return 1;
            return number * FindFactorial(number - 1);

        }
    }
}
