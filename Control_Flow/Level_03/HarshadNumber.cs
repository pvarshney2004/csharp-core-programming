using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Control_Flow.Level_03
{
    internal class HarshadNumber
    {
        public void CheckHarshad(int number)
        {
            int temp = number;
            int sum = 0;
            while (temp > 0)
            {
                sum += temp % 10;
                temp /= 10;
            }
            if (number % sum == 0)
            {
                Console.WriteLine(number + " is a Harshad number.");
            }
            else
            {
                Console.WriteLine(number + " is not a Harshad number.");
            }
        }
    }
}
