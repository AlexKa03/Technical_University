using System;

namespace Exercise_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               Print first and last name.
            */

            Console.WriteLine("Exercise 6");

            Console.Write("What is your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("What is your last name: ");
            string lastName = Console.ReadLine();

            printMyName(firstName, lastName);

            // It's void function that is why we prin inside of it, not here.
        }

        static void printMyName(string firstName, string lastName) 
        {
            string name = String.Format($"My name is {firstName} {lastName}.");
            Console.WriteLine(name);
        }
    }
}
