using System;

namespace Exercise_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Write a function that inputs the
                elements of a two-dimensional
                integer array/ matrix.
            */

            Console.Write($"How long will be the row of this matrix: ");
            int row = int.Parse(Console.ReadLine());

            Console.Write($"How long will be the column of this matrix: ");
            int col = int.Parse(Console.ReadLine());

            int[,] matrix = new int[row, col];
            InputArray(matrix);
            PrintArray(matrix);
        }

        static void InputArray(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"Enter a value for this cordinate [{row}, {col}]: ");

                    int value = int.Parse(Console.ReadLine());
                    matrix[row, col] = value;
                }
            }
        }

        static void PrintArray(int[,] matrix)
        {
            Console.WriteLine("The matrix looks like this: ");

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
