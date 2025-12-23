using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.DateTimePractice
{
    internal class DateTimeOffsetAndTimeZone
    {
        /*
Problem 1: Time Zones and DateTimeOffset
Write a program that displays the current time in different time zones:
● GMT (Greenwich Mean Time)
● IST (Indian Standard Time)
● PST (Pacific Standard Time)
Hint: Use DateTimeOffset and TimeZoneInfo to work with different time zones.
         */
        //method for comparing two dates
        public void TimeZoneAndOffset()
        {
            // getting current UTC time
            DateTimeOffset utcTime = DateTimeOffset.UtcNow;

            // finding time zone info
            TimeZoneInfo istZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
            TimeZoneInfo pstZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");

            // Convert UTC to other time zones
            DateTimeOffset istTime = TimeZoneInfo.ConvertTime(utcTime, istZone);
            DateTimeOffset pstTime = TimeZoneInfo.ConvertTime(utcTime, pstZone);

            Console.WriteLine("Current Time in Different Time Zones:");
            Console.WriteLine($"GMT (UTC) : {utcTime}");
            Console.WriteLine($"IST : {istTime}");
            Console.WriteLine($"PST : {pstTime}");
        }
    }
}
