using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Programming_Elements.Level_02
{
    internal class TotalIncome
    {
        public void CalculateTotalIncome(int income, int bonus)
        {
            Console.WriteLine("Total Income: " + (income + bonus) + " INR");
        }
    }
}
