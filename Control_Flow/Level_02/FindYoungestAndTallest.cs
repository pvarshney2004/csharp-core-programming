using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Control_Flow.Level_02
{
    internal class FindYoungestAndTallest
    {
        public void FindYoungest(int age1, int age2, int age3)
        {
            int youngestAge = age1;
            if (age2 < youngestAge)
            {
                youngestAge = age2;
            }
            if (age3 < youngestAge)
            {
                youngestAge = age3;
            }
            Console.WriteLine($"The youngest age is: {youngestAge}");
        }

        public void FindTallest(double height1, double height2, double height3)
        {
            double tallestHeight = height1;
            if (height2 > tallestHeight)
            {
                tallestHeight = height2;
            }
            if (height3 > tallestHeight)
            {
                tallestHeight = height3;
            }
            Console.WriteLine($"The tallest height is: {tallestHeight} meters");
        }
    }
}
