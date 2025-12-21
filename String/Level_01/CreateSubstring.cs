using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.String.Level_01
{
    internal class CreateSubstring
    {
        /*
        Create a Substring Using charAt()
        Hint =>
            o Take user input using Console.ReadLine() for string, start index, and end
            index.
            o Write a method to create a substring using charAt() (string[index] in C#).
            o Use string.Substring() to generate the substring and compare the results.
        */
        public void CreateSubstrUsingCharAt(string inputString, int startIndex, int endIndex)
        {
            // substring using string[index]
            StringBuilder subStr = new StringBuilder();
            for (int i = startIndex; i < endIndex; i++)
            {
                subStr.Append(inputString[i]);
            }

            // substring using string.Substring()
            string substrUsingSubstring = inputString.Substring(startIndex, endIndex - startIndex);

            // Display results
            Console.WriteLine($"Substring using charAt: {subStr.ToString()}");
            Console.WriteLine($"Substring using Substring(): {substrUsingSubstring}");
            // Compare results
            if (subStr.ToString() == substrUsingSubstring)
            {
                Console.WriteLine("Both methods produce the same substring.");
            }
            else
            {
                Console.WriteLine("The substrings are different.");
            }
        }
    }
}
