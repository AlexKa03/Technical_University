using System;
using System.IO;

namespace Even_Odd
{
    internal class EvenOdd
    {
        static void Main(string[] args)
        {
            using (StreamReader matrix = new StreamReader("./matrix.txt"))
            {
                string line;
                int evenSum = 0;
                int oddSum = 0;
                int lineCounter = 0;
                int colCounter = 0;

                while ((line = matrix.ReadLine()) != null)
                {
                    string[] numbers = line.Trim().Split();
                    int n = numbers.Length;

                    for (int i = 0; i < n; i++)
                    {
                        if (int.Parse(numbers[i]) % 2 == 0 && lineCounter % 2 == 0)
                        {
                            evenSum += int.Parse(numbers[i]);
                        }
                        if (colCounter % 2 != 0 && int.Parse(numbers[i]) % 2 != 0)
                        {
                            oddSum += int.Parse(numbers[i]);
                        }
                        colCounter++;
                    }

                    lineCounter++;
                    colCounter = 0;
                }

                Console.WriteLine(evenSum);
                Console.WriteLine(oddSum);
            }
        }
    }
}
