using System;

namespace Exercise_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fibonaci

            Console.WriteLine("Enter when to stop");
            int n = int.Parse(Console.ReadLine());

            ulong f1 = 0;
            ulong f2 = 1;

            if (n >= 1)
            {
                Console.Write($"{f1} ");
            }       
            if (n >= 2)
            {
                Console.Write($"{f2} ");
            }

            for (int i = 3; i <= n; i++)
            {
                ulong f = f1 + f2;
                Console.Write($"{f} ");

                f1 = f2;
                f2 = f;
            }
        }
    }
}
