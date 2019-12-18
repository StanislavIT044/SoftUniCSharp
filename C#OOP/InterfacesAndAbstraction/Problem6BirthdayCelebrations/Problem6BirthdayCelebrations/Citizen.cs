namespace Problem6BirthdayCelebrations
{
    public class Citizen : Passanger, ICitizen
    {
        public Citizen(string name, int age, string id, string birthdate)
            : base (name, birthdate)
        {
            this.Age = age;
            this.Id = id;
        }
        public string Name { get; }
        public int Age { get; }
        public string Id { get; }
        public string Birthdate { get; }
    }
}
