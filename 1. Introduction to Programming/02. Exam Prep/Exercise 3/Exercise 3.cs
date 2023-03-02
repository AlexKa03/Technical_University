using System;

namespace Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               Passing arguments by reference. 
            */

            Console.WriteLine("Exercise 3");

            Console.Write("Please enter number a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Please enter number b: ");
            int b = int.Parse(Console.ReadLine());

            Swap(ref a, ref b);

            /* 
               When using reference is like giving your friend a toy,
               if he breaks is, its broken. In programing that means
               if i make a change in the function using reference
               it will be reflected in the original variable passed
               in the calling code.
            */

            Console.WriteLine($"Inside 'Main' method: a={a}, b={b}.");
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"Inside 'Swap' method: a={a}, b={b}.");
        }
    }
}
