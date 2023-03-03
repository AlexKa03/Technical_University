using System;

namespace Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               Give and array value and print it with new variable.
            */

            int[] myArray = new int[10];
            myArray[0] = 5;

            int value = myArray[0];

            Console.WriteLine(value);
        }
    }
}
