using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Core_Programming.String.Level_02
{
    internal class CheckAnagram
    {
        // Write a C# program that accepts two strings from the user and checks if the two strings are anagrams of each other(i.e., whether they contain the same characters in anyorder).
        public void Anagram(string str1, string str2)
        {
            if(str1.Length != str2.Length)
            {
                Console.WriteLine("The strings are not anagrams.");
                return;
            }
            int[] arr1 = new int[26];
            int[] arr2 = new int[26];
            for(int i = 0; i < str1.Length; i++)
            {
                arr1[str1[i] - 'a']++;
                arr2[str2[i] - 'a']++;
            }
            for(int i = 0; i < 26; i++)
            {
                if(arr1[i] != arr2[i])
                {
                    Console.WriteLine("The strings are not anagrams.");
                    return;
                }
            }
            Console.WriteLine("The strings are anagrams.");
        }

    }
}
