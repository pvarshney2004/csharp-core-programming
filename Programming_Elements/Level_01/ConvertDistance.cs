using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Programming_Elements.Level_01
{
    internal class ConvertDistance
    {
        public void ConvertKmToMiles(double kilometers)
        {
            double miles = kilometers * 0.621;
            Console.WriteLine(kilometers + " kilometers is equal to " + miles + " miles.");
        }
    }
}
