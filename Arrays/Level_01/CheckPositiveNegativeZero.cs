using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Arrays.Level_01
{
    internal class CheckPositiveNegativeZero
    {
        public void Check(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    Console.WriteLine(nums[i] + " is Positive");
                }
                else if (nums[i] < 0)
                {
                    Console.WriteLine(nums[i] + " is Negative");
                }
                else
                {
                    Console.WriteLine(nums[i] + " is Zero");
                }
            }
            if (nums[0] == nums[nums.Length - 1])
            {
                Console.WriteLine("First and Last elements are equal: " + nums[0]);
            }
            else
            {
                Console.WriteLine("First and Last elements are not equal: " + nums[0] + " and " + nums[nums.Length - 1]);
            }
        }
    }
}
