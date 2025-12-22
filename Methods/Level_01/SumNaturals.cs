using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Methods.Level_01
{
    internal class SumNaturals
    {
        /*
        Write a program to find the sum of n natural numbers using loop
        */
        public void CalculateSumOfNaturals(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine($"The sum of first {n} natural numbers is: {sum}");
        }
    }
}
