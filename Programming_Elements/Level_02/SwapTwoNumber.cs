using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Programming_Elements.Level_02
{
    internal class SwapTwoNumber
    {
        public void SwapNumbers(int a, int b)
        {
            Console.WriteLine("Before Swapping: ");
            Console.WriteLine("First Number: " + a);
            Console.WriteLine("Second Number: " + b);
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After Swapping: ");
            Console.WriteLine("First Number: " + a);
            Console.WriteLine("Second Number: " + b);
        }
    }
}
