using System;

namespace Exercise_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Read two numbers. Find what it is equal to when
                divided by each other, and what will be their
                remainder between them.
            */

            Console.WriteLine("Exercise 8");

            Console.Write("Please enter first number: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Please enter second number: ");
            int y = int.Parse(Console.ReadLine());

            int result;
            int reminder;

            Divide(x, y, out result, out reminder);

            Console.WriteLine($"The result is: {result}");
            Console.WriteLine($"The reminder is: {reminder}");
        }

        static void Divide(int x, int y, out int result, out int reminder)
        {
            result = x / y;
            reminder = x % y;
        }
    }
}
