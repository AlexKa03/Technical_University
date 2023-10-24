using System;

namespace Exercise_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               Write a program that prints on the screen all the natural ones
               three-digit numbers that are multiples of the sum of their 
               digits. The program should display their total number.

               Example: 102 has a sum of 3 digits, and 102 is divisible by 3
                        without a remainder 
            */

            int count = 0;

            for (int i = 100; i <= 999; i++)
            {
                int y = i;
                int sum = 0;

                while (y > 0)
                {
                    int x = y % 10;
                    sum += x;
                    y /= 10;
                }

                if (i % sum == 0)
                {
                    Console.WriteLine($"{i}");
                    count++;
                }
            }

            Console.WriteLine($"Total count is {count}.");
        }
    }
}
