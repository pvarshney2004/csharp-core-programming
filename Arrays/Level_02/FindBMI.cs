using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Arrays.Level_02
{
    internal class FindBMI
    {
        public void CalculateBMI(double[] weights, double[] heights)
        {
            int numberOfPersons = weights.Length;
            double[] bmiValues = new double[numberOfPersons];
            string[] weightStatus = new string[numberOfPersons];
            for (int i=0; i<numberOfPersons; i++)
            {
                double bmi = weights[i] / (heights[i] * heights[i]);
                bmiValues[i] = bmi;
                if(bmi < 18.5)  
                {
                    weightStatus[i] = "Underweight";
                }
                else if(bmi >= 18.5 && bmi < 24.9)
                {
                    weightStatus[i] = "Normal weight";
                }
                else if(bmi >= 25 && bmi < 29.9)
                {
                    weightStatus[i] = "Overweight";
                }
                else
                {
                    weightStatus[i] = "Obesity";
                }
                Console.WriteLine($"Person {i + 1}: Weight = {weights[i]}kg, Height = {heights[i]}m, BMI = {bmiValues[i]:F2}, Status = {weightStatus[i]}");
            }
        }
    }
}
