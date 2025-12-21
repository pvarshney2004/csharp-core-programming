using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.String.Level_02
{
    internal class LongestWord
    {
        /*
        Find the Longest Word in a Sentence
        Problem: Write a C# program that takes a sentence as input and returns the longest word in the
        sentence.
        */

        public void FindLongestWord(string input)
        {
            input = input.ToLower();
            string[] words = input.Split(' ');
            string longestWord = "";
            foreach (string word in words)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }
            Console.WriteLine("The longest word is: " + longestWord);
        }
    }
}
