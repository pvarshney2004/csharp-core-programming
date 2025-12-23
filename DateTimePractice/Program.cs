using System;
namespace Core_Programming.DateTimePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateArithmetic obj1 = new DateArithmetic();
            //string? date = Console.ReadLine();
            //obj1.Solve(date);

            //DateFormatting obj2 = new DateFormatting();
            //obj2.Format();

            //DateComparison obj3 = new DateComparison();
            //string? date1 = Console.ReadLine();
            //DateTime d1 = DateTime.Parse(date1);
            //string? date2 = Console.ReadLine();
            //DateTime d2 = DateTime.Parse(date2);
            //obj3.CompareDates(d1, d2);

            DateTimeOffsetAndTimeZone obj4 = new DateTimeOffsetAndTimeZone();
            obj4.TimeZoneAndOffset();
        }
    }
}