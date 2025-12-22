using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Methods.Level_01
{
    internal class CalculateWindChillTemp
    {
        /*
        .Write a program calculate the wind chill temperature given the temperature and wind speed
        */
        public double ComputeWindChill(double temperature, double windSpeed)
        {
            // Wind Chill Temperature formula
            double windChill = 35.74 + 0.6215 * temperature - 35.75 * Math.Pow(windSpeed, 0.16) + 0.4275 * temperature * Math.Pow(windSpeed, 0.16);
            return windChill;
        }
    }
}
