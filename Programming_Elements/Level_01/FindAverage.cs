using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Programming_Elements.Level_01
{
    internal class FindAverage
    {
        public void CalculateAverage(int marks1, int marks2, int marks3)
        {
            double average = (marks1 + marks2 + marks3) / 3.0;
            Console.WriteLine("Sam’s average mark in PCM is " + average);
        }
    }
}
