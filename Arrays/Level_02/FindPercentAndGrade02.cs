using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Arrays.Level_02
{
    internal class FindPercentAndGrade02
    {
        public void FindUsing2DArray(int[,] marks)
        {
            int studentCount = marks.GetLength(0);
            int subjectCount = marks.GetLength(1);
            double[] percentage = new double[studentCount];
            char[] grades = new char[studentCount];
            for (int i = 0; i < studentCount; i++)
            {
                int totalMarks = 0;
                // calculating total marks for each student
                for (int j = 0; j < marks.GetLength(1); j++)
                {
                    totalMarks += marks[i, j];
                }
                percentage[i] = (totalMarks / (subjectCount * 100.0)) * 100;
                if (percentage[i] >= 80)
                {
                    grades[i] = 'A';
                }
                else if (percentage[i] >= 70)
                {
                    grades[i] = 'B';
                }
                else if (percentage[i] >= 60)
                {
                    grades[i] = 'C';
                }
                else if (percentage[i] >= 50)
                {
                    grades[i] = 'D';
                }
                else if (percentage[i] >= 40)
                {
                    grades[i] = 'E';
                }
                else
                {
                    grades[i] = 'R';
                }
            }
            // Displaying results
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"Student {i + 1}: Percentage = {percentage[i]:F2}%, Grade = {grades[i]}");
            }
        }
    }
}
