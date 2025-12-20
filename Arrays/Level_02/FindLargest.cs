using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Arrays.Level_02
{
    internal class FindLargest
    {
        public void FindLargestAndSecondLargest(int number)
        {
            int count = Count(number);
            int[] digits = new int[count];
            for (int i = count - 1; i >= 0; i--)
            {
                digits[i] = number % 10;
                number = number / 10;
            }
            int largest = int.MinValue;
            int secondLargest = int.MinValue;
            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] > largest)
                {
                    secondLargest = largest;
                    largest = digits[i];
                }
                else if (digits[i] > secondLargest && digits[i] != largest)
                {
                    secondLargest = digits[i];
                }
            }
            Console.WriteLine("Largest Digit: " + largest);
            Console.WriteLine("Second Largest Digit: " + secondLargest);
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
