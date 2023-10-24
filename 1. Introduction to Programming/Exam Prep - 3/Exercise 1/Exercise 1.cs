using System;
using System.Xml.Linq;

namespace Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               Print numbers from array.
            */

            int[] array = new int[4] { 100, 200, 300, 400 };

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
