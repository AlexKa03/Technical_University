using System;

namespace Exercise_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Write a program with iterative function
                named "PowerI", which calculate the value
                of number m, raised to the power of n. Call
                the function with example parameters.
            */

            Console.WriteLine("Exercise 10");

            double result = PowerI(3, 4);
            Console.WriteLine($"Result: {result}");
        }

        static double PowerI(double m, double n)
        {
            if (n == 0)
            {
                return 1;
            }

            double i = Math.Pow(m, n);

            return i;
        }
    }
}
