using System;

namespace Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sum of the variable from for loop

            Console.Write("Enter positive number: ");
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }

            Console.WriteLine($"Sum = {sum}");
        }
    }
}
