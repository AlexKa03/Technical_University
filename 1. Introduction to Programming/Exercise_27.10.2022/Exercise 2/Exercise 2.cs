using System;

namespace Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int sum = 0;

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
