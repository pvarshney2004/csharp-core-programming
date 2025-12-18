using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Programming_Elements.Level_02
{
    internal class CalculateSimpleInterest
    {
        public void ComputeSimpleInterest(double principal, double rate, double time)
        {
            double simpleInterest = (principal * rate * time) / 100;
            Console.WriteLine($"The Simple Interest is: {simpleInterest}");
        }
    }
}
