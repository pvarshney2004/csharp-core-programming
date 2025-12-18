using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Programming_Elements.Level_01
{
    internal class EarthVolume
    {
        public void FindVolume(double radius)
        {
            double volumeInCubicKm = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
            double volumeInCubicMiles = volumeInCubicKm * 0.239913;
            Console.WriteLine("The volume of earth in cubic kilometers is: " + volumeInCubicKm + " and cubic miles is: " + volumeInCubicMiles);
        }
    }
}
