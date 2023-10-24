using System;

namespace Exercise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Like Exercise 2 (Same tbh)

            int n = 0;
            int m = 0;
            bool ok = false;
            int sum = 0;

            while (!ok)
            {
                Console.WriteLine("Enter positive integer value for number");
                ok = int.TryParse(Console.ReadLine(), out n) && n > 0;
            }

            ok = false;
            while (!ok)
            {
                Console.WriteLine("Enter positive integer value for dividing");
                ok = int.TryParse(Console.ReadLine(), out m) && m > 0;
            }

            for (int i = 1; i <= n; i++)
            {
                if (i % m == 0)
                {
                    sum += i;
                }               
            }

            Console.WriteLine($"Sum: {sum}");

        }
    }
}
