using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Programming_Elements.Level_02
{
    internal class IntOperation
    {
        public void ope(int a, int b, int c) 
        {
            int op1 = a + b * c;
            int op2 = a * b + c;
            int op3 = c + a / b;
            int op4 = a % b + c;
            Console.WriteLine("a + b * c = " + op1);
            Console.WriteLine("a * b + c = " + op2);
            Console.WriteLine("c + a / b = " + op3);
            Console.WriteLine("a % b + c = " + op4);
        }
    }
}
