using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Control_Flow.Level_01
{
    internal class FindBonus
    {
        public void CalculateBonus(int yearsOfService, double salary)
        {
            double bonus = 0;
            if (yearsOfService > 5)
            {
                bonus = salary * 0.05;
            }
            else
            {
                bonus = 0;
            }
            Console.WriteLine($"Employee with {yearsOfService} years of service and salary {salary} receives a bonus of {bonus}");
        }
    }
}
