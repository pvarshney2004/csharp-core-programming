using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Methods.Level_03
{
    internal class ShortestTallestMean
    {
        /*
Create a program to find the shortest, tallest, and mean height of players present in a
football team.
Hint =>
a. The formula to calculate the mean is: mean = sum of all elements/number of
elements
b. Create an int array named heights of size 11 and get 3 digits random height in cms for
each player in the range 150 cms to 250 cms
c. Write the method to Find the sum of all the elements present in the array.
d. Write the method to find the mean height of the players on the football team
e. Write the method to find the shortest height of the players on the football team
f. Write the method to find the tallest height of the players on the football team
g. Finally display the results
         */
        public int Sum(int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
            {
                sum += i;
            }
            return sum;
        }
        public double MeanHeight(int[] arr)
        {
            int sum = Sum(arr);
            return sum/ arr.Length;
        }
        public int Shortest(int[] arr)
        {
            int ans = arr[0];
            foreach (int i in arr)
            {
                if (i < ans)
                {
                    ans = i;
                }
            }
            return ans;
        }
        public int Tallest(int[] arr)
        {
            int ans = arr[0];
            foreach (int i in arr)
            {
                if (i > ans)
                {
                    ans = i;
                }
            }
            return ans;
        }

    }
}
