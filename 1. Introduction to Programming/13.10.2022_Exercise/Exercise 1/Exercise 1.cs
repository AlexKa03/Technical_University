using System;

namespace Exercise_1
{
    internal class Exercise_1
    {
        static void Main(string[] args)
        {
            // TU Sofia why .NET 4.7.2 when there is 6.0 and 5.0 :D

            Console.WriteLine("Please, enter your first name.");
            string fName = Console.ReadLine();

            Console.WriteLine("Please, enter your surname.");
            string sName = Console.ReadLine();

            Console.WriteLine("Please, enter your age.");
            int age = int.Parse(Console.ReadLine());


            Console.WriteLine($"Your name is {fName} {sName} and you are {age} year/s old.");

            // This is single line comment

            /* This is multiple line comment - open                 
               This is multiple line comment - close */

        }
    }
}
