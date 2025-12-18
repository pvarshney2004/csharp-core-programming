using Core_Programming.Control_Flow.Level_02;
using System;
namespace Core_Programming.Programming_Elements.Level_02 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LeapYearOrNot obj1 = new LeapYearOrNot();
            Console.WriteLine("Enter a year to check if it's a leap year or not:");
            int year = Convert.ToInt32(Console.ReadLine());
            obj1.IsLeapYear(year);
        }
    }
}