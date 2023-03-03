using System;

namespace Exercise_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               A function that reverses the elements of an
               array,and returns a new array without changing
               the original array. Inputs are not given by
               the user.
            */

            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] reversedArray = ReversedArray(array);

            PrintArray(array);
            Console.WriteLine();
            PrintArray(reversedArray);
        }

        static int[] ReversedArray(int[] array) 
        {
            int n = array.Length;
            int[] reversed = new int[n];

            for (int i = 0; i < array.Length; i++)
            {
                reversed[i] = array[n - 1 - i];
            }

            return reversed;
        }

        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
