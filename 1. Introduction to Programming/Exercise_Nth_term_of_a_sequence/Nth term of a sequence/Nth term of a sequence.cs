using System;

namespace Nth_term_of_a_sequence
{
    internal class Program
    {
        public static int CalculatingElement(int numIndex, int[] array)
        {
            for (int i = 3; i <= numIndex - 1; i++)
            {
                array[i] = (3 * array[i - 3]) + (4 * array[i - 2]) - (7 * array[i - 1]);
            }

            return array[numIndex - 1];
        }

        public static int CalculateRecursive(int firstNum, int secondNum, int thirdNum, int numIndex)
        {
            int searchedNum;
            searchedNum = (3 * firstNum) + (4 * secondNum) - (7 * thirdNum);
            numIndex--;

            if (numIndex > 3)

            {
                return CalculateRecursive(secondNum, thirdNum, searchedNum, numIndex);
            }

            return searchedNum;

        }

        static void Main(string[] args)
        {
            int numIndex = int.Parse(Console.ReadLine());
            int[] recurrentArray = new int[100];

            recurrentArray[0] = 2;
            recurrentArray[1] = 4;
            recurrentArray[2] = 6;

            Console.WriteLine(CalculatingElement(numIndex, recurrentArray));
            Console.WriteLine(CalculateRecursive(2, 4, 6, numIndex));
        }
    }
}