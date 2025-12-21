using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.String.Level_01
{
    internal class DemoFormatException
    {
        /*
         Demonstrate FormatException
        ● Hint =>
            o Use int.Parse() on a non-numeric string to generate FormatException.
            o Use try-catch to handle the exception.
        */
        public void ShowFormatException()
        {
            try
            {
                string s = "ab12";
                int number = int.Parse(s);
                Console.WriteLine(number);
            }
            catch (FormatException e)
            {
                Console.WriteLine("FormatException caught: " + e.Message);
            }
        }
    }
}
