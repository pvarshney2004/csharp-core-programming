using System;
namespace Core_Programming.Methods.Level_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] heights = new int[11];
            //Random r = new Random();
            //for(int i=0; i < 11; i++)
            //{
            //    heights[i] = r.Next(150,251);
            //}
            //ShortestTallestMean obj1 = new ShortestTallestMean();
            //double meanHeight = obj1.MeanHeight(heights);
            //Console.WriteLine("Mean height of the football team players: " + meanHeight);
            //int min = obj1.Shortest(heights);
            //Console.WriteLine("Shortest heights from the football team player: " + min);
            //int max = obj1.Tallest(heights);
            //Console.WriteLine("Tallest heights from the football team player: " + max);

            //int number = 153;
            //int count = NumberChecker.CountDigits(number);
            //Console.WriteLine($"Number of digits in {number} is: {count}");
            //int[] digits = NumberChecker.StoreDigits(number);
            //bool isDuck = NumberChecker.CheckDuck(digits);
            //if(isDuck)
            //{
            //    Console.WriteLine($"{number} is a duck number");
            //}
            //else
            //{
            //    Console.WriteLine($"{number} is not a duck number");
            //}
            //NumberChecker.CheckArmstrong(digits);

            //int number = 1056;
            //int[] digits = NumberChecker02.StoreDigits(number);
            //double sumOfSquares = NumberChecker02.SumOfSquareOfFactors(digits);
            //Console.WriteLine($"Sum of squares of digits in {number} is: {sumOfSquares}");
            //NumberChecker02.CheckHarshad(number, digits);
            //NumberChecker02.FindFrequency(digits);


            //EuclideanDistance obj2 = new EuclideanDistance();   
            //obj2.Find(5.5,6.5,9.7,8.6);
            //double[] ans = obj2.FindEquation(5.5, 6.5, 9.7, 8.6);
            //Console.WriteLine(string.Join(" ",ans));

            //OTPNumber obj3 = new OTPNumber();
            //int[] otps = new int[10];
            //for(int i=0; i<otps.Length; i++)
            //{
            //    otps[i] = obj3.GenerateOTP();
            //}
            //Console.WriteLine("OTPs are: " + string.Join(" ", otps));
            //bool areUnique = obj3.ValidateOTPs(otps);
            //if (areUnique)
            //{
            //    Console.Write("All otps are unique");
            //}
            //else
            //{
            //    Console.Write("Duplicate found in otps");
            //}

            //double x1 = 2, y1 = 4;
            //double x2 = 4, y2 = 6;
            //double x3 = 6, y3 = 8;
            //CollinearPoints obj4 = new CollinearPoints();
            //Console.WriteLine("Using Slope Method:");
            //bool slopeResult = obj4.IsCollinearByUsingSlope(x1, y1, x2, y2, x3, y3);
            //Console.WriteLine("Collinear: " + slopeResult);
            //Console.WriteLine("\nUsing Area of Triangle Method:");
            //bool areaResult = obj4.IsCollinearByUsingAreaMethod(x1, y1, x2, y2, x3, y3);
            //Console.WriteLine("Collinear: " + areaResult);

            //BonusProgram obj5 = new BonusProgram();
            //int[,] data = obj5.GenerateEmployeeData(5);
            //double[,] newDataWithBonus = obj5.CalculateBonus(data);
            //obj5.Display(data,newDataWithBonus);


            //Console.Write("Enter month (1-12): ");
            //int month = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter year: ");
            //int year = Convert.ToInt32(Console.ReadLine());
            //Calender c = new Calender();
            //c.PrintCalendar(month, year);

            //int number = 7;
            //Console.WriteLine("Number: " + number);
            //Console.WriteLine("Prime Number: " + NumberChecker03.IsPrime(number));
            //Console.WriteLine("Neon Number: " + NumberChecker03.IsNeon(number));
            //Console.WriteLine("Spy Number: " + NumberChecker03.IsSpy(number));
            //Console.WriteLine("Automorphic Number: " + NumberChecker03.IsAutomorphic(number));
            //Console.WriteLine("Buzz Number: " + NumberChecker03.IsBuzz(number));


            MatrixManipulation m = new MatrixManipulation();
            int[,] A = m.CreateRandomMatrix(3, 3);
            int[,] B = m.CreateRandomMatrix(3, 3);
            Console.WriteLine("Matrix A:");
            m.DisplayMatrix(A);
            Console.WriteLine("\nMatrix B:");
            m.DisplayMatrix(B);
            Console.WriteLine("\nAddition:");
            m.DisplayMatrix(m.AddTwoMatrix(A, B));
            Console.WriteLine("\nSubtraction:");
            m.DisplayMatrix(m.SubtractTwoMatrix(A, B));

        }
    }
}