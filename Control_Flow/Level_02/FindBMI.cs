using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Control_Flow.Level_02
{
    internal class FindBMI
    {
        public void CalculateBMI(double weightInKg, double heightInMeters)
        {
            if (heightInMeters <= 0)
            {
                Console.WriteLine("Height must be greater than zero.");
                return;
            }
            double bmi = weightInKg / (heightInMeters * heightInMeters);
            Console.WriteLine($"Your BMI is: {bmi:F2}");
            if (bmi < 18.5)
            {
                Console.WriteLine("You are underweight.");
            }
            else if (bmi >= 18.5 && bmi < 24.9)
            {
                Console.WriteLine("You have a normal weight.");
            }
            else if (bmi >= 25 && bmi < 29.9)
            {
                Console.WriteLine("You are overweight.");
            }
            else
            {
                Console.WriteLine("You are obese.");
            }
        }
    }
}
