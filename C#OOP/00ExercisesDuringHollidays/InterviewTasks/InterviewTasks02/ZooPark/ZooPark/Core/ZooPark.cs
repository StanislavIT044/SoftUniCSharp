namespace ZooPark.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using global::ZooPark.Core.Animals;
    using global::ZooPark.Core.Contracts;

    public class ZooPark : IZooPark
    {
        public ZooPark()
        {

        }

        public List<Animal> animalsInZooPark = new List<Animal>();

        public void AddAnimalsInZooPark()
        {

            for (int i = 1; i <= 5; i++)
            {
                Monkey monkey = new Monkey();
                animalsInZooPark.Add(monkey);
            }

            for (int i = 1; i <= 5; i++)
            {
                Lion lion = new Lion();
                animalsInZooPark.Add(lion);
            }

            for (int i = 1; i <= 5; i++)
            {
                Elephant elephant = new Elephant();
                animalsInZooPark.Add(elephant);
            }
        }

        public void StarvationOfAnimals()
        {
            foreach (var animal in animalsInZooPark)
            {
                animal.Starvation();
                animal.Dying();
            }
        }

        public void FeedingAnimals()
        {
            Random random = new Random();

            int numForFeedingMokeys = random.Next(5, 25);
            foreach (var monkey in animalsInZooPark.Where(x => x is Monkey))
            {
                monkey.Feeding(numForFeedingMokeys);
            }

            int numForFeedingLions = random.Next(5, 25);
            foreach (var lion in animalsInZooPark.Where(x => x is Lion))
            {
                lion.Feeding(numForFeedingLions);
            }

            int numForFeedingElephants = random.Next(5, 25);
            foreach (var elephant in animalsInZooPark.Where(x => x is Elephant))
            {
                elephant.Feeding(numForFeedingElephants);
            }
        }

        public int CountOfDeadAnimals()
        {
            int deadAnimals = animalsInZooPark.Where(x => x.IsDead == true).Count();
            return deadAnimals;
        }
    }
}
