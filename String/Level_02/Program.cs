using System;
namespace Core_Programming.String.Level_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CountVowelConsonant obj1 = new CountVowelConsonant();
            //obj1.Count("Hello world");

            //ReverseString obj2 = new ReverseString();
            //obj2.Reverse("prashant");

            //CheckPalindrome obj3 = new CheckPalindrome();
            //obj3.IsPalindrome("naman");
            //obj3.IsPalindrome("abc");

            //ToggleCase obj4 = new ToggleCase();
            //obj4.Toggle("HeLLo WoRLd");

            //SubstringOccurence obj5 = new SubstringOccurence();
            //obj5.Count("Hello world, welcome to the world of C#", "world");

            //LongestWord obj6 = new LongestWord();
            //obj6.FindLongestWord("Find the longest word in this sentence");

            //CompareLexicographically obj7 = new CompareLexicographically();
            //obj7.CompareStrings("apple", "banana");

            //RemoveDuplicate obj8 = new RemoveDuplicate();
            //obj8.RemoveDuplicates("programming");

            //MostFrequentChar obj9 = new MostFrequentChar();
            //obj9.Find("success");

            //RemoveSpecificChar obj10 = new RemoveSpecificChar();
            //obj10.RemoveChar("Hello World", 'l');

            CheckAnagram obj11 = new CheckAnagram();
            obj11.Anagram("adebc", "debac");

        }
    }
}