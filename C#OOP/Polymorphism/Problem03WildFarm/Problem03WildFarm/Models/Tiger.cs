namespace Problem03WildFarm.Models
{
    using System;

    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }

        public override void AskForFood()
        {
            Console.WriteLine("ROAR!!!");
        }

        public override void Eat(string typeOfFood, int quantity)
        {
            if (typeOfFood == "Meat")
            {
                base.Eat(typeOfFood, quantity);

                this.Weight += quantity * 1;
            }
            else
            {
                Console.WriteLine($"Tiger does not eat {typeOfFood}!");
            }
        }
    }
}
