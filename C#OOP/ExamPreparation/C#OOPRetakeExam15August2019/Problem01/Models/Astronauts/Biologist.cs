namespace SpaceStation.Models.Astronauts
{
    public class Biologist : Astronaut
    {
        public Biologist(string name) 
            : base(name)
        {
            this.Oxygen = 70;
        }

        public override void Breath()
        {
            if (CanBreath)
            {
                this.Oxygen -= 5;
            }
        }
    }
}
