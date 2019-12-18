namespace Problem7FoodShortage
{
    public class Rabel : Person, IBayer
    {
        public Rabel(string name, int age, string group) 
            : base(name, age)
        {
            this.Group = group;
        }

        public string Group { get; }

        public int Food { get; set; }

        public void BuyFood()
        {
            this.Food += 5;
        }
    }
}
