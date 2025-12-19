using System;
namespace Core_Programming.Arrays.Level_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] ages = new int[10];
            //for (int i = 0; i < ages.Length; i++)
            //{
            //    Console.Write("Enter age " + (i + 1) + ": ");
            //    ages[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //CanVote canVoteChecker = new CanVote();
            //canVoteChecker.Find(ages);

            //CheckPositiveNegativeZero obj2 = new CheckPositiveNegativeZero();
            //int[] nums = new int[5];
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.Write("Enter number " + (i + 1) + ": ");
            //    nums[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //obj2.Check(nums);

            //MultiplicationTable obj3 = new MultiplicationTable();
            //Console.Write("Enter a number to print its multiplication table: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //obj3.PrintTable(number);

            //Copy2DTo1D obj4 = new Copy2DTo1D();
            //int rows = Convert.ToInt32(Console.ReadLine());
            //int cols = Convert.ToInt32(Console.ReadLine());
            //int[,] matrix = new int[rows, cols];
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write($"Enter element at position [{i},{j}]: ");
            //        matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            //obj4.Copy(matrix);

            //FizzBuzz obj5 = new FizzBuzz();
            //int num = Convert.ToInt32(Console.ReadLine());
            //obj5.PrintFizzBuzz(num);

            //double[] heights = new double[11];
            //for (int i = 0; i < heights.Length; i++)
            //{
            //    Console.Write("Enter height " + (i + 1) + ": ");
            //    heights[i] = Convert.ToDouble(Console.ReadLine());
            //}
            //MeanHeight obj6 = new MeanHeight();
            //obj6.Calculate(heights);

            //int num = Convert.ToInt32(Console.ReadLine());
            //EvenOdd obj7 = new EvenOdd();
            //obj7.Separate(num);

            int num = Convert.ToInt32(Console.ReadLine());
            FindFactors obj8 = new FindFactors();
            obj8.Find(num);

        }
    }
    
    
}