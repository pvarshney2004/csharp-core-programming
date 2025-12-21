using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.String.Level_02
{
    internal class ReverseString
    {
        /*
        Reverse a String
        Problem: Write a C# program to reverse a given string without using any built-in reverse functions.
        */
        public void Reverse(string input)
        {
            char[] chars = input.ToCharArray();
            int i = 0;
            int j = input.Length-1;
            while(i<j)
            {
                char temp = chars[i];
                chars[i] = chars[j];
                chars[j] = temp;
                i++;
                j--;
            }
            Console.WriteLine("Reverse String: " + string.Join("",chars));
        }
    }
}
