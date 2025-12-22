using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Methods.Level_01
{
    internal class FindPosNegZero
    {
        /*
        Write a program to check whether a number is positive, negative, or zero.
        */
        public int Find(int number)
        {
            if (number < 0)
            {
                return -1;
            }
            else if(number > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }
        
    }
}
