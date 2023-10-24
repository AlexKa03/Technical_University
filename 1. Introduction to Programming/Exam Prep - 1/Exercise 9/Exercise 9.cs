using System;

namespace Exercise_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               Write an application that prints to the screen all prime 
               numbers in the interval [M,N]. M and N are entered by the 
               user.

               A number is prime if it is divisible without a remainder
               only by 1 and itself.
            */
            Console.Write("Enter the lower limit: ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Enter the upper limit: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = m; i <= n; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                    }
                }

                if (isPrime && i != 1)
                {
                    Console.WriteLine($"{i} is prime number.");
                }
            }
        }
    }
}
