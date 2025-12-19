using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Arrays.Level_01
{
    internal class Copy2DTo1D
    {
        public void Copy(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[] array1D = new int[rows * cols];
            int index = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array1D[index] = matrix[i, j];
                    index++;
                }
            }
            Console.WriteLine("1D Array elements:");
            foreach (int item in array1D)
            {
                Console.Write(item + " ");
            }
        }
    }
}
