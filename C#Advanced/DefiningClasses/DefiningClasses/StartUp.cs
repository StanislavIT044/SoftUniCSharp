using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> peopleMoreThan30 = new List<Person>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] personInfo = Console.ReadLine().Split();

                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);

                Person member = new Person(name, age);

                peopleMoreThan30.Add(member);

            }

            foreach (var member in peopleMoreThan30.OrderBy(x => x.Name))
            {
                if (member.Age > 30)
                {
                    Console.WriteLine($"{member.Name} - {member.Age}");
                }
            }
        }
    }
}
