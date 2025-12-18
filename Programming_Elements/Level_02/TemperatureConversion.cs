using System;

namespace Core_Programming.Programming_Elements.Level_02
{
    internal class TemperatureConversion
    {
        public void convertCelsiusToFahrenheit(double celsius)
        {
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"{celsius}°C is equal to {fahrenheit}°F");
        }
    }
}
