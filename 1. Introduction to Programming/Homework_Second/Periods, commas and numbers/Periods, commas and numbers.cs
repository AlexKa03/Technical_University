using System;
using System.IO;

namespace Periods__commas_and_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter file name: ");
            string fileName = Console.ReadLine();

            using (StreamWriter streamWriter = new StreamWriter($"{fileName}.txt"))
            {
                Console.Write("Write your sequence: ");
                string example = Console.ReadLine();

                streamWriter.WriteLine(example);
                streamWriter.Close();

                using (StreamReader streamReader = new StreamReader($"./{fileName}.txt"))
                {
                    string ln;
                    int commaOrDot = 0, numSequence = 0, numSequenceF = 0, i = 0;

                    while ((ln = streamReader.ReadLine()) != null)
                    {
                        while (i != ln.Length)
                        {
                            while (ln[i] == '.' || ln[i] == ',')
                            {
                                commaOrDot++;
                                i++;
                                if (i + 1 > ln.Length) break;
                            }
                            while (Char.IsDigit(ln[i]))
                            {
                                numSequence++;
                                i++;
                                if (i + 1 > ln.Length) break;
                            }
                            if (numSequence > 0)
                            {
                                numSequenceF++;
                            }
                            numSequence = 0;
                        }
                    }

                    Console.WriteLine(commaOrDot);
                    Console.WriteLine(numSequenceF);
                }
            }
        }
    }
}
