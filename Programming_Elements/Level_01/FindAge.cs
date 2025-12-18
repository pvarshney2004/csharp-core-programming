using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Programming_Elements.Level_01
{
    internal class FindAge
    {
        public void CalculateAge(int birthYear)
        {
            int currentYear = 2024;
            int age = currentYear - birthYear;
            Console.WriteLine("Harry's age in 2024 is: " + age);
        }
    }
}
