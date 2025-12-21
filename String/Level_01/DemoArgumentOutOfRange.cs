using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.String.Level_01
{
    internal class DemoArgumentOutOfRange
    {
        /*
        Demonstrate ArgumentOutOfRangeException
        ● Hint =>
            o Use string.Substring() with start index greater than the end index to generate
              an ArgumentOutOfRangeException.
            o Use try-catch to handle the exception. 
        */
        public void ShowArgumentException()
        {
            string str = "Hello World";
            try
            {
                string subString = str.Substring(18); //accessing index greater than length
                Console.WriteLine("Substring: " + subString);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("ArgumentOutOfRangeException caught: " + ex.Message);
            }
        }
    }
}
