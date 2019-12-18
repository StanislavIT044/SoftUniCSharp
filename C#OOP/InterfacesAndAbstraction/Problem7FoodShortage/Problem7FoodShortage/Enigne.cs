namespace Problem7FoodShortage
{
    using System;
    using System.Collections.Generic;

    public class Enigne
    {
        public void Run()
        {
            int n = int.Parse(Console.ReadLine());

            List<Person> persons = new List<Person>();
            int totalAmountOfPurchaseFood = 0;

            for (int i = 0; i < n; i++)
            {
                string[] personInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (personInfo.Length == 4)
                {
                    string name = personInfo[0];
                    int age = int.Parse(personInfo[1]);
                    string id = personInfo[2];
                    string birthdate = personInfo[3];

                    Person person = new Citizen(name, age, id, birthdate);

                    persons = AddPerson(persons, person);
                }
                else if (personInfo.Length == 3)
                {
                    string name = personInfo[0];
                    int age = int.Parse(personInfo[1]);
                    string group = personInfo[2];

                    Person person = new Rabel(name, age, group);

                    persons = AddPerson(persons, person);
                }
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }
                else
                {
                    foreach (var person in persons)
                    {
                        if (person.Name == command)
                        {
                            person.BuyFood();
                           
                            if (person is Rabel)
                            {
                                totalAmountOfPurchaseFood += 5;
                            }
                            else if (person is Citizen)
                            {
                                totalAmountOfPurchaseFood += 10;
                            }
                        }
                    }
                }
            }

            Console.WriteLine(totalAmountOfPurchaseFood);
        }
        private List<Person> AddPerson(List<Person> persons, Person person)
        {
            bool isNotCountinesCurrentPerson = true;

            foreach (var p in persons)
            {
                if (p.Name == person.Name)
                {
                    isNotCountinesCurrentPerson = false;
                }
            }

            if (isNotCountinesCurrentPerson)
            {
                persons.Add(person);
            }

            return persons;
        }
    }
}
