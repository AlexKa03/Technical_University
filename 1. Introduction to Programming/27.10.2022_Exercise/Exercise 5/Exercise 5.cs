using System;

namespace Exercise_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Floor number");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Ceiling number");
            int n = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int j = m; j <= n; j++)
            {
                bool isPrime = false;
                if (j > 1)
                {
                    isPrime = true;
                    for (int i = 2; i <= Math.Floor(Math.Sqrt(j)) && isPrime; i++)
                    {

                        if (j % i == 0)
                        {
                            isPrime = false;
                            // break; same as "&& isPrime in for"
                        }
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine($"{j} is prime");
                    counter++;
                }
            }

            Console.WriteLine($"Prime count: {counter}"); ;
        }
    }
}
