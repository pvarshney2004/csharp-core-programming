using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Programming_Elements.Level_01
{
    internal class PenDistribution
    {
        public void DistributePens(int totalPens, int numberOfStudents)
        {
            int pensPerStudent = totalPens / numberOfStudents;
            int remainingPens = totalPens % numberOfStudents;
            Console.WriteLine("Each student will get " + pensPerStudent + " pens.");
            Console.WriteLine("Number of pens remaining: " + remainingPens);
        }
    }
}
