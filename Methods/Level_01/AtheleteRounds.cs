using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Methods.Level_01
{
    internal class AtheleteRounds
    {
        /*
        An athlete runs in a triangular park with sides provided as input by the user in meters. If
        the athlete wants to complete a 5 km run, then how many rounds must the athlete
        complete.
        */
        public void CalculateAthleteRounds(double sideA, double sideB, double sideC)
        {
            double perimeter = sideA + sideB + sideC; // in meters
            double totalDistance = 5000; // 5 km in meters
            double rounds = totalDistance / perimeter;
            Console.WriteLine($"The athlete must complete {Math.Ceiling(rounds)} rounds to complete a 5 km run.");
        }
    }
}
