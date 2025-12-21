using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.String.Level_01
{
    internal class ToUpper
    {
        /*
        Convert Text to Uppercase
        ● Hint =>
            o Write a method to convert each character in a string to uppercase using ASCII
            logic (char manipulation).
            o Compare the result with the built-in string.ToUpper(). 
        */
        public void ConvertToUpperCase(string input)
        {
            string upperCaseString = input.ToUpper();
            string upperCaseString2 = "";
            foreach (char ch in input)
            {
                if (ch >= 'a' && ch <= 'z')
                {
                    //explicit conversion
                    upperCaseString2 += (char)(ch - 32);
                }
                else
                {
                    upperCaseString2 += ch;
                }
            }
            Console.WriteLine("Using ToUpper(): " + upperCaseString);
            Console.WriteLine("Without Using ToUpper(): " + upperCaseString2);
            // comparing results from both methods
            if (upperCaseString == upperCaseString2)
            {
                Console.WriteLine("Both methods give the same result.");
            }
            else
            {
                Console.WriteLine("Results differ between methods.");
            }
        }
    }
}
