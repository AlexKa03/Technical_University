using System;
using System.IO;

namespace Quadratic_matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int sumEvenRow = 0, sumOddCol = 0;

            using (StreamReader streamReader = new StreamReader("./matrix.txt"))
            {
                string ln;

                while ((ln = streamReader.ReadLine()) != null)
                {
                    string[] f = ln.Trim().Split();
                    for (int i = 1; i <= n; i++)
                    {
                        matrix[int.Parse(f[0]) - 1, int.Parse(f[1]) - 1] = int.Parse(f[2]);
                    }
                    for (int i = 0; i < f.Length; i++)
                    {

                        for (int j = 0; j < f.Length; j++)
                        {

                            if (matrix[i, j] == 0)
                            {
                                matrix[i, j] = -1;
                            }
                        }
                    }
                }

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (i % 2 != 0 && i != 0)
                        {
                            sumEvenRow += matrix[i, j];
                        }
                        if (j % 2 == 0) sumOddCol += matrix[i, j];
                    }
                }

                int counter = 0;
                int sumOdd = 0, sumEven = 0;

                foreach (int i in matrix)
                {
                    if (i % 2 == 0)
                    {
                        sumEven += i;
                    }
                    else
                    {
                        sumOdd += i;
                    }                       

                    if (counter == n)
                    {
                        counter = 0;
                        Console.Write("\n");
                    }

                    counter++;
                    Console.Write(i + " ");
                }

                Console.WriteLine("\n");
                Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
                Console.WriteLine($"Sum of even number: {sumEven}");
                Console.WriteLine($"Sum of odd number: {sumOdd}");
                Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
                Console.WriteLine($"Sum of even row numbers: {sumEvenRow}");
                Console.WriteLine($"Sum of odd col numbers: {sumOddCol}");
                Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
            }
        }
    }
}
