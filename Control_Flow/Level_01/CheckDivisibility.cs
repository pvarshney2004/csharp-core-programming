using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Control_Flow.Level_01
{
    internal class CheckDivisibility
    {
        public void check(int num)
        {
           bool divisibleBy5 = (num % 5 == 0);
            if (divisibleBy5)
            {
                Console.WriteLine($"{num} is divisible by 5.");
            }
            else
            {
                Console.WriteLine($"{num} is not divisible by 5.");
            }
        }
    }
}
