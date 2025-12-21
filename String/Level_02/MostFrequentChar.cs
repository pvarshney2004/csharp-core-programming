using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.String.Level_02
{
    internal class MostFrequentChar
    {
        // Write a C# program to find the most frequent character in a string.
        public void Find(string str)
        {
            int[] freq = new int[26];
            foreach (char c in str.ToLower())
            {
                if (char.IsLetter(c))
                {
                    freq[c - 'a']++;
                }
            }
            int maxFreq = 0;
            char mostFrequentChar = ' ';
            for (int i = 0; i < freq.Length; i++)
            {
                if (freq[i] > maxFreq)
                {
                    maxFreq = freq[i];
                    mostFrequentChar = (char)(i + 'a');
                }
            }
            Console.WriteLine($"Most frequent character: {mostFrequentChar}");
        }
    }
}
