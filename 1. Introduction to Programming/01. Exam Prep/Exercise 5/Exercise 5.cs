using System;

namespace Exercise_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
               Write an application that finds the sum of the first N number of targets
               positive numbers. N is a positive integer that is introduced by
               the user. 
            */

            Console.Write("Please enter positive integer: ");
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }

            Console.WriteLine($"Sum of the number 1 to {n} is {sum}");
        }
    }
}
