using System;

namespace Exercise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Enter random input and print for each letter ther char code

            Console.Write("Enter a symbols/s: ");
            string input = Console.ReadLine();

            foreach (var character in input) 
            { 
                Console.WriteLine($"The code of letter {character} is {(int)character}");
            }
        }
    }
}
