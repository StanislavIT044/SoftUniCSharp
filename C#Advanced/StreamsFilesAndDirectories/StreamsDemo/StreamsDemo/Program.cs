using System;
using System.IO;
using System.Text;

namespace StreamsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int lineCounter = 1;
            using (var reader = new StreamReader("secoundTextFile.txt"))
            {
                using (var writer = new StreamWriter("output.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();

                        writer.WriteLine($"{lineCounter} - {line}");
                        lineCounter++;
                    }
                }
            }

             


        }
    }
}
