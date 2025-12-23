using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Built_In_Functions
{
    internal class BasicCalculator
    {
        /*
Basic Calculator:
Write a program that performs basic mathematical operations (addition, subtraction,
multiplication, division) based on user input.
● Each operation should be performed in its own function, and the program should
prompt the user to choose which operation to perform.
         */
        public int Addition(int a, int b)
        {
            return a + b;
        }
        public int Substraction(int a, int b)
        {
            return (a > b ? a - b : b - a);
        }
        public int Multiplication(int a, int b)
        {
            return a * b;
        }
        public int Division(int a, int b)
        {
            return a / b;
        }
    }
}
