using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Arrays.Level_01
{
    internal class FindFactors
    {
        public void Find(int number)
        {
            int[] factors = new int[10];
            int index = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    if (index < factors.Length)
                    {
                        factors[index] = i;
                        index++;
                    }
                    else
                    {
                        Console.WriteLine("Factor array is full. Cannot store more factors.");
                        break;
                    }
                }
            }
            Console.WriteLine($"Factors of {number} are:");
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(factors[i]);
            }
        }
    }
}
