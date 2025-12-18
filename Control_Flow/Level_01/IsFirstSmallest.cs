using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Control_Flow.Level_01
{
    internal class IsFirstSmallest
    {
        public void Check(int a, int b, int c)
        {
            if (a < b && a < c)
            {
                Console.WriteLine($"{a} is the smallest number.");
            }
            else
            {
                Console.WriteLine($"{a} is not the smallest number.");
            }
        }
    }
}
