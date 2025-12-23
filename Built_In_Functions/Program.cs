using System;
namespace Core_Programming.Built_In_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            //NumberGuessingGame obj1 = new NumberGuessingGame();
            //obj1.Game();

            //MaxOfThree obj2 = new MaxOfThree();
            //Console.WriteLine(obj2.FindMaximum(23, 42, 11));

            //PrimeChecker obj3 = new PrimeChecker();
            //Console.WriteLine(obj3.IsPrime(5));

            //FibonacciSequence obj4 = new FibonacciSequence();
            //obj4.GenerateFibonacciSequence(10);

            //PalindromeString obj5 = new PalindromeString();
            //Console.WriteLine(obj5.IsPalindrome("naman"));

            //FactorialUsingRecursion obj6 = new FactorialUsingRecursion();
            //Console.WriteLine(obj6.FindFactorial(5));

            GCDAndLCM obj7 = new GCDAndLCM();
            Console.WriteLine(obj7.FindGCD(25, 95));
            Console.WriteLine(obj7.FindLCM(25, 95));
            Console.WriteLine(obj7.Verify(25, 95));

            //TemperatureConverter obj8 = new TemperatureConverter();
            //Console.WriteLine(obj8.CelToFarh(50));
            //Console.WriteLine(obj8.FarhToCel(122));

            //BasicCalculator obj9 = new BasicCalculator();
            //Console.WriteLine(obj9.Addition(2, 3));
            //Console.WriteLine(obj9.Substraction(2, 3));
            //Console.WriteLine(obj9.Multiplication(2, 3));
            //Console.WriteLine(obj9.Division(20, 3));

        }
    }
}