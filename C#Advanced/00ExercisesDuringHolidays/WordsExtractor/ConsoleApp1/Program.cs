namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    class Program
    {
        static string input;

        static void Main(string[] args) //TODO: refactoring
        {
            //Reader();
            SecoundReader();

            #region
            //List<string> rows = input.Split("\n").ToList();
            //List<string> enWords = new List<string>();
            //List<string> bgWords = new List<string>();



            //for (int i = 0; i < rows.Count; i++)
            //{
            //    if (rows[i].EndsWith("</strong></td>\r"))
            //    {
            //        enWords.Add(rows[i]);
            //    }
            //    else if (rows[i].EndsWith("</td></tr>\r"))
            //    {
            //        bgWords.Add(rows[i]);
            //    }
            //}



            //for (int i = 0; i < rows.Count; i++)
            //{
            //    if (rows[i].EndsWith("</strong></td>\r"))
            //    {
            //        enWords.Add(rows[i]);
            //    }
            //    else if (rows[i].EndsWith("</td></tr>\r"))
            //    {
            //        bgWords.Add(rows[i]);
            //    }
            //}


            //for (int i = 0; i < enWords.Count; i++)
            //{
            //    enWords[i] = enWords[i].Substring(33);
            //    int startIndex = enWords[i].IndexOf('<');
            //    enWords[i] = enWords[i].Substring(0, startIndex);
            //}

            ////var a = bgWords[0].ToCharArray();
            //for (int i = 0; i < bgWords.Count; i++)
            //{
            //    int index = bgWords[i].IndexOf('>');
            //    bgWords[i] = bgWords[i].Substring(index + 1);
            //    int startIndex = bgWords[i].IndexOf('<');
            //    bgWords[i] = bgWords[i].Substring(0, startIndex);
            //}

            //;

            //Writer(enWords, bgWords);
            #endregion

            List<string> rows = input.Split("\r").ToList();
            List<string> enWords = new List<string>();
            List<string> bgWords = new List<string>();


            for (int i = 0; i < 1198; i++)
            {
                int startIndex = rows[i].IndexOf('\t');
                rows[i] = rows[i].Substring(startIndex + 1);

                int index = rows[i].IndexOf('\t');
                enWords.Add(rows[i].Substring(0, index));

                int lastIndex = rows[i].LastIndexOf("]");
                //string word = rows[i].Substring(startIndex);
                string[] words = rows[i].Split("]");

                //Console.WriteLine($"{enWords[i]} - {bgWords[i]}");
                bgWords.Add(words[1]);
            }

            for (int i = 0; i < bgWords.Count; i++)
            {
                bgWords[i] = bgWords[i].Split("\t")[1];
            }

            for (int i = 0; i < bgWords.Count; i++)
            {
                Console.WriteLine($"{enWords[i]} - {bgWords[i]}");
            }

            ;
        }

        static private async void Writer(List<string> enWords, List<string> bgWords)
        {
            //(@"C:\Users\a1bg495660\source\repos\ConsoleApp1\output.txt", "Something");
            //using StreamWriter file = new(@"C:\Users\a1bg495660\source\repos\ConsoleApp1\output.txt", append: true, Encoding.UTF8);

            for (int i = 0; i < enWords.Count; i++)
            {
                string line = $"{enWords[i]} - {bgWords[i]}";

                //await file.WriteLineAsync(line);
                Console.WriteLine(line);
            }
        }
        static private void SecoundReader()
        {
            input = File.ReadAllText("C:\\Users\\a1bg495660\\source\\repos\\ConsoleApp1\\input2.txt");//TODO: relative path

            //Console.WriteLine(input);
        }

        static private void Reader()
        {
            input = File.ReadAllText("C:\\Users\\a1bg495660\\source\\repos\\ConsoleApp1\\input.txt");

            //Console.WriteLine(input);
        }
    }
}
