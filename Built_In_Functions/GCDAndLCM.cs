using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Built_In_Functions
{
    internal class GCDAndLCM
    {
        /*
GCD and LCM Calculator:
Create a program that calculates the Greatest Common Divisor (GCD) and Least Common
Multiple (LCM) of two numbers using functions.
         */
        public int FindGCD(int num1, int num2)
        {
            while(num1>0 && num2>0)
            {
                if (num1 > num2)
                {
                    num1 %= num2;
                }
                else
                {
                    num2 %= num1;
                }
            }
            return (num1 == 0 ? num2 : num1);    
        }
        public int FindLCM(int num1, int num2)
        {
            return (num1*num2)/FindGCD(num1, num2);
        }

        public bool Verify(int num1, int num2)
        {
            return (num1*num2) == (FindGCD(num1, num2)*FindLCM(num1,num2));
        }
    }
}
