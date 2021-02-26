namespace InterviewTaskJSON
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using Newtonsoft.Json;

    class Program
    {
        static void Main()
        {
            string json = File.ReadAllText(@"..\..\..\input.txt");

            Console.WriteLine(GetMovieStarsInfo(json));            
        }

        static string GetMovieStarsInfo(string json)
        {
            List<MovieStar> movieStars = JsonConvert.DeserializeObject<List<MovieStar>>(json);

            StringBuilder sb = new StringBuilder();

            foreach (var person in movieStars)
            {
                int age = int.Parse(DateTime.UtcNow.ToString("yyy")) - int.Parse(person.DateOfBirth.ToString("yyy"));

                sb.AppendLine($"{person.Name} {person.Surname}");
                sb.AppendLine($"{person.Sex}");
                sb.AppendLine($"{person.Nationality}");
                sb.AppendLine($"{age} years old");
                sb.AppendLine();
            }

            return sb.ToString().TrimEnd();
        }
    }
}
