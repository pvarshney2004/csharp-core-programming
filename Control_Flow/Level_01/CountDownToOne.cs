using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Control_Flow.Level_01
{
    internal class CountDownToOne
    {
        public void CountDown(int number) 
        {
            while(number>=1) 
            {
                Console.WriteLine(number);
                number--;
            }
        }
    }
}
