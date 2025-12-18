using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Control_Flow.Level_01
{
    internal class CountDownToOne02
    {
        public void CountDown(int number)
        {
            for (; number >= 1; number--)
            {
                Console.WriteLine(number);
            }
        }
    }
}
