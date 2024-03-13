using System;

namespace Exercise_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               Factorial, recursive
            */

            Console.WriteLine("Exercise 5");

            Console.Write("Please enter number to find it's factorial: ");
            uint n = uint.Parse(Console.ReadLine());

            ulong factorial = Factorial(n);

            Console.WriteLine($"{n}! = {factorial}");
        }

        static ulong Factorial(uint n)
        {
            // Recursive

            if (n <= 1)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

        //static ulong Factorial(uint n)
        //{
        //       Iterative

        //    int result = 1;
        //    for(int i = 2; i <= n; i++)
        //    {
        //       result *= i;
        //    }
        //    return result;
        //}
    }
}
