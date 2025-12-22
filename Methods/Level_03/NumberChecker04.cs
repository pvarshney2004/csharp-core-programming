using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Methods.Level_03
{
    internal class NumberChecker04
    {
        /*
         
Extend or Create a NumberChecker utility class and perform the following task. Call
from the main() method the different methods and display results. Make sure all are static 
methods
Hint =>
a. Method to find factors of a number and return them as an array. Note there are 2 for
loops one for the count and another for finding the factor and storing in the array 
b. Method to find the greatest factor of a Number using the factors array
c. Method to find the sum of the factors using factors array and return the sum
d. Method to find the product of the factors using factors array and return the product
e. Method to find product of cube of the factors using the factors array. Use Math.Pow()
f. Method to Check if a number is a perfect number. Perfect numbers are positive
integers that are equal to the sum of their proper divisors
g. Method to find the number is an abundant number. A number is called an abundant
number if the sum of its proper divisors is greater than the number itself
h. Method to find the number is a deficient number. A number is called a deficient
number if the sum of its proper divisors is less than the number itself
i. Method to Check if a number is a strong number. A number is called a strong number
if the sum of the factorial of its digits is equal to the number itself
         */

        //find factors
        public static int[] GetFactors(int num)
        {
            int count = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                    count++;
            }
            int[] factors = new int[count];
            int idx = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                    factors[idx++] = i;
            }
            return factors;
        }

        // to find Greatest factor
        public static int GetGreatestFactor(int[] factors)
        {
            return factors[factors.Length - 1];
        }

        // to get sum of factors
        public static int GetSumOfFactors(int[] factors)
        {
            int sum = 0;
            foreach (int f in factors)
                sum += f;
            return sum;
        }

        // to get product of factors
        public static long GetProductOfFactors(int[] factors)
        {
            long product = 1;
            foreach (int f in factors)
                product *= f;
            return product;
        }

        // to get product of cube of factors
        public static double GetProductOfCubeOfFactors(int[] factors)
        {
            double product = 1;
            foreach (int f in factors)
                product *= Math.Pow(f, 3);
            return product;
        }

        // perfect number check
        public static bool IsPerfectNumber(int num)
        {
            int sum = 0;
            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                    sum += i;
            }
            return sum == num;
        }

        // abundant number check
        public static bool IsAbundantNumber(int num)
        {
            int sum = 0;
            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                    sum += i;
            }
            return sum > num;
        }

        // deficient number check
        public static bool IsDeficientNumber(int num)
        {
            int sum = 0;
            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                    sum += i;
            }
            return sum < num;
        }

        // strong number check
        public static bool IsStrongNumber(int num)
        {
            int temp = num;
            int sum = 0;

            while (temp > 0)
            {
                int digit = temp % 10;
                sum += Factorial(digit);
                temp /= 10;
            }
            return sum == num;
        }

        private static int Factorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
                fact *= i;

            return fact;
        }
    }
}
