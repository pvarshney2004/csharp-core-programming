using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Programming_Elements.Level_01
{
    internal class BasicCalculator
    {
        public void PerformCalculation(double num1, double num2)
        {
            double addition = num1 + num2;
            double subtract = num1 - num2;
            double multiplication = num1 * num2;
            double division = num1 / num2;
            Console.WriteLine($"The addition, subtraction, multiplication and division value of 2 numbers {num1} and {num2} is {addition}, {subtract}, {multiplication}, and {division}.");
        }
    }
}
