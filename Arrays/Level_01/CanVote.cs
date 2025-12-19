using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Arrays.Level_01
{
    internal class CanVote
    {
        public void Find(int[] ages)
        {
            for (int i = 0; i < ages.Length; i++)
            {
                if (ages[i] >= 18)
                {
                    Console.WriteLine("Age " + ages[i] + ": Eligible to vote");
                }
                else
                {
                    Console.WriteLine("Age " + ages[i] + ": Not eligible to vote");
                }
            }
        }
    }
}
