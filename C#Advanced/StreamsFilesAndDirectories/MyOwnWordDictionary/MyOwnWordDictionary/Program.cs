using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MyOwnWordDictionary
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, string> wordDictionary = new Dictionary<string, string>();

            using (StreamReader wordsReader = new StreamReader(@"..\..\..\..\WordDictionary.txt"))
            {
                while (!wordsReader.EndOfStream)
                {
                    string[] line = wordsReader.ReadLine()
                        .Split(new char[] { '-', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    wordDictionary.Add(line[0], line[1]);
                }
            }

            Console.WriteLine($"Count of words: {wordDictionary.Count}");

            using (StreamWriter wordsWriter = new StreamWriter(@"..\..\..\..\WordDictionary.txt"))
            {
                foreach (var word in wordDictionary.OrderBy(x => x.Key))
                {
                    wordsWriter.WriteLine($"{word.Key} - {word.Value}");
                }
            }
        }
    }
}
