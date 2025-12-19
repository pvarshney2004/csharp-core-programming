using System;
namespace Core_Programming.Control_Flow.Level_03
{
    internal class  Program
    {
        static void Main(string[] args)
        {
            //IsArmstrong obj1 = new IsArmstrong();
            //Console.Write("Enter a number to check if it is an Armstrong number:");
            //int number = Convert.ToInt32(Console.ReadLine());
            //obj1.CheckArmstrong(number);

            //HarshadNumber obj2 = new HarshadNumber();
            //Console.Write("Enter a number to check if it is a Harshad number:");
            //int number = Convert.ToInt32(Console.ReadLine());
            //obj2.CheckHarshad(number);

            //CountDigits obj3 = new CountDigits();
            //Console.Write("Enter a number to count the number of digits:");
            //int number = Convert.ToInt32(Console.ReadLine());
            //obj3.CountNumberOfDigits(number);

            //AbundantNumber obj4 = new AbundantNumber();
            //Console.Write("Enter a number to check if it is an Abundant number:");
            //int number = Convert.ToInt32(Console.ReadLine());
            //obj4.CheckAbundant(number);

            //CalculatorUsingSwitch obj5 = new CalculatorUsingSwitch();
            //Console.Write("Enter first number:");
            //double num1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter second number:");
            //double num2 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter an operator (+, -, *, /):");
            //string? op = Console.ReadLine();
            //obj5.Calculate(num1, num2, op);

            DayOfWeek obj6 = new DayOfWeek();
            Console.Write("Enter day:");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter month:");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter year:");
            int year = Convert.ToInt32(Console.ReadLine());
            obj6.GetDayName(day, month, year);

        }
    }
}