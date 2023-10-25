using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Set_of_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string uniqueLetters = "";

            Dictionary<char, int> letterCountsMax = new Dictionary<char, int>();
            Dictionary<char, int> letterCounts = new Dictionary<char, int>();
            string[] words;

            using (StreamReader file = File.OpenText("./data.txt"))
            {
                string inputString = file.ReadToEnd();
                words = File.ReadAllLines("./data.txt");

                for (int i = 0; i < inputString.Length; i++)
                {
                    if (!uniqueLetters.Contains(inputString[i]))
                        uniqueLetters += inputString[i];
                }

                foreach (char letter in uniqueLetters)
                    letterCountsMax[letter] = 1;

                foreach (string word in words)
                {
                    letterCounts = new Dictionary<char, int>();
                    foreach (char letter in word)
                    {
                        if (!letterCounts.ContainsKey(letter))
                            letterCounts[letter] = 1;
                        else
                            letterCounts[letter]++;
                    }

                    foreach (var item in letterCounts)
                    {
                        if (item.Value > letterCountsMax[item.Key])
                            letterCountsMax[item.Key] = item.Value;
                    }
                }
                var letterCountsMaxSorted = new Dictionary<char, int>(letterCountsMax).OrderBy(x => x.Key);

                foreach (var item in letterCountsMaxSorted)
                {
                    for (int i = 0; i < item.Value; i++)
                        if (item.Key > 40 && item.Key < 123)
                            Console.Write(item.Key + ",");
                }
            }
        }
    }
}
