using System;

namespace Exercise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               Passing output arguments.
            */

            Console.WriteLine("Exercise 4");

            Console.Write("Please enter number a: ");
            int a = int.Parse(Console.ReadLine());
            int aa;

            PrintSquared(a, out aa);

            /*
               The out keyword in C# is used to pass a variable 
               by reference to a method, but unlike the ref 
               keyword, it does not require the variable to be 
               initialized before passing it to the method. 

               Think of it like this: when you go to a store and
               buy something, the cashier gives you a receipt as
               proof of purchase. The receipt has the same 
               information as the item you bought, but you didn't
               have to bring it with you to the store.
            */

            Console.WriteLine($"'aa' inside 'Main' function: {aa}");
        }

        static void PrintSquared(int a, out int squared)
        {
            squared = a * a;
            Console.WriteLine($"'squared' inside 'PrintSquared' function : {squared}");
        }
    }
}
