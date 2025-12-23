using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Built_In_Functions
{
    internal class PrimeChecker
    {
        /*
          Prime Number Checker: Create a program that checks whether a given number is a prime number.
         */
        public bool IsPrime(int number)
        {
            bool flag = true;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
