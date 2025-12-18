using System;
namespace Core_Programming.Programming_Elements.Level_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Object Creation for all Class
            FindAge obj1 = new FindAge();
            FindAverage obj2 = new FindAverage();
            ConvertDistance obj3 = new ConvertDistance();
            CalculateProfitLoss obj4 = new CalculateProfitLoss();
            MaximumHandshake obj5 = new MaximumHandshake();
            TotalPurchasePrice obj6 = new TotalPurchasePrice();
            ConvertFeetToYardsAndMiles obj7 = new ConvertFeetToYardsAndMiles();
            FindSquareSide obj8 = new FindSquareSide();
            EarthVolume obj9 = new EarthVolume();
            CourseDiscount obj10 = new CourseDiscount();
            BasicCalculator obj11 = new BasicCalculator();
            PenDistribution obj12 = new PenDistribution();
            ConvertCmToFeetAndInches obj13 = new ConvertCmToFeetAndInches();


            //Method Calling for all Class

            // Program to find age
            //Console.WriteLine("Enter your birth year to calculate age:");
            //int birthYear = Convert.ToInt32(Console.ReadLine());
            //obj1.CalculateAge(birthYear);

            // Program to find average of three subjects marks
            //Console.WriteLine("Enter marks for Math: ");
            //int math = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter marks for Physics: ");
            //int physics = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter marks for Chemistry: ");
            //int chemistry = Convert.ToInt32(Console.ReadLine());
            //obj2.CalculateAverage(math, physics, chemistry);

            // Program to convert distance from km to miles
            //Console.WriteLine("Enter distance in kilometers: ");
            //double km = Convert.ToDouble(Console.ReadLine());
            //obj3.ConvertKmToMiles(km);

            // Program to calculate profit/loss
            //int costPrice = 129;
            //int sellingPrice = 191;
            //obj4.ComputeProfit(costPrice, sellingPrice);

            //Program to calculate maximum handshakes
            //Console.WriteLine("Enter the number of students: ");
            //int numberOfStudents = Convert.ToInt32(Console.ReadLine());
            //obj5.calculateMaxHandshakes(numberOfStudents);

            // Program to calculate total price
            //Console.Write("Enter unit price (INR): ");
            //double unitPrice = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter quantity: ");
            //int quantity = Convert.ToInt32(Console.ReadLine());
            //obj6.CalculateTotalPurchasePrice(unitPrice, quantity);

            // Program to convert feet into miles and yards 
            //Console.WriteLine("Enter distance in feets: ");
            //double distanceInFeet = Convert.ToDouble(Console.ReadLine());
            //obj7.convert(distanceInFeet);

            //Program to find side of square
            //Console.WriteLine("Enter the perimeter of square: ");
            //double perimeter = Convert.ToDouble(Console.ReadLine());
            //obj8.calculateSide(perimeter);

            // Program to find volume of earth
            //double radiusOfEarthInKM = 6378;
            //obj9.FindVolume(radiusOfEarthInKM);

            //Program to calculate discount on course fee
            //obj10.FindDiscount();

            // Program to perform basic calculator operations
            //Console.WriteLine("Enter first number: ");
            //double num = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter second number: ");
            //double num2 = Convert.ToDouble(Console.ReadLine());
            //obj11.PerformCalculation(num, num2);

            // Program to distribute pens among students
            //int totalPens = 14;
            //int numberOfStudents = 3;
            //obj12.DistributePens(totalPens, numberOfStudents);

            // Program to convert cm to feet and inches
            Console.WriteLine("Enter length in centimeters: ");
            double cm = Convert.ToDouble(Console.ReadLine());
            obj13.ConvertCm(cm);
        }
    }
}