using System;

namespace Exercise_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               Write an application that displays the following pyramid on the screen:
                   1
                  22
                 333
                4444
               55555
            */

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}
