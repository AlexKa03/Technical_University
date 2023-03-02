using System;

namespace Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // With given month and number tell how much days does the month have

            Console.Write("Enter number of the month: ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Enter the year: ");
            int year = int.Parse(Console.ReadLine());

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine($"Month number {month} of {year} has 31 days.");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine($"Month number {month} of {year} has 30 days.");
                    break;
                case 2:
                    /* 
                       A year may be a leap year if it is evenly divisible by 4.
                       Years that are divisible by 100 (century years such as 1900 or 2000) 
                       can't be leap years unless they are also divisible by 400.
                    */

                    if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                    {
                        Console.WriteLine($"Month number {month} of {year} has 29 days.");
                    }
                    else
                    {
                        Console.WriteLine($"Month number {month} of {year} has 28 days.");
                    }
                    break;
                default:
                    Console.WriteLine($"{month} is not a valid month number");
                    break;
            }
        }
    }
}
