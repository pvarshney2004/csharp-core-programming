using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.String.Level_01
{
    internal class SplitTextIntoWords
    {
        /*
         Split Text into Words and Display Word Lengths
           ● Hint =>
               o Write a method to split text into words without using string.Split(). Use char
                 comparison for spaces.
               o Write another method to calculate string length without string.Length.
               o Return a 2D array where each row contains the word and its length.
        */
        public void SplitAndDisplayWordLengths(string input)
        {
            int wordCount = 0;
            foreach(char ch in input)
            {
                if(ch == ' ')
                {
                    wordCount++;
                }
            }
            wordCount++; // For the last word
            string[,] words = new string[wordCount, 2];
            int index = 0;
            StringBuilder currentWord = new StringBuilder();
            foreach (char ch in input)
            {
                if (ch != ' ')
                {
                    currentWord.Append(ch);
                }
                else
                {
                    words[index, 0] = currentWord.ToString();
                    words[index, 1] = CalculateStringLength(currentWord.ToString()).ToString();
                    index++;
                    currentWord.Clear(); // Reset for the next word
                }
            }
            // Add the last word
            if (currentWord.Length > 0)
            {
                words[index, 0] = currentWord.ToString();
                words[index, 1] = CalculateStringLength(currentWord.ToString()).ToString();
            }
            // Display the words and their lengths
            for(int i=0; i< wordCount; i++)
            {
                Console.WriteLine($"Word: {words[i, 0]}, Length: {words[i, 1]}");
            }


        }
        public int CalculateStringLength(string str)
        {
            int length = 0;
            foreach (char c in str)
            {
                length++;
            }
            return length;
        }
    }
}
