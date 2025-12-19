using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Control_Flow.Level_02
{
    internal class FindFactors
    {
        public void DisplayFactors(int number)
        {
            if (number <= 0)
            {
                Console.WriteLine("Number must be greater than zero.");
                return;
            }
            Console.WriteLine($"Factors of {number} are:");
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
