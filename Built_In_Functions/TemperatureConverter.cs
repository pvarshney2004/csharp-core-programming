using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Built_In_Functions
{
    internal class TemperatureConverter
    {
        /*
Temperature Converter:
Write a program that converts temperatures between Fahrenheit and Celsius.
● The program should have separate functions for converting from Fahrenheit to
Celsius and from Celsius to Fahrenheit.
         */
        public double CelToFarh(double cel)
        {
            return (cel * 9 / 5) + 32;
        }
        public double FarhToCel(double farh)
        {
            return (farh - 32) * 5 / 9;
        }
    }
}
