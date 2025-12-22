using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programming.Methods.Level_03
{
    internal class MatrixManipulation
    {
        /*
         Write a program to perform matrix manipulation operations like addition,
subtraction, multiplication, and transpose. Also finding the determinant and inverse of a
matrix. The program should take random matrices as input and display the result of the
operations.
Hint =>
a. Write a Method to create a random matrix taking rows and columns as parameters
b. Write a Method to add two matrices
c. Write a Method to subtract two matrices
d. Write a Method to multiply two matrices
e. Write a Method to transpose matrix
f. Write a Method to find the determinant of a 2x2 matrix
g. Write a Method to find the determinant of a 3x3 matrix
h. Write a Method to display a matrix
         */

        static Random r = new Random();

        // create a random matrix
        public int[,] CreateRandomMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    matrix[i, j] = r.Next(1, 10);
            return matrix;
        }

        // add two matrices
        public int[,] AddTwoMatrix(int[,] mat1, int[,] mat2)
        {
            int r = mat1.GetLength(0);
            int c = mat1.GetLength(1);
            int[,] res = new int[r, c];
            for(int i=0; i<r; i++)
            {
                for(int j=0; j<c; j++)
                {
                    res[i,j] = mat1[i, j] + mat2[i,j];
                }
            }
            return res;
        }
        // subtract two matrices
        public int[,] SubtractTwoMatrix(int[,] mat1, int[,] mat2)
        {
            int r = mat1.GetLength(0);
            int c = mat1.GetLength(1);
            int[,] res = new int[r, c];
            for(int i=0; i<r; i++)
            {
                for(int j=0; j<c; j++)
                {
                    res[i,j] = mat1[i, j] - mat2[i,j];
                }
            }
            return res;
        }

        // Multiply matrices
        public int[,] MultiplyMatrices(int[,] A, int[,] B)
        {
            int rowsA = A.GetLength(0);
            int colsA = A.GetLength(1);
            int colsB = B.GetLength(1);

            int[,] result = new int[rowsA, colsB];

            for (int i = 0; i < rowsA; i++)
                for (int j = 0; j < colsB; j++)
                    for (int k = 0; k < colsA; k++)
                        result[i, j] += A[i, k] * B[k, j];
            return result;
        }

        // Transpose of a matrix
        public int[,] TransposeMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] transpose = new int[cols, rows];

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    transpose[j, i] = matrix[i, j];

            return transpose;
        }

        // determinant of 2X2 matrix
        public int Determinant2x2(int[,] m)
        {
            return m[0, 0] * m[1, 1] - m[0, 1] * m[1, 0];
        }

        // determinant of 3x3 matrix
        static int Determinant3x3(int[,] m)
        {
            return m[0, 0] * (m[1, 1] * m[2, 2] - m[1, 2] * m[2, 1])
                 - m[0, 1] * (m[1, 0] * m[2, 2] - m[1, 2] * m[2, 0])
                 + m[0, 2] * (m[1, 0] * m[2, 1] - m[1, 1] * m[2, 0]);
        }

        // Display matrix
        public void DisplayMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write($"{matrix[i, j],2} ");
                Console.WriteLine();
            }
        }
    }
}
