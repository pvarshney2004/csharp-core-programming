using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.String.Level_02
{
    internal class RemoveSpecificChar
    {
        //Problem: Write a C# program to remove all occurrences of a specific character from a string.
        public void RemoveChar(string input, char ch)
        {
            StringBuilder result = new StringBuilder();
            foreach (char c in input)
            {
                if (c != ch)
                {
                    result.Append(c);
                }
            }
            Console.WriteLine("Modified String: "+result.ToString());
        }
    }
}
