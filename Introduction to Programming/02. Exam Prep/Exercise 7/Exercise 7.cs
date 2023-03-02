using System;

namespace Exercise_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               Read two integer numbers and swap them.
            */

            Console.WriteLine("Exercise 7");

            Console.Write("Please enter the first number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Please enter the second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"First number is: {firstNumber}");
            Console.WriteLine($"Second number is: {secondNumber}");

            Exchange(ref firstNumber, ref secondNumber);

            Console.WriteLine("After the swap/ exchange:");

            Console.WriteLine($"First number is: {firstNumber}");
            Console.WriteLine($"Second number is: {secondNumber}");
        }

        static void Exchange(ref int firstNumber, ref int secondNumber)
        {
            int temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;
        }
    }
}
