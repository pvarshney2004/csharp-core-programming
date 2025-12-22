using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Methods.Level_01
{
    internal class CalculateTrignometricFunc
    {
        /*
         * Write a program to calculate various trigonometric functions using Math class given an angle in degrees
        */
        public double[] CalculateTrigonometricFunctions(double angleInDegrees)
        {
            double angleInRadians = angleInDegrees * (Math.PI / 180); // Convert degrees to radians
            double sine = Math.Sin(angleInRadians);
            double cosine = Math.Cos(angleInRadians);
            double tangent = Math.Tan(angleInRadians);
            return new double[] { sine, cosine, tangent};
       
        }
    }
}
