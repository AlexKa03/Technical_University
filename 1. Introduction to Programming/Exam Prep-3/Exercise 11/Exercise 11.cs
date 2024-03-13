using System;

namespace Exercise_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               A function that reverses the elements of a given array
               without creating a new one (modifies the original array).
            */

            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            PrintArray(array);

            ReversedInSameArray(array);
            
            Console.WriteLine();
            PrintArray(array);
        }

        static void ReversedInSameArray(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n / 2; i++)
            {
                int tmp = array[i];
                array[i] = array[n - i - 1];
                array[n - i - 1] = tmp;
            }
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
