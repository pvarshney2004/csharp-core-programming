using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.DateTimePractice
{
    internal class DateComparison
    {
    /*
Problem 4: Date Comparison
Write a program that:
● Takes two date inputs and compares them to check if the first date is
before, after, or the same as the second date.
Hint: Use DateTime.Compare(), DateTime.CompareTo(), or direct comparison
using DateTime methods.
      */
        //method for comparing two dates
        public void CompareDates(DateTime date1, DateTime date2)
        {
            int res = date1.CompareTo(date2);
            if(res==0)
            {
                Console.WriteLine("Both the dates are equal");
            }
            else if(res < 0)
            {
                Console.WriteLine($"Date1: {date1.ToString("dd-MM-yyyy")} is before Date2: {date2.ToString("dd-MM-yyyy")}");
            }
            else
            {
                Console.WriteLine($"Date1: {date1.ToString("dd-MM-yyyy")} is after Date2: {date2.ToString("dd-MM-yyyy")}");
            }
        }
    }
}
