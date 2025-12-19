using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Arrays.Level_01
{
    internal class EvenOdd
    {
        public void Separate(int number)
        {
            if(number <= 0)
            {
                Console.Error.WriteLine("Please enter a positive integer.");
                return;
            }
            int[] odd = new int[number / 2 + 1];
            int[] even = new int[number / 2 + 1];
            int oddIndex = 0;
            int evenIndex = 0;
            for(int i = 1; i <= number; i++)
            {
                if(i % 2 == 0)
                {
                    even[evenIndex++] = i;
                }
                else
                {
                    odd[oddIndex++] = i;
                }
            }
            Console.WriteLine("Even Numbers:");
            for(int i = 0; i < evenIndex; i++)
            {
                Console.Write(even[i] + " ");
            }
            Console.WriteLine("\nOdd Numbers:");
            for (int i = 0; i < oddIndex; i++)
            {
                Console.Write(odd[i] + " ");
            }

        }
    }
}
