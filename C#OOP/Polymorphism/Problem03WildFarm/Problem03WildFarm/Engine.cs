namespace Problem03WildFarm
{
    using System;
    using System.Collections.Generic;
    using Models;

    public class Engine
    {
        public void Run()
        {
            List<Animal> animals = new List<Animal>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                string[] animalInfo = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string[] foodInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Animal animal;

                animal = CreateAnimal(animalInfo);

                animals.Add(animal);

                animal.AskForFood();

                string foodType = foodInfo[0];
                int foodQuantity = int.Parse(foodInfo[1]);

                animal.Eat(foodType, foodQuantity);
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }

        private static Animal CreateAnimal(string[] animalInfo)
        {
            Animal animal = null;
            if (animalInfo[0] == "Owl")
            {
                string name = animalInfo[1];
                double weight = double.Parse(animalInfo[2]);
                double wingSize = double.Parse(animalInfo[3]);

                animal = new Owl(name, weight, wingSize);
            }
            else if (animalInfo[0] == "Hen")
            {
                string name = animalInfo[1];
                double weight = double.Parse(animalInfo[2]);
                double wingSize = double.Parse(animalInfo[3]);

                animal = new Hen(name, weight, wingSize);
            }
            else if (animalInfo[0] == "Mouse")
            {
                string name = animalInfo[1];
                double weight = double.Parse(animalInfo[2]);
                string livingRegion = animalInfo[3];

                animal = new Mouse(name, weight, livingRegion);
            }

            else if (animalInfo[0] == "Dog")
            {
                string name = animalInfo[1];
                double weight = double.Parse(animalInfo[2]);
                string livingRegion = animalInfo[3];

                animal = new Dog(name, weight, livingRegion);
            }
            else if (animalInfo[0] == "Cat")
            {
                string name = animalInfo[1];
                double weight = double.Parse(animalInfo[2]);
                string livingRegion = animalInfo[3];
                string breed = animalInfo[4];

                animal = new Cat(name, weight, livingRegion, breed);
            }
            else if (animalInfo[0] == "Tiger")
            {
                string name = animalInfo[1];
                double weight = double.Parse(animalInfo[2]);
                string livingRegion = animalInfo[3];
                string breed = animalInfo[4];

                animal = new Tiger(name, weight, livingRegion, breed);
            }

            return animal;
        }
    }
}
