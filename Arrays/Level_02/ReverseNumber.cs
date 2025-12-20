using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Arrays.Level_02
{
    internal class ReverseNumber
    {
        public void Solve(int num)
        {
            int count = Count(num);
            int[] digits = new int[count];
            for (int i = 0; i < count; i++)
            {
                digits[i] = num % 10;
                num = num / 10;
            }
            Console.WriteLine("Reversed Number: " + string.Join("", digits));
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
