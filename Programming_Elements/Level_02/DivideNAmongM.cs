using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Programming_Elements.Level_02
{
    internal class DivideNAmongM
    {
        public void Distribute(int n, int m)
        {
            int quotient = n / m;
            int remainder = n % m;
            Console.WriteLine($"The number of chocolates each child gets is {quotient} and the number of remaining chocolates is {remainder}");
        }
    }
}
