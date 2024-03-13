using System;

namespace Exercise_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Write a function called "IsPrime", that
                determines whether a given number is prime.
            */

            Console.WriteLine("Exercise 12");

            Console.Write("Please enter positive integer: ");
            int n = int.Parse(Console.ReadLine());
            string result = "";
            IsPrime(ref result, n);
            Console.WriteLine($"Number {n} {result}");
        }

        static void IsPrime(ref string result, int n)
        {
            if (n < 2)
            {
                result = "isn't prime.";
                return;
            }

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    result = "isn't prime.";
                    return;
                }
            }

            result = "is prime.";
        }
    }
}
