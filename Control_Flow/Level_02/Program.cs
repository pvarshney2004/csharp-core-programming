using Core_Programming.Control_Flow.Level_02;
using System;
namespace Core_Programming.Programming_Elements.Level_02 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LeapYearOrNot obj1 = new LeapYearOrNot();
            //Console.WriteLine("Enter a year to check if it's a leap year or not:");
            //int year = Convert.ToInt32(Console.ReadLine());
            //obj1.IsLeapYear(year);

            //CalculateGradeFromMarks obj2 = new CalculateGradeFromMarks();
            //Console.WriteLine("Enter marks in Physics:");
            //int physics = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter marks in Chemistry:");
            //int chemistry = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter marks in Mathematics:");
            //int maths = Convert.ToInt32(Console.ReadLine());
            //obj2.FindGrade(physics, chemistry, maths);

            //FindFactors obj3 = new FindFactors();
            //Console.WriteLine("Enter a number to find its factors:");
            //int number = Convert.ToInt32(Console.ReadLine());
            //obj3.DisplayFactors(number);

            //GreatestFactor obj4 = new GreatestFactor();
            //Console.WriteLine("Enter a number to find its greatest factor:");
            //int number = Convert.ToInt32(Console.ReadLine());
            //obj4.FindGreatestFactor(number);

            //MultiplesBelow100 obj5 = new MultiplesBelow100();
            //Console.WriteLine("Enter a number to find its multiples below 100:");
            //int number = Convert.ToInt32(Console.ReadLine());
            //obj5.DisplayMultiples(number);

            //FindBMI obj6 = new FindBMI();
            //Console.WriteLine("Enter weight in kilograms:");
            //double weight = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter height in meters:");
            //double height = Convert.ToDouble(Console.ReadLine());
            //obj6.CalculateBMI(weight, height);

            //FindYoungestAndTallest obj7 = new FindYoungestAndTallest();
            //Console.Write("Enter age of first person:");
            //int age1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter age of second person:");
            //int age2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter age of third person:");
            //int age3 = Convert.ToInt32(Console.ReadLine());
            //obj7.FindYoungest(age1, age2, age3);
            //Console.Write("Enter height of first person in meters:");
            //double height1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter height of second person in meters:");
            //double height2 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter height of third person in meters:");
            //double height3 = Convert.ToDouble(Console.ReadLine());
            //obj7.FindTallest(height1, height2, height3);

            //FizzBuzz obj8 = new FizzBuzz();
            //Console.WriteLine("Enter a number to print FizzBuzz up to that number:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //obj8.PrintFizzBuzz(n);

            //CheckPrime obj9 = new CheckPrime();
            //Console.WriteLine("Enter a number to check if it's prime or not:");
            //int number = Convert.ToInt32(Console.ReadLine());
            //obj9.IsPrime(number);

            FindPower obj10 = new FindPower();
            Console.WriteLine("Enter a base number:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter an exponent:");
            int power = Convert.ToInt32(Console.ReadLine());
            obj10.CalculatePower(number, power);






        }
    }
}