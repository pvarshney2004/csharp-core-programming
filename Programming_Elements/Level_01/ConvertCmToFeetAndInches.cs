using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Programming_Elements.Level_01
{
    internal class ConvertCmToFeetAndInches
    {
        public void ConvertCm(double cm)
        {
            double totalInches = cm / 2.54;
            int feet = (int)(totalInches / 12);
            double inches = totalInches % 12;
            Console.WriteLine($"{cm} cm is equal to {feet} feet and {inches:F2} inches.");
        }
    }
}
