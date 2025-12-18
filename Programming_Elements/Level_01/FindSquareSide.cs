using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Programming_Elements.Level_01
{
    internal class FindSquareSide
    {
        public void calculateSide(double perimeter)
        {
            double side = perimeter / 4;
            Console.WriteLine("The length of one side of the square is: " + side);

        }
    }
}
