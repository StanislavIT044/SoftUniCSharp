namespace Problem02LineNumbers
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    class Program
    {
        static void Main()
        {
            StreamReader streamReader = new StreamReader($"../../../text.txt");
            StreamWriter streamWriter = new StreamWriter($"../../../newText.txt");

            List<string> text = new List<string>();

            using (streamReader)
            {
                int lineNumber = 0;

                while (!streamReader.EndOfStream)
                {
                    lineNumber++;

                    string line = $"Line{lineNumber}: {streamReader.ReadLine()}";

                    text.Add(line);

                    Console.WriteLine(line);
                }
            }

            using (streamWriter)
            {
                foreach (var line in text)
                {
                    streamWriter.WriteLine(line);
                }
            }

            Console.WriteLine($"{Environment.NewLine}Ready!!!");
        }
    }
}
