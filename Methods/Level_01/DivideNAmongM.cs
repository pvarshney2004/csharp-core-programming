using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Methods.Level_01
{
    internal class DivideNAmongM
    {
        /*
         * Create a program to divide N number of chocolates among M children. Print the number
           of chocolates each child will get and also the remaining chocolates
        */
        public void DivideChocolates(int numberOfChocolates, int numberOfChildren)
        {
            int chocolatesPerChild = numberOfChocolates / numberOfChildren;
            int remainingChocolates = numberOfChocolates % numberOfChildren;
            Console.WriteLine($"Each child will get {chocolatesPerChild} chocolates.");
            Console.WriteLine($"Remaining chocolates: {remainingChocolates}");
        }

    }
}
