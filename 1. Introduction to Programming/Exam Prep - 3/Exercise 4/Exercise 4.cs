using System;

namespace Exercise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               Make a matrix with array. Matrix needs
               to be 3 x 3 and numbers are given from
               the code, not user.
            */

            int[,] matrix = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    int value = matrix[row, col];

                    Console.Write($"{value} ");
                }

                Console.WriteLine();
            }
        }
    }
}
