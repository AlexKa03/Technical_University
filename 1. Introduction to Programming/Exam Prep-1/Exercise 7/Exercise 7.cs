using System;

namespace Exercise_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
               Write an application that prints the Fibunacci sequence 
               up to the nth consecutive number, where n is entered by 
               the user and is positive number. The first two numbers 
               are 0 and 1, and each subsequent one is found by summing
               the the previous 2.

               for: n = 1 -> f(n) = 0
                   n = 2 -> f(n) = 1

               for: n > 2 -> f(n) = f(n - 1) + f(n - 2)
            */

            Console.Write("Please enter integer: ");
            int n = int.Parse(Console.ReadLine());

            int result = 0;
            int f1 = 0;
            int f2 = 1;
            string fibunacci = "";

            if (n == 1)
            {
                fibunacci += f1 + " ";
            }
            else if (n == 2)
            {
                fibunacci += f1 + " " + f2 + " ";
            }
            else
            {
                fibunacci = f1 + " " + f2 + " ";
                for (int i = 3; i <= n; i++)
                {
                    result = f1 + f2;
                    fibunacci += result + " ";
                    f1 = f2;
                    f2 = result;
                }
            }

            Console.WriteLine($"The Fibunacci sequence is: {fibunacci}");
        }
    }
}
