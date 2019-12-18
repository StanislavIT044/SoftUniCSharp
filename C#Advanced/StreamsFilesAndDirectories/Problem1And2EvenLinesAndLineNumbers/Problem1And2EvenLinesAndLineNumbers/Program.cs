using System;
using System.IO;
using System.Linq;

namespace Problem1And2EvenLinesAndLineNumbers
{
    class Program
    {
        static void Main()
        {
            var lineCounter = 0;
            var symbolsToReplace = new[] { "-", ",", ".", "!", "?" };

            using (var streamReader = new StreamReader("text.txt"))
            {
                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();

                    if (lineCounter % 2 == 0)
                    {
                        var words = line.Split();

                        for (int i = 0; i < words.Length; i++)
                        {
                            var currentWord = words[i];

                            foreach (var symbol in symbolsToReplace)
                            {
                                currentWord = currentWord.Replace(symbol, "@");
                            }

                            words[i] = currentWord;
                        }

                        var result = string.Join(" ", words.Reverse());

                        Console.WriteLine(result);
                    }

                    lineCounter++;
                }
            }
        }
    }
}
