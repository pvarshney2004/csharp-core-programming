using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Arrays.Level_02
{
    internal class FindPercentAndGrade
    {
        public void CalculatePercentAndGrade(int[] physics, int[] chemistry, int[] maths)
        {
            double[] percentages = new double[physics.Length];
            char[] grades = new char[physics.Length];
            for (int i = 0; i < physics.Length; i++)
            {
                double totalMarks = physics[i] + chemistry[i] + maths[i];
                double percent = (totalMarks / 300) * 100;
                percentages[i] = percent;
                if (percent >= 80)
                {
                    grades[i] = 'A';
                }
                else if (percent >= 70)
                {
                    grades[i] = 'B';
                }
                else if (percent >= 60)
                {
                    grades[i] = 'C';
                }
                else if (percent >= 50)
                {
                    grades[i] = 'D';
                }
                else if (percent >= 40)
                {
                    grades[i] = 'E';
                }
                else
                {
                    grades[i] = 'R';
                }
                Console.WriteLine($"Student {i + 1}: Total Marks(out of 300) = {totalMarks}, Percentage = {percentages[i]:F2}%, Grade = {grades[i]}");

            }
        }
    }
}
