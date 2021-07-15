namespace ZooPark.Core.Animals
{
    using System;

    using Core.Contracts;

    public abstract class Animal : IAnimal
    {
        public Animal()
        {
            this.HealtPoints = 100;
            this.IsDead = false;
        }

        public int HealtPoints { get; set; }

        public int DeadPoints { get; set; }

        public bool IsDead { get; set; }

        public virtual void Starvation()
        {
            if (this.IsDead == false)
            {
                Random random = new Random();
                int points = random.Next(0, 20);

                this.HealtPoints -= points;
            }
        }

        public void Feeding(int points)
        {
            if (this.IsDead == false)
            {
                this.HealtPoints += points;
            }
        }

        public void Dying()
        {
            if (this.HealtPoints < this.DeadPoints)
            {
                this.IsDead = true;
            }
        }
    }
}
