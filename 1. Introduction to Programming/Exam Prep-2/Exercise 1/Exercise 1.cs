using System;

namespace Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               Find which number is smallest and print it's value.
            */

            Console.WriteLine("Exercise 1");

            Console.Write("Please enter number a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Please enter number b: ");
            int b = int.Parse(Console.ReadLine());

            int m = Min(a, b);

            Console.WriteLine($"Smallest number is {m}.");
        }

        static int Min(int a, int b)
        {
            return a < b ? a : b;
        }
    }
}
