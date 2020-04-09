using System;
using System.Collections.Generic;
using System.Linq;

namespace Animals
{
    public class StartUp
    {
        public static void Main()
        {
            List<Animal> animals = new List<Animal>();

            string command = string.Empty;

            while (command != "Beast!")
            {
                command = Console.ReadLine();

                if (command == "Beast!")
                {
                    break;
                }

                List<string> tokens = Console.ReadLine().Split().ToList();

                Animal animal = null;

                try
                {
                    if (command == "Dog")
                    {
                        animal = new Dog(tokens[0], int.Parse(tokens[1]), tokens[2]);
                    }
                    else if (command == "Frog")
                    {
                        animal = new Frog(tokens[0], int.Parse(tokens[1]), tokens[2]);
                    }
                    else if (command == "Cat")
                    {
                        animal = new Cat(tokens[0], int.Parse(tokens[1]), tokens[2]);
                    }
                    else if (command == "Tomcat" || command == "Kitten")
                    {
                        Cat cat;

                        if (tokens[2] == "Male")
                        {
                            animal = new Tomcat(tokens[0], int.Parse(tokens[1]), tokens[2]);
                        }
                        else
                        {
                            animal = new Kitten(tokens[0], int.Parse(tokens[1]), tokens[2]);
                        }
                    }

                    animals.Add(animal);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }
    }
}
