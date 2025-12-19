using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Control_Flow.Level_03
{
    internal class CountDigits
    {
        public void CountNumberOfDigits(int number)
        {
            int count = 0;
            while (number != 0)
            {
                number = number / 10;
                count++;
            }
            Console.WriteLine("Number of digits: " + count);
        }
    }
}
