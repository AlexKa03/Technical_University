using System;

namespace Exercise_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Write a program with recursive function
                named "PowerR", which calculate the value
                of number m, raised to the power of n. Call
                the function with example parameters.
            */


            Console.WriteLine("Exercise 11");

            double result = PowerR(3, 4);
            Console.WriteLine($"Result: {result}");
        }

        static int PowerR(int m, int n)
        {
            if (n == 0)
            {
                return 1;
            }

            return m * PowerR(m, n - 1);
        }
    }
}
