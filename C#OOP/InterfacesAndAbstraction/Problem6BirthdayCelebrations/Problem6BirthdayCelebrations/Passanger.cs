namespace Problem6BirthdayCelebrations
{
    public abstract class Passanger
    {
        public Passanger(string name, string birthdate)
        {
            this.Name = name;
            this.Birthdate = birthdate;
        }

        public string Name { get; }

        public string Birthdate { get; }
    }
}
