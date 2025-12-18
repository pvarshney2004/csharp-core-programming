using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Control_Flow.Level_01
{
    internal class CheckNaturalAndSum
    {
        public void Check(int number)
        {
            int sum = 0;
            if (number > 0)
            {
                sum = (number * (number + 1)) / 2;
                Console.WriteLine($"The sum of natural numbers up to {number} is: {sum}");
            }
            else
            {
                Console.WriteLine("The number is not a natural number.");
            }
        }
    }
}
