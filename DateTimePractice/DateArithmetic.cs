using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.DateTimePractice
{
    internal class DateArithmetic
    {
        /*
Problem 2: Date Arithmetic
Create a program that:
● Takes a date input and adds 7 days, 1 month, and 2 years to it.
● Then subtracts 3 weeks from the result.
Hint: Use DateTime.AddDays(), DateTime.AddMonths(), DateTime.AddYears(),
and DateTime.AddWeeks() methods.
         */
        //method for perform arithmetic operations on date
        public void Solve(string str)
        {
            DateTime date = DateTime.Parse(str);
            date = date.AddDays(7); // adding 7 days
            date = date.AddMonths(1); // adding 1 month
            date = date.AddYears(2); // adding two years
            date = date.AddDays(-21); // subtract 3 weeks (minus 21 days)
            Console.Write(date);
        }
    }
}
