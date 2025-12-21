using System;
namespace Core_Programming.String.Level_01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string ?str = Console.ReadLine();
            //string ?str2 = Console.ReadLine();
            //CompareStrings obj1 = new CompareStrings();
            //obj1.Compare(str, str2);

            //ToLower obj2 = new ToLower();
            //obj2.ConvertToLowerCase("HELLO WORLD");

            //ToUpper obj3 = new ToUpper();
            //obj3.ConvertToUpperCase("hello world");

            //SplitTextIntoWords obj4 = new SplitTextIntoWords();
            //obj4.SplitAndDisplayWordLengths("Hello World from CSharp 12");

            //DemoFormatException obj5 = new DemoFormatException();
            //obj5.ShowFormatException();

            //DemoIndexOutOfRange obj6 = new DemoIndexOutOfRange();
            //obj6.ShowIndexOutOfRangeException();

            //DemoIndexOutOfRange02 obj7 = new DemoIndexOutOfRange02();
            //obj7.ShowIndexOutOfRangeException();

            //DemoArgumentOutOfRange obj8 = new DemoArgumentOutOfRange();
            //obj8.ShowArgumentException();

            //DemoNullRefrence obj9 = new DemoNullRefrence();
            //obj9.ShowNullReferenceException();

            //ReturnCharacters obj10 = new ReturnCharacters();
            //obj10.ReturnChars("Hello World");

            Console.WriteLine("Enter a string:");
            string? inputString = Console.ReadLine();
            Console.WriteLine("Enter start index:");
            int startIndex = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter end index:");
            int endIndex = Convert.ToInt32(Console.ReadLine());
            CreateSubstring obj11 = new CreateSubstring();
            obj11.CreateSubstrUsingCharAt(inputString, startIndex, endIndex);
        }
    }
}