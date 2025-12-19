using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Arrays.Level_01
{
    internal class FizzBuzz
    {
        public void PrintFizzBuzz(int n)
        {
            String[] results = new String[n];
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    results[i - 1] = "FizzBuzz";
                }
                else if (i % 3 == 0)
                {
                    results[i - 1] = "Fizz";
                }
                else if (i % 5 == 0)
                {
                    results[i - 1] = "Buzz";
                }
                else
                {
                    results[i - 1] = i.ToString();
                }
            }
            for(int i = 0; i < results.Length; i++)
            {
                Console.WriteLine($"Position {i+1}: {results[i]}");
            }
        }
    }
}
