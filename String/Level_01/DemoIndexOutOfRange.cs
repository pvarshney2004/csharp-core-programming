using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.String.Level_01
{
    internal class DemoIndexOutOfRange
    {
        /*
         Demonstrate IndexOutOfRangeException for Arrays
        ● Hint =>
            o Access an invalid index of an array to generate an IndexOutOfRangeException.
            o Use try-catch to handle the exception.
        */
        public void ShowIndexOutOfRangeException()
        {
            try
            {
                int[] numbers = { 1, 2, 3, 4, 5 };
                // Accessing an invalid index
                Console.WriteLine(numbers[10]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("IndexOutOfRangeException caught: " + e.Message);
            }
        }
    }
}
