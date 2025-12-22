using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Methods.Level_01
{
    internal class MaximumHandshakes
    {
        /*
        Create a program to find the maximum number of handshakes among N number of students.
        */
        public void CalculateMaximumHandshakes(int numberOfStudents)
        {
            int maxHandshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;
            Console.WriteLine($"The maximum number of handshakes among {numberOfStudents} students is: {maxHandshakes}");
        }
    }
}
