using System;

namespace Exercise_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
               Write an application that finds the sum of the first N number of targets
               positive numbers that divide without a remainder by the number M. N and M are integers
               positive numbers that are entered by the user.
            */

            Console.Write("Please enter positive integer: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Please enter divisor: ");
            int m = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % m == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine($"Sum of the number 1 to {n}, which are multiples of {m} is {sum}");
        }
    }
}
