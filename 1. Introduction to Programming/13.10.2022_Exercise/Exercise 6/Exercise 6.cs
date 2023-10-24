using System;

namespace Exercise_6
{
    internal class Exercise_6
    {
        static void Main(string[] args)
        {
            // TU Sofia why .NET 4.7.2 when there is 6.0 and 5.0 :D

            int n = int.Parse(Console.ReadLine());
            int i = 0;

            do
            {
                if (i == 3)
                {
                    i++;
                    continue;
                }

                Console.WriteLine(i);
                i++;
            } while (i < n);

        }
    }
}
