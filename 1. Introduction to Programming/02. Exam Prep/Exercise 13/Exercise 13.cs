using System;

namespace Exercise_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Write a function that lets the user enter a positive
                integer a number and returns that number as the result.
            */

            Console.WriteLine("Exercise 13");

            int userInput = GetPositiveInteger();
            Console.WriteLine($"This is the user's number : {userInput}");
        }

        static int GetPositiveInteger() 
        {
            int num;
            while (true)
            {
                Console.Write("Enter a positive integer: ");
                string input = Console.ReadLine();
                bool isValidInput = int.TryParse(input, out num);

                if (isValidInput && num > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a positive integer.");
                }
            }

            return num;
        }
    }
}
