using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Control_Flow.Level_01
{
    internal class SumUntilUserEnterZero
    {
        public void CalculateSum()
        {
            int sum = 0;
            Console.WriteLine("Enter numbers to sum them up. Enter 0 to stop.");
            while (true)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                if (num == 0)
                {
                    break;
                }
                sum+= num;
            }
            Console.WriteLine($"The total sum is: {sum}");
        }
    }
}
