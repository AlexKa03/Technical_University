using System;

namespace Exercise_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Read two integer numbers. Sum them
                and print them. Every action needs
                to have it's function

                Hint:
                SumAndPrint
                Sum
                PrintResult
            */

            Console.WriteLine("Exercise 9");

            Console.Write("What is your first number: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("What is your second number: ");
            int b = int.Parse(Console.ReadLine());

            SumAndPrint(a, b);
        }

        static void SumAndPrint(int a, int b)
        {
            int result = Sum(a, b);
            PrintResult(result);
        }

        static int Sum(int a, int b)
        {
            return a + b;
        }

        static void PrintResult(int result) 
        {
            Console.WriteLine($"Result is {result}.");
        }
    }
}
