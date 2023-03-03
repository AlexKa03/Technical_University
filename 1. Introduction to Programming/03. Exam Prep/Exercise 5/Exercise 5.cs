using System;

namespace Exercise_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Write a function that inputs the
                elements of a one-dimensional
                integer array.
            */

            Console.Write($"How long will be this one-dimensional array: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            InputArray(array);
            PrintArray(array);
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

        static void PrintArray(int[] array) 
        {
            Console.Write("The array looks like this: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}
