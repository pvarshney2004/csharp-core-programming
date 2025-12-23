using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Built_In_Functions
{
    internal class PalindromeString
    {
        /*
Palindrome Checker:
Write a program that checks if a given string is a palindrome (a word, phrase, or sequence
that reads the same backward as forward).
         */
        public bool IsPalindrome(string str)
        {
            char[] chr = str.ToCharArray();
            Array.Reverse(chr);
            string reversedString = new string(chr);
            return str == reversedString;

        }
    }
}
