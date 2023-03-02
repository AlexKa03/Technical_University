using System;

namespace Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Switch the values betwen a and b

            Console.Write("Enter number a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter number b: ");
            int b = int.Parse(Console.ReadLine());

            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"a = {a}, b = {b}");
        }
    }
}
