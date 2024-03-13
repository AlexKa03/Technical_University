using System;

namespace Exercise_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               Write a function that finds the arithmetic
               mean of the elements of a two-dimensional
               array.
            */

            Console.Write($"How long will be the row of this matrix: ");
            int row = int.Parse(Console.ReadLine());

            Console.Write($"How long will be the column of this matrix: ");
            int col = int.Parse(Console.ReadLine());

            int[,] matrix = new int[row, col];

            InputArray(matrix);
            double averageValue = FindAverageValueFromAllElements(matrix);
            PrintAverageValue(averageValue);
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

        static double FindAverageValueFromAllElements(int[,] matrix)
        {
            double averageValue = 0;
            int counter = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    averageValue += matrix[row, col];
                    counter++;
                }
            }

            averageValue /= counter;

            return averageValue;
        }

        static void PrintAverageValue(double averageValue)
        {
            Console.WriteLine($"The average value for this matrix is {averageValue:f2}");
        }
    }
}
