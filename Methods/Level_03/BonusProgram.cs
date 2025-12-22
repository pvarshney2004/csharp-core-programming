using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Methods.Level_03
{
    internal class BonusProgram
    {
        /*
         Create a program to find the bonus of 10 employees based on their years of service
as well as the total bonus amount the 10-year-old company Zara has to pay as a bonus,
along with the old and new salary.
Hint =>
a. Zara decides to give a bonus of 5% to employees whose year of service is more than 5
years or 2% if less than 5 years
b. Create a Method to determine the Salary and years of service and return the same.
Use the Math.Random() method to determine the 5-digit salary for each employee and also
use the random method to determine the years of service. Define 2D Array to save the
salary and years of service.
c. Write a Method to calculate the new salary and bonus based on the logic defined
above and return the new 2D Array of the latest salary and bonus amount
d. Write a Method to Calculate the sum of the Old Salary, the Sum of the New Salary,
and the Total Bonus Amount and display it in a Tabular Format

         */
        public int[,] GenerateEmployeeData(int count)
        {
            Random random = new Random();
            int[,] data = new int[count, 2];

            for (int i = 0; i < count; i++)
            {
                data[i, 0] = random.Next(10000, 99999); 
                data[i, 1] = random.Next(1, 11);        
            }
            return data;
        }

        public double[,] CalculateBonus(int[,] employeeData)
        {
            int count = employeeData.GetLength(0);
            // array will represent data as [bonusAmount, newSalary]
            double[,] result = new double[count, 2]; 

            for (int i = 0; i < count; i++)
            {
                int salary = employeeData[i, 0];
                int years = employeeData[i, 1];

                double bonusPercent = (years > 5) ? 0.05 : 0.02;
                double bonus = salary * bonusPercent;
                double newSalary = salary + bonus;

                result[i, 0] = bonus;
                result[i, 1] = newSalary;
            }
            return result;
        }

        public void Display(int[,] oldData, double[,] newData)
        {
            double totalOldSalary = 0;
            double totalNewSalary = 0;
            double totalBonus = 0;

            for(int i=0; i<oldData.GetLength(0); i++)
            {
                totalOldSalary += oldData[i, 0];
                totalNewSalary += newData[i, 1];
                totalBonus += newData[i, 0];
            }
            Console.WriteLine("Total Old Salary \tTotal New Salary \t Total Bonus");
            Console.WriteLine($"{totalOldSalary} \t\t\t{totalNewSalary:F2} \t\t {totalBonus}");
        }
    }
}
