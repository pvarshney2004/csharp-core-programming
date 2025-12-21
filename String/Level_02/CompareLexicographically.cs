using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.String.Level_02
{
    internal class CompareLexicographically
    {
        /*
        Compare Two Strings
        Problem: Write a C# program to compare two strings lexicographically (dictionary order) without
        using built-in compare methods.
        */

        public void CompareStrings(string str1, string str2)
        {
            if(str1 == str2)
            {
                Console.WriteLine("Both strings are equal.");
                return;
            }
            int len = Math.Min(str1.Length, str2.Length);
            for(int i = 0; i < len; i++)
            {
                if(str1[i] != str2[i])
                {
                    if(str1[i] < str2[i])
                    {
                        Console.WriteLine($"{str1} comes before {str2} in lexicographical order.");
                    }
                    else
                    {
                        Console.WriteLine($"{str2} comes before {str1} in lexicographical order.");
                    }
                    break;

                }
            }
        }
    }
}
