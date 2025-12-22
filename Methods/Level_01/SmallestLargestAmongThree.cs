using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Methods.Level_01
{
    internal class SmallestLargestAmongThree
    {
        /*
         * Write a program to find the smallest and the largest of the 3 numbers.
        */
        public int[] FindSmallestAndLargest(int num1, int num2, int num3)
        {
            int[] ans  = new int[2];
            int smallest = Math.Min(num1, Math.Min(num2, num3));
            int largest = Math.Max(num1, Math.Max(num2, num3));
            ans[0] = smallest;
            ans[1] = largest;
            return ans;
        }
    }
}
