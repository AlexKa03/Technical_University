using System;

namespace Exercise_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               An application where the user enters an integer 
               and the letter is printed on the screen from the 
               Bulgarian alphabet, which has a sequence number 
               equal to the sum of the digits of the number.
            */

            Console.Write("Please enter a number whose sum of digits is <= 30: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            while (n > 0)
            {
                int digit = n % 10;
                sum += digit;
                n /= 10;
            }

            Console.WriteLine($"Sum of digits is: {sum}");

            if (sum <= 30)
            {
                char character = (char)('А' + sum - 1);
                Console.WriteLine($"Someone with a name starting with {character} is thinking about you.");
            }
            else
            {
                Console.Write("Please enter a number whose sum of digits is <= 30: ");
                n = int.Parse(Console.ReadLine());
            }
        }
    }
}
