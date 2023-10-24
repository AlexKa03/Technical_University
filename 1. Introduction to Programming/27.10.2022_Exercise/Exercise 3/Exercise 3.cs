using System;

namespace Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Like Exercise 1 (Same tbh)

            int n = 0;
            bool ok = false;
            int sum = 0;

            while (!ok)
            {
                Console.WriteLine("Enter positive integer value");
                ok = int.TryParse(Console.ReadLine(), out n) && n > 0;
            }

            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
