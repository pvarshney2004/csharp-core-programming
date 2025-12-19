using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Control_Flow.Level_03
{
    internal class IsArmstrong
    {
        public void CheckArmstrong(int number)
        {
            int originalNumber = number;
            int sum = 0;
            int len = number.ToString().Length;
            while (number > 0)
            {
                int digit = number % 10;
                sum += (int)Math.Pow(digit, len);
                number /= 10;
            }
            if (sum == originalNumber)
            {
                Console.WriteLine($"{originalNumber} is an Armstrong number.");
            }
            else
            {
                Console.WriteLine($"{originalNumber} is not an Armstrong number.");
            }
        }
    }
}
