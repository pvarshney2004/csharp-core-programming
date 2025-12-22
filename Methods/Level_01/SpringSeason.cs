using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Methods.Level_01
{
    internal class SpringSeason
    {
        /*
        Write a program SpringSeason that takes two int values month and day from the
        command line and prints “Its a Spring Season” otherwise prints “Not a Spring Season” 
        */
        public bool IsSpringSeason(int month, int day)
        {
            if ((month == 3 && day >= 20 && day <= 31) || (month == 4 && day >= 1 && day <= 30) || (month == 5 && day >= 1 && day <= 31) || (month == 6 && day >= 1 && day <= 20))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
