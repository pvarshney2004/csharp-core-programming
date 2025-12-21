using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.String.Level_01
{

    /*
     Compare Two Strings Using charAt()
     Hint =>
        o Take user input using Console.ReadLine().
        o Create a method to compare two strings using CharAt() logic (string[index] in C#).
        o Compare the result with the built-in string.Equals().
    */
    internal class CompareStrings
    {
        public void Compare(string a, string b)
        {
            bool ans = true;
            int minLen = Math.Min(a.Length, b.Length);
            int i = 0;
            while (i < minLen)
            {
                if (a[i] != b[i])
                {
                    ans = false;
                }
                i++;
            }
            if (ans) {
                Console.WriteLine("Both strings are equals");
            }
            else
            {
                Console.WriteLine("Both strings are not equal");
            }
            bool res = a.Equals(b);
            if(ans == res)
            {
                Console.Write("Result is same by both methods: manual check and in-built method");
            }
            else
            {
                Console.WriteLine("Result is not same by both methods: manual check and in-built method");
            }
           
        }
    }
}
