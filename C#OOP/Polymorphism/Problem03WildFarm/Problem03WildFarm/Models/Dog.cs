namespace Problem03WildFarm.Models
{
    using System;

    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        public override void AskForFood()
        {
            Console.WriteLine("Woof!");
        }

        public override void Eat(string typeOfFood, int quantity)
        {
            if (typeOfFood == "Meat")
            {
                base.Eat(typeOfFood, quantity);

                this.Weight += quantity * 0.4;
            }
            else
            {
                Console.WriteLine($"Dog does not eat {typeOfFood}!");
            }
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
