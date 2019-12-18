namespace SpaceStation.Models.Astronauts
{
    using System;
    using Contracts;
    using SpaceStation.Models.Bags;

    public abstract class Astronaut : IAstronaut
    {
        private string name;
        private double oxygen;

        protected Astronaut(string name, double oxygen)
        {
            this.Name = name;
            this.Oxygen = oxygen;
            this.Bag = new Backpack();
        }

        protected Astronaut(string name)
        {
            this.name = name;
        }

        public string Name 
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(name), "Astronaut name cannot be null or empty.");
                }

                this.name = value;
            }
        }

        public double Oxygen 
        {
            get 
            { 
                return this.oxygen; 
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Cannot create Astronaut with negative oxygen!");
                }

                this.oxygen = value;
            }
        }

        public IBag Bag { get; }

        public bool CanBreath => this.Oxygen > 0;

        public virtual void Breath()
        {
            if (this.Oxygen - 10 >= 0)
            {
                this.Oxygen -= 10;
            }
        }
    }
}
