namespace Problem6BirthdayCelebrations
{
    using System;
    using System.Collections.Generic;

    public class Engine
    {
        public void Run()
        {
            List<Passanger> passangers = new List<Passanger>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                string[] tokens = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (tokens[0] == "Citizen")
                {
                    string name = tokens[1];
                    int age = int.Parse(tokens[2]);
                    string id = tokens[3];
                    string birthdate = tokens[4];

                    Citizen citizen = new Citizen(name, age, id, birthdate);

                    passangers.Add(citizen);
                }
                else if (tokens[0] == "Pet")
                {
                    string name = tokens[1];
                    string birthdate = tokens[2];

                    Pet pet = new Pet(name, birthdate);

                    passangers.Add(pet);
                }
                
            }

            string year = Console.ReadLine();

            for (int i = 0; i < passangers.Count; i++)
            {
                string passengerBirthdate = passangers[i].Birthdate;

                if (passengerBirthdate.Substring(passengerBirthdate.Length - 4) == year)
                {
                    Console.WriteLine(passangers[i].Birthdate);
                }

            }
        }
    }
}
