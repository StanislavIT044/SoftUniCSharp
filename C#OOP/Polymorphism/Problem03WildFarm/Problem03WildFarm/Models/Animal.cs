namespace Problem03WildFarm.Models
{
    public abstract class Animal
    {
        public Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        public string Name { get; set; }

        public double Weight { get; set; }

        public int FoodEaten { get; set; }

        public virtual void AskForFood()
        {
        }

        public virtual void Eat(string typeOfFood, int quantity)
        {
            this.FoodEaten += quantity;
        }
    }
}
