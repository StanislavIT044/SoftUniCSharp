namespace Problem01EvenLines
{
    using System;
    using System.IO;

    class Program
    {
        static void Main()
        {
            int lineCounter = 0;
            char[] symbolsToReplace = { '-', ',', '.', '!', '?' };

            StreamReader streamReader = new StreamReader("../../../text.txt");

            using (streamReader)
            {
                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();

                    if (lineCounter % 2 == 0)
                    {
                        string[] words = line.Split();

                        for (int i = 0; i < words.Length; i++)
                        {
                            string currentWord = words[i];

                            foreach (var symbol in symbolsToReplace)
                            {
                                currentWord = currentWord.Replace(symbol, '@');
                            }

                            words[i] = currentWord;
                        }

                        string result = string.Join(" ", words);

                        Console.WriteLine(result);
                    }

                    lineCounter++;
                }
            }
        }
    }
}
