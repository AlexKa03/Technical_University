using System;

namespace Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               Make an array with user entered numbers
               for array. Then user need to give type
               again of the numbers before and he will
               recieve the index of that number.
            */

            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Enter a number. Remaining {array.Length - i}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter one of the numbers again: ");
            int value = int.Parse(Console.ReadLine());

            int index = FindIndex(array, value);

            if (index != -1)
            {
                Console.WriteLine($"The index of {value} is {index}.");
            }
            else
            {
                Console.WriteLine($"The number you entered isn't inside the array.");
            }
        }

        static int FindIndex(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
