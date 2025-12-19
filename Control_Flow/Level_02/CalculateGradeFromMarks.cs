using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Control_Flow.Level_02
{
    internal class CalculateGradeFromMarks
    {
        public void FindGrade(int physics, int chemistry, int maths)
        {
            int sum = physics + chemistry + maths;
            double percentage = (sum / 300.0) * 100;
            char grade;
            string remarks;
            if (percentage >= 80)
            {
                grade = 'A';
                remarks = "Level 4, above agency-normalized standards";
            }
            else if(percentage>=70 && percentage<80)
            {
                grade = 'B';
                remarks = "Level 3, agency-normalized standards";
            }
            else if(percentage>=60 && percentage<70)
            {
                grade = 'C';
                remarks = "Level 2, below, but approaching agency-normalized standards";
            }
            else if(percentage>=50 && percentage<60)
            {
                grade = 'D';
                remarks = "Level 1, well below agency-normalized standards";
            }
            else if (percentage >= 40 && percentage < 50)
            {
                grade = 'E';
                remarks = "Level 1, too below agency-normalized standards";
            }
            else
            {
                grade = 'R';
                remarks = "Remedial standards";
            }
            Console.WriteLine($"Average marks: {(sum / 3.0):F2}");
            Console.WriteLine("Grade: " + grade);
            Console.WriteLine("Remarks: " + remarks);

        }
    }
}
