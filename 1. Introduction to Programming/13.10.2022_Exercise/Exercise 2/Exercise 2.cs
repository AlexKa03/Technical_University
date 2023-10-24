using System;

namespace Exercise_2
{
    internal class Exercise_2
    {
        static void Main(string[] args)
        {
            // TU Sofia why .NET 4.7.2 when there is 6.0 and 5.0 :D

            float f = 1f / 3; // 1f = 1.00
            Console.WriteLine($"This is float: {f}");

            double d = 1.0 / 3;
            Console.WriteLine($"This is double: {d}");

            decimal dc = 1.0M / 3; // 1.0M - it's for using numbers with floating point in decimal
            Console.WriteLine($"This is deciml: {dc}");

        }
    }
}
