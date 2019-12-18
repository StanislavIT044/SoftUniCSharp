namespace Problem03WildFarm.Models
{
    using System;

    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        public override void AskForFood()
        {
            Console.WriteLine("Squeak");
        }

        public override void Eat(string typeOfFood, int quantity)
        {
            if (typeOfFood == "Vegetable" || typeOfFood == "Fruit")
            {
                base.Eat(typeOfFood, quantity);

                this.Weight += quantity * 0.1;
            }
            else
            {
                Console.WriteLine($"Mouse does not eat {typeOfFood}!");
            }
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
