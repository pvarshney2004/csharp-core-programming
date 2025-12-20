using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Arrays.Level_02
{
    internal class FindBonus
    {
        public void Solve(double[] salary, double[] yearOfService)
        {
            double[] newSalary = new double[10];
            double[] bonusAmount = new double[10];
            for(int i=0; i<10; i++)
            {
                if (yearOfService[i] > 5)
                {
                    bonusAmount[i] = salary[i] * 0.05;
                }
                else if(yearOfService[i] <= 5)
                {
                    bonusAmount[i] = salary[i] * 0.02;
                }
                newSalary[i] = salary[i] + bonusAmount[i];
                Console.WriteLine("Employee {0}: Old Salary = {1}, New Salary = {2}, Bonus Amount = {3}", i + 1, salary[i], newSalary[i], bonusAmount[i]);
            }
        }
    }
}
