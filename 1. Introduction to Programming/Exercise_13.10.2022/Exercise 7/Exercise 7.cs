using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7
{
    internal class Exercise_7
    {
        static void Main(string[] args)
        {
            // TU Sofia why .NET 4.7.2 when there is 6.0 and 5.0 :D

            int n = int.Parse(Console.ReadLine());
            int i = 0;

            for (i = 0; i < n; i++)
            {
                if (i == 3)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

        }
    }
}
