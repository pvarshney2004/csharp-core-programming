using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.String.Level_01
{
    internal class ReturnCharacters
    {
        /*
        Return All Characters Without Using ToCharArray()
        ● Hint =>
            o Write a method to return characters of a string without using ToCharArray()
            (loop through string[index]).
            o Compare the result with the built-in ToCharArray() method.
        */
        public void ReturnChars(string str)
        {
            // Using loop to return characters (without ToCharArray)
            Console.WriteLine("Characters using loop:");
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i]+" ");
            }
            // Using ToCharArray() method
            Console.WriteLine("\nCharacters using ToCharArray():");
            char[] charArray = str.ToCharArray();
            foreach (char ch in charArray)
            {
                Console.Write(ch+" ");
            }
        }
    }
}
