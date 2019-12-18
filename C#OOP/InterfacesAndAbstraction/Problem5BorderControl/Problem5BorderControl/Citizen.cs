namespace Problem5BorderControl
{
    public class Citizen : Passanger, ICitizen
    {
        public Citizen(string name, int age, string id)
            : base(id)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name { get; }
        public int Age { get; }
        public string Id { get; }
    }
}
