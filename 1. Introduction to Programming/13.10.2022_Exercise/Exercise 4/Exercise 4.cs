using System;

namespace Exercise_4
{
    internal class Exercise_4
    {
        static void Main(string[] args)
        {
            // TU Sofia why .NET 4.7.2 when there is 6.0 and 5.0 :D

            int n = int.Parse(Console.ReadLine());

            if (n % 2 != 0)
            {
                Console.WriteLine($"{n} is odd");
            }

        }
    }
}
