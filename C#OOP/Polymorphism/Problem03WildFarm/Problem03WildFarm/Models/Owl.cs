namespace Problem03WildFarm.Models
{
    using System;

    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }

        public override void AskForFood()
        {
            Console.WriteLine("Hoot Hoot");
        }

        public override void Eat(string typeOfFood, int quantity)
        {
            if (typeOfFood == "Meat")
            {
                base.Eat(typeOfFood, quantity);

                this.Weight += quantity * 0.25;
            }
            else
            {
                Console.WriteLine($"Owl does not eat {typeOfFood}!");
            }

        }

    }
}
