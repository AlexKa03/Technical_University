using System;

namespace Exercise_5
{
    internal class Exercise_5
    {
        static void Main(string[] args)
        {
            // TU Sofia why .NET 4.7.2 when there is 6.0 and 5.0 :D

            int n = int.Parse(Console.ReadLine());
            int i = 0;

            while (i < n)
            {
                if (i == 3)
                {
                    i++;
                    continue;
                }

                Console.WriteLine(i);
                i++;
                //if (i == 3)
                //{
                //    break;
                //}
            }

        }
    }
}
