using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.String.Level_02
{
    internal class CheckPalindrome
    {
        /*
        Palindrome String Check
        Problem: Write a C# program to check if a given string is a palindrome (a string that reads the
        same forward and backward).
        */
        public void IsPalindrome(string input)
        {
            char[] chars = input.ToCharArray();
            int i = 0;
            int j = chars.Length - 1;
            bool flag = true;
            while (i < j)
            {
                if (chars[i] != chars[j])
                {
                    flag = false;
                    break;
                }
                i++;
                j--;
            }
            if (flag)
            {
                Console.WriteLine("String is palindrome");
            }
            else
            {
                Console.WriteLine("String is not palindrome");
            }
        }
    }
}
