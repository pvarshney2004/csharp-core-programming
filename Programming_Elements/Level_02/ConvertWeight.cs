using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Programming_Elements.Level_02
{
    internal class ConvertWeight
    {
        public void ConvertPoundsToKg(double pounds)
        {
            double kg = pounds * 0.45359237;
            Console.WriteLine($"{pounds} pounds is equal to {kg:F4} kilograms.");
        }
    }
}
