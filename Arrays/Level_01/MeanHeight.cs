using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Arrays.Level_01
{
    internal class MeanHeight
    {
        public void Calculate(double[] height)
        {
            double sum = 0;
            for (int i = 0; i < height.Length; i++)
            {
                sum += height[i];
            }
            double mean = sum / height.Length;
            Console.WriteLine("Mean Height: " + mean);
        }
    }
}
