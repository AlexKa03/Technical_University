using System;

namespace Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               Passing arguments by value.
            */

            Console.WriteLine("Exercise 2");

            Console.Write("Please enter number a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Please enter number b: ");
            int b = int.Parse(Console.ReadLine());
            Swap(a, b);
            Console.WriteLine($"Inside 'Main' method: a={a}, b={b}.");
        }

        static void Swap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"Inside 'Swap' method: a={a}, b={b}.");
            /* 
               We aren't returning any variable, becouse we have
               void function and we don't have any return method
            */
        }
    }
}
