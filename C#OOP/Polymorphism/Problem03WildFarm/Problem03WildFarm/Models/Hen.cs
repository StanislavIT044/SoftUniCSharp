namespace Problem03WildFarm.Models
{
    using System;

    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        public override void AskForFood()
        {
            Console.WriteLine("Cluck");
        }

        public override void Eat(string typeOfFood, int quantity)
        {
            base.Eat(typeOfFood, quantity);

            this.Weight += quantity * 0.35;
        }
    }
}
