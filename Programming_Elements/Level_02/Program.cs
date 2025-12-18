using System;
namespace Core_Programming.Programming_Elements.Level_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Object Creation and Method Calling for all Class

            //PrintQuotientRemainder obj1 = new PrintQuotientRemainder();
            //obj1.CalculateQuotientRemainder(29,5);

            //IntOperation obj2 = new IntOperation();
            //obj2.ope(10, 5, 2);

            //TemperatureConversion obj3 = new TemperatureConversion();
            //obj3.convertCelsiusToFahrenheit(37);

            //TemperatureConvertion02 obj4 = new TemperatureConvertion02();
            //obj4.convertFahrenheitToCelsius(98.6);

            //Console.Write("Enter your Salary:");
            //int salary = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter your Bonus:");
            //int bonus = Convert.ToInt32(Console.ReadLine());
            //TotalIncome obj5 = new TotalIncome();
            //obj5.CalculateTotalIncome(salary, bonus);

            //SwapTwoNumber obj6 = new SwapTwoNumber();
            //Console.Write("Enter first number (a): ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter second number (b): ");
            //int b = Convert.ToInt32(Console.ReadLine());
            //obj6.SwapNumbers(a, b);

            //ConvertWeight obj7 = new ConvertWeight();
            //Console.Write("Enter weight in pounds: ");
            //double pounds = Convert.ToDouble(Console.ReadLine());
            //obj7.ConvertPoundsToKg(pounds);

            //CalculateSimpleInterest obj8 = new CalculateSimpleInterest();
            //Console.Write("Enter Principal amount: ");
            //double principal = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter Rate of interest: ");
            //double rate = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter Time in years: ");
            //double time = Convert.ToDouble(Console.ReadLine());
            //obj8.ComputeSimpleInterest(principal, rate, time);

            //int numberOfChocolates = Convert.ToInt32(Console.ReadLine());
            //int numberOfChildren = Convert.ToInt32(Console.ReadLine());
            //DivideNAmongM obj9 = new DivideNAmongM();
            //obj9.Distribute(numberOfChocolates, numberOfChildren);

            int side1InMeter = Convert.ToInt32(Console.ReadLine());
            int side2InMeter = Convert.ToInt32(Console.ReadLine());
            int side3InMeter = Convert.ToInt32(Console.ReadLine());
            CalculateRounds obj10 = new CalculateRounds();
            obj10.calculate(side1InMeter, side2InMeter, side3InMeter);
        }
    }
}