using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Control_Flow.Level_01
{
    internal class CheckPositiveNegativeZero
    {
        public void Check(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"{number} is Positive");
            }
            else if (number < 0)
            {
                Console.WriteLine($"{number} is Negative");
            }
            else
            {
                Console.WriteLine("The number is Zero");
            }
        }
    }
}
