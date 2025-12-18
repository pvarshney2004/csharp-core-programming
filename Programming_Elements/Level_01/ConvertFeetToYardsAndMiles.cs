using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Programming_Elements.Level_01
{
    internal class ConvertFeetToYardsAndMiles
    {
        public void convert(double distanceInFeet)
        {
            double yards = distanceInFeet / 3.0;
            double miles = distanceInFeet / 5280.0;
            Console.WriteLine($"{distanceInFeet} feet is equal to {yards} yards and {miles} miles.");
        }
    }
}
