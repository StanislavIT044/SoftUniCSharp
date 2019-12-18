namespace AquaShop.Models.Fish
{
    using AquaShop.Models.Fish.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Fish : IFish
    {
        private string name;
        private string species;
        private int size;
        private decimal price;

        protected Fish(string name, string species, decimal price)
        {
            this.Name = name;
            this.Species = species;
            this.Price = price;
        }

        public string Name
        {
            get { return name; }
            protected set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Fish name cannot be null or empty.");
                }

                name = value;
            }
        }

        public string Species
        {
            get { return species; }
            protected set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Fish species cannot be null or empty.");
                }

                species = value;
            }
        }

        public int Size
        {
            get{ return size; }
            protected set
            {
                size = value;
            }
        }
        

        public decimal Price
        {
            get { return price; }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Fish price cannot be below or equal to 0.");
                }

                price = value;
            }
        }

        public abstract void Eat();

        public override string ToString()
        {
            return $"{this.Name}";
        }
    }
}
