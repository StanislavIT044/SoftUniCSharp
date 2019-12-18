namespace Problem7FoodShortage
{
    public class Citizen : Person, IBayer
    {
        public Citizen(string name, int age, string id, string birthate)
            : base(name, age)
        {
            this.Id = id;
            this.Birthdate = birthate;
        }
        public string Name { get; }
        public int Age { get; }
        public string Id { get; }
        public string Birthdate { get; }
        public int Food { get; set; }

        public void BuyFood()
        {
            this.Food += 10;
        }
    }
}
