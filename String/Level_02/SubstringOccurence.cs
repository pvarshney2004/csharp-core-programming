using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.String.Level_02
{
    internal class SubstringOccurence
    {
        /*
        Find Substring Occurrences
        Problem: Write a C# program to count how many times a given substring occurs in a string
        */

        public void Count(string str, string subStr)
        {
            int count = 0;
            int index = 0;
            while ((index = str.IndexOf(subStr, index, StringComparison.OrdinalIgnoreCase)) != -1)
            {
                count++;
                index += subStr.Length;
            }
            Console.WriteLine($"The substring '{subStr}' occurs {count} times in the string.");
        }
    }
}
