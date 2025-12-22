using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Methods.Level_01
{
    internal class SimpleInterest
    {
        /*
        Write a program to input the Principal, Rate, and Time values and calculate Simple Interest.
        */
        public void CalculateSimpleInterest(double principal, double rate, double time)
        {
            double simpleInterest = (principal * rate * time) / 100;
            Console.WriteLine($"The Simple Interest is: {simpleInterest}");
        }
    }
}
