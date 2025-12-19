using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Control_Flow.Level_03
{
    internal class AbundantNumber
    {
        public void CheckAbundant(int number)
        {
            int sumOfDivisors = 0;
            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    sumOfDivisors += i;
                }
            }
            if (sumOfDivisors > number)
            {
                Console.WriteLine($"{number} is an Abundant number.");
            }
            else
            {
                Console.WriteLine($"{number} is not an Abundant number.");
            }
        }
    }
}
