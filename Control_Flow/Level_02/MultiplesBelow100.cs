using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Control_Flow.Level_02
{
    internal class MultiplesBelow100
    {
        public void DisplayMultiples(int number)
        {
           
            Console.WriteLine($"Multiples of {number} below 100 are:");
            for (int i = 100; i > 1; i--)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
