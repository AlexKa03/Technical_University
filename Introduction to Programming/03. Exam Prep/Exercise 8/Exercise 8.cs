using System;

namespace Exercise_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               Write a function that finds the smallest
               value from each row of a two-dimensional
               integer array / matrix. 
            */

            Console.Write($"How long will be the row of this matrix: ");
            int row = int.Parse(Console.ReadLine());

            Console.Write($"How long will be the column of this matrix: ");
            int col = int.Parse(Console.ReadLine());

            int[,] matrix = new int[row, col];

            InputArray(matrix);
            int[] allSmallestValues = FindSmallestValueForRows(matrix);
            PrintAllSmallestValues(allSmallestValues);
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

        static int[] FindSmallestValueForRows(int[,] matrix)
        {
            int[] allSmallestValues = new int[matrix.GetLength(0)];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int smallestValue = int.MaxValue;

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] < smallestValue)
                    {
                        smallestValue = matrix[row, col];
                    }
                }

                allSmallestValues[row] = smallestValue;
            }

            return allSmallestValues;
        }

        static void PrintAllSmallestValues(int[] allSmallestValues)
        {
            for (int i = 0; i < allSmallestValues.Length; i++)
            {
                Console.WriteLine($"Smallest value at line {i} is {allSmallestValues[i]}.");
            }
        }
    }
}
