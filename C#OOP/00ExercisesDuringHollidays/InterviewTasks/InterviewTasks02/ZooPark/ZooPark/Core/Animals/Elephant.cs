namespace ZooPark.Core.Animals
{
    public class Elephant : Animal
    {
        public Elephant()
        {
            this.CanWalk = true;
        }

        public bool CanWalk { get; set; }

        public override void Starvation()
        {
            if (this.CanWalk == true)
            {
                base.Starvation();
            }
            else
            {
                this.Dying();
            }
        }

        private void DisableWalk()
        {
            if (this.HealtPoints < 70)
            {
                this.CanWalk = false;
            }
        }
    }
}
