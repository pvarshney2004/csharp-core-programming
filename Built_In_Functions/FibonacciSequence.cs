using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Built_In_Functions
{
    internal class FibonacciSequence
    {
        /*
         Fibonacci Sequence Generator: Write a program that generates the Fibonacci sequence up to a specified number of terms
         entered by the user
         */
        public void GenerateFibonacciSequence(int n)
        {
            int zero = 0;
            int one = 1;
            Console.Write(zero + " " + one + " ");
            for(int i=2; i<=n-2; i++)
            {
                int newNum = zero + one;
                Console.Write(newNum + " ");
                zero = one; one = newNum;
            }
        }
    }
}
