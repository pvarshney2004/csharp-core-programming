using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.String.Level_02
{
    internal class CountVowelConsonant
    {
        /*
        Count Vowels and Consonants
        Problem: Write a C# program to count the number of vowels and consonants in a given string.
        */
        public void Count(string input)
        {
            int vowelsCount = 0;
            int consonantCount = 0;
            foreach(char ch in input)
            {
                if(IsVowel(ch))
                {
                    vowelsCount++;
                }
                else
                {
                    consonantCount++;
                }
            }
            Console.WriteLine("Vowels: " + vowelsCount);
            Console.WriteLine("Consonants: " + consonantCount);
        }
        public bool IsVowel(char ch)
        {
            return "aeiou".IndexOf(ch) != -1;
        }
    }
}
