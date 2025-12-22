using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Methods.Level_03
{
    internal class NumberChecker
    {
        /*
Extend or Create a NumberChecker utility class and perform the following task. Call
from the main() method the different methods and display results. Make sure all are static
methods
Hint =>
a. Method to Find the count of digits in the number
b. Method to Store the digits of the number in a digits array
c. Method to Check if a number is a duck number using the digits array. A duck number
is a number that has a non-zero digit present in it
d. Method to check if the number is an armstrong number using the digits array.
Armstrong number is a number that is equal to the sum of its own digits raised to the power
of the number of digits. Eg: 153 = 1^3 + 5^3 + 3^3
e. Method to find the largest and second largest elements in the digits array. Use
Int32.MinValue to initialize the variable.
         */
        public static int CountDigits(int num)
        {
            int c = 0;
            while(num>0)
            {
                c++;
                num /= 10;
            }
            return c;
        }
        public static int[] StoreDigits(int num)
        {
            int c = CountDigits(num);
            int[] digits = new int[c];
            for(int i=c-1; i>=0; i--)
            {
                digits[i] = num%10;
                num /= 10;
            }
            return digits;
        }

        public static bool CheckDuck(int[] digits)
        {
            bool isDuck = false;
            foreach (int digit in digits)
            {
                if (digit != 0)
                {
                    isDuck = true; break;
                }
            }
            return isDuck;
        }
        public static void LargestAndSecondLargest(int[] digits)
        {
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

        public static void CheckArmstrong(int[] digits)
        {
            int sum = 0;
            int originalNumber = Convert.ToInt32(string.Join("", digits));
            for(int i=0; i<digits.Length; i++)
            {
                sum += Convert.ToInt32(Math.Pow(digits[i], digits.Length));
            }
            
            if (sum == originalNumber)
            {
                Console.WriteLine($"{originalNumber} is an Armstrong number.");
            }
            else
            {
                Console.WriteLine($"{originalNumber} is not an Armstrong number.");
            }
        }



    }
}
