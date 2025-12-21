using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.String.Level_01
{
    internal class DemoIndexOutOfRange02
    {
        /*
          Demonstrate IndexOutOfRangeException
          ● Hint =>
            o Access an invalid index of a string using charAt() (string[index] in C#) to
            generate the exception.
            o Write another method with try-catch to handle the exception.
         */
        public void ShowIndexOutOfRangeException()
        {
            string str = "This is a demo string";
            try
            {
                // Accessing an invalid index to generate IndexOutOfRangeException
                char ch = str[25]; // Invalid index
                Console.WriteLine("Character at index 20: " + ch);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("IndexOutOfRangeException caught: " + ex.Message);
            }
        }
    }
}
