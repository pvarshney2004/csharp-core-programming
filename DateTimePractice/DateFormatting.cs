using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.DateTimePractice
{
    internal class DateFormatting
    {
        /*
        Problem 3: Date Formatting
        Write a program that:
        ● Displays the current date in three different formats:
        o dd/MM/yyyy
        o yyyy-MM-dd
        o EEE, MMM dd, yyyy
        Hint: Use DateTime.ToString() with custom date format strings.
                 */
        //method for formatting date
        public void Format()
        {
            // getting current date from system
            DateTime date = DateTime.Now;
            // printing date in diffrent formats
            Console.WriteLine(date.ToString("dd/MM/yyyy"));
            Console.WriteLine(date.ToString("yyyy-MM-dd"));
            Console.WriteLine(date.ToString("ddd, MMM dd, yyyy"));

        }
    }
}
