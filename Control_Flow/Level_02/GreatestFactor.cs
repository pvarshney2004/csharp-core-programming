using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Control_Flow.Level_02
{
    internal class GreatestFactor
    {
        public void FindGreatestFactor(int number)
        {
            if (number <= 1)
            {
                Console.WriteLine("Number must be greater than 1.");
                return;
            }
            int greatestFactor = 1;
            for (int i = number-1; i >= 1; i--)
            {
                if (number % i == 0)
                {
                    greatestFactor = i;
                    break;
                }
            }
            Console.WriteLine($"The greatest factor of {number} is: {greatestFactor}");
        }
    }
}
