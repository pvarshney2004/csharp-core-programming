using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.String.Level_01
{
    internal class DemoNullRefrence
    {
        /*
          Demonstrate NullReferenceException
          ● Hint =>
            o Write a method to demonstrate NullReferenceException by accessing a
            method on a null string.
            o Use a try-catch block to handle the exception.
         */
        public void ShowNullReferenceException()
        {
            string ?str = null;
            try
            {
                int length = str.Length; // accessing Length property on a null string
                Console.WriteLine($"Length of the string: {length}");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Caught a NullReferenceException: " + ex.Message);
            }
        }
    }
}
