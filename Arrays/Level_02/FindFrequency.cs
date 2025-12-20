using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Arrays.Level_02
{
    internal class FindFrequency
    {
        public void Solve(int num)
        {
            int countOfDigits = Count(num);
            int[] digits = new int[countOfDigits];
            for (int i = 0; i < countOfDigits; i++)
            {
                digits[i] = num % 10;
                num = num / 10;
            }
            int[] frequency = new int[10];
            for (int i = 0; i < digits.Length; i++)
            {
                frequency[digits[i]]++;
            }
            // by this method, we can join array into a string
            //Console.WriteLine(string.Join(", ", digits));
            for (int i = 0; i < frequency.Length; i++)
            {
                if (frequency[i] > 0)
                {
                    Console.WriteLine(i + " -> " + frequency[i]);
                }
            }

        }
        public int Count(int num)
        {
            int count = 0;
            while (num > 0)
            {
                count++;
                num = num / 10;
            }
            return count;
        }
    }
}
