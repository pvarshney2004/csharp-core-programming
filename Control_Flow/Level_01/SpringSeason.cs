using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Control_Flow.Level_01
{
    internal class SpringSeason
    {
        public void CheckSpringSeason(int day, int month)
        {
            if ((month == 3 && day >= 20 && day <= 31) || (month == 4 && day >= 1 && day <= 30) || (month == 5 && day >= 1 && day <= 31) || (month == 6 && day >= 1 && day <= 20))
            {
                Console.WriteLine($"Date: {day}/{month} falls in Spring Season.");
            }
            else
            {
                Console.WriteLine($"Date: {day}/{month} does not fall in Spring Season.");
            }
        }
    }
}
