using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.String.Level_02
{
    internal class ToggleCase
    {
        /*
        Toggle Case of Characters
        Problem: Write a C# program to toggle the case of each character in a given string. Convert
        uppercase letters to lowercase and vice versa.  
        */

        public void Toggle(string str)
        {
            StringBuilder toggledString = new StringBuilder();
            foreach (char c in str)
            {
                if (char.IsUpper(c))
                {
                    toggledString.Append(char.ToLower(c));
                }
                else
                {
                    toggledString.Append(char.ToUpper(c));
                }
            }
            Console.WriteLine("Original String: " + str);
            Console.WriteLine("Toggled Case String: " + toggledString.ToString());
        }
    }
}
