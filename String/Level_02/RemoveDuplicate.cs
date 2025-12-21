using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.String.Level_02
{
    internal class RemoveDuplicate
    {
        /*
         Remove Duplicates from a String
        Problem: Write a C# program to remove all duplicate characters from a given string and return the
        modified string
        */

        public void RemoveDuplicates(string input)
        {
            StringBuilder result = new StringBuilder();
            foreach (char c in input)
            {
                if (!result.ToString().Contains(c))
                {
                    result.Append(c);
                }
            }
            Console.WriteLine("String after removing duplicates: " + result.ToString());
        }
    }
}
