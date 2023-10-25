using System;

namespace Exercise_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               A function that prints to the screen the number
               of times each element in an array occurs.
            */

            int[] array = new int[] { 1, 2, 3, 3, 1, 1, 3, 2, 1, 4, 5, 5, 6, 5, 7 };

            CountArrayAndPrint(array);
        }

        static void CountArrayAndPrint(int[] array)
        {
            int n = array.Length;
            int[] counters = new int[n];

            for (int i = 0; i < n; i++)
            {
                if (counters[i] != -1)
                {
                    counters[i] = 1;
                    for (int j = i + 1; j < n; j++)
                    {
                        if (array[j] == array[i])
                        {
                            counters[i]++;
                            counters[j] = -1;
                        }
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (counters[i] > 0)
                {
                    Console.WriteLine($"{array[i]} се среща {counters[i]} пъти");
                }
            }
        }
    }
}
