namespace Problem03WildFarm.Models
{
    using System;

    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }

        public override void AskForFood()
        {
            Console.WriteLine("Meow");
        }

        public override void Eat(string typeOfFood, int quantity)
        {
            base.Eat(typeOfFood, quantity);

            if (typeOfFood == "Vegetable" || typeOfFood == "Meat")
            {
                this.Weight += quantity * 0.3;
            }
            else
            {
                Console.WriteLine($"Cat does not eat {typeOfFood}!");
            }
        }
    }
}
