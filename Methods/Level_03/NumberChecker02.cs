using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Methods.Level_03
{
    internal class NumberChecker02 : NumberChecker
    {
        /*
         Extend or Create a NumberChecker utility class and perform the following task. Call
from the main() method the different methods and display results. Make sure all are static
methods
Hint =>
a. Method to find the count of digits in the number and a Method to Store the digits of
the number in a digits array
b. Method to find the sum of the digits of a number using the digits array
c. Method to find the sum of the squares of the digits of a number using the digits array.
Use Math.Pow() method
d. Method to Check if a number is a Harshad number using a digits array. A number is
called a Harshad number if it is divisible by the sum of its digits. For e.g. 21
e. Method to find the frequency of each digit in the number. Create a 2D array to store
the frequency with digit in the first column and frequency in the second column.
         */
        public static double SumOfSquareOfFactors(int[] digits)
        {
            double sumOfSquares = 0;
            foreach (int i in digits)
            {
                sumOfSquares += Math.Pow(i, 2);
            }
            return sumOfSquares;
        }
        public static void CheckHarshad(int number, int[] numbers)
        {
            
            int sum = 0;
            foreach (int i in numbers)
            {
                sum += i;
            }
            if (number % sum == 0)
            {
                Console.WriteLine(number + " is a Harshad number.");
            }
            else
            {
                Console.WriteLine(number + " is not a Harshad number.");
            }
        }
        //find frequency of each digit in array
        public static void FindFrequency(int[] digits)
        {
            int[,] result = new int[digits.Length, 2];
            int idx = 0;
            int[] frequency = new int[10];
            for (int i = 0; i < digits.Length; i++)
            {
                frequency[digits[i]]++;
            }
            for (int i = 0; i < frequency.Length; i++)
            {
                if (frequency[i] > 0)
                {
                    result[idx, 0] = i;
                    result[idx,1] = frequency[i];
                    idx++;
                }
            }
            for(int i=0; i<result.GetLength(0); i++)
            {
                Console.WriteLine(result[i,0]+" " + result[i,1]);
            }
        }

    }
}
