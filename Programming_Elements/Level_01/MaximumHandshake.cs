using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Programming_Elements.Level_01
{
    internal class MaximumHandshake
    {
        public void calculateMaxHandshakes(int numberOfStudents)
        {
            int maxHandshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;
            Console.WriteLine("Maximum number of handshakes among " + numberOfStudents + " people is: " + maxHandshakes);
        }
    }
}
