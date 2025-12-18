using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Programming_Elements.Level_02
{
    internal class CalculateRounds
    {
        public void calculate(int side1, int side2, int side3) { 
            int perimeterInMeter = side1 + side2 + side3;
            int distanceToRunInKM = 5;
            int perimeterInKM = perimeterInMeter / 1000;
            int rounds = distanceToRunInKM / perimeterInKM;
            Console.WriteLine("Number of rounds the athlete has to run: " + rounds);

        }
    }
}
