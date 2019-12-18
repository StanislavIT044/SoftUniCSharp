namespace Problem7FoodShortage
{
    public abstract class Person : IBayer
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name { get; }

        public int Age { get; }
        public int Food { get; set; }

        public void BuyFood()
        {
        }
    }
}
