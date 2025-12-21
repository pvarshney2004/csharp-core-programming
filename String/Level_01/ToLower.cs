using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.String.Level_01
{
    internal class ToLower
    {
        /*
        Convert Text to Lowercase
        ● Hint =>
            o Write a method to convert each character in a string to lowercase using ASCII
            logic (char manipulation).
            o Compare the result with the built-in string.ToLower(). 
        */
        public void ConvertToLowerCase(string input)
        {
            string lowerCaseString = input.ToLower();
            string lowerCaseString2 = "";
            foreach (char ch in input)
            {
                if (ch >= 'A' && ch <= 'Z')
                {
                    //explicit conversion
                    lowerCaseString2 += (char)(ch + 32);
                }
                else
                {
                    lowerCaseString2 += ch;
                }
            }
            Console.WriteLine("Using ToLower(): " + lowerCaseString);
            Console.WriteLine("Without Using ToLower(): " + lowerCaseString2);

            // comparing results from both methods
            if (lowerCaseString == lowerCaseString2)
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
