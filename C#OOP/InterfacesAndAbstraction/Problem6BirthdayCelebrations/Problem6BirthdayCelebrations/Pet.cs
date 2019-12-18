namespace Problem6BirthdayCelebrations
{
    public class Pet : Passanger, IPet
    {
        public Pet(string name, string birthdate)
            : base(name,birthdate)
        {
        }
        public string Name { get; }

        public string Birthdate { get; set; }
    }
}
