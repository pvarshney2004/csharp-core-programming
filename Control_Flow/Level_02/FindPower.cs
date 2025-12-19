using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Control_Flow.Level_02
{
    internal class FindPower
    {
        public void CalculatePower(int number, int power)
        {
            int result = 1;
            for(int i=1; i<=power; i++)
            {
                result *= number;
            }
            Console.WriteLine($"{number} raised to the power of {power} is: {result}");

        }
    }
}
