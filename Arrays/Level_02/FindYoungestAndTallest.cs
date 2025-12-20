using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Arrays.Level_02
{
    internal class FindYoungestAndTallest
    {
        public void FindYoungest(int[] ages)
        {
            int youngest = ages[0];
            for (int i = 1; i < ages.Length; i++)
            {
                if (ages[i] < youngest)
                {
                    youngest = ages[i];
                }
            }
            Console.WriteLine("Youngest age is: " + youngest);
        }
        public void FindTallest(double[] heights)
        {
            double tallest = heights[0];
            for (int i = 1; i < heights.Length; i++)
            {
                if (heights[i] > tallest)
                {
                    tallest = heights[i];
                }
            }
            Console.WriteLine("Tallest height is: " + tallest);
        }
    }
}
