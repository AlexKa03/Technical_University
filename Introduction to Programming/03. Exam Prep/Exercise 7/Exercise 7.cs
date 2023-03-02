using System;

namespace Exercise_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Write a function that finds the smallest
                value of a one- dimensional integer array.
            */

            Console.Write($"How long will be this one-dimensional array: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            InputArray(array);
            int smallestValue = FindSmallestValue(array);
            PrintSmallestValue(smallestValue);
        }

        static void InputArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Enter value for element [{i}]: ");

                int value = int.Parse(Console.ReadLine());
                array[i] = value;
            }
        }

        static int FindSmallestValue(int[] array)
        {
            int min = int.MaxValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            return min;
        }

        static void PrintSmallestValue(int smallestValue)
        {
            Console.WriteLine($"Smallest value of the array is {smallestValue}.");
        }

    }
}
