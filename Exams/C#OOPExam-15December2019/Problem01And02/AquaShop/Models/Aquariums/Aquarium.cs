namespace AquaShop.Models.Aquariums
{
    using AquaShop.Models.Aquariums.Contracts;
    using AquaShop.Models.Decorations.Contracts;
    using AquaShop.Models.Fish.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public abstract class Aquarium : IAquarium
    {
        private string name;
        private int capacity;
        private int comfort;
        private List<IDecoration> decorations;
        private List<IFish> fishes;

        protected Aquarium(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.decorations = new List<IDecoration>();
            this.fishes = new List<IFish>();
        }

        public string Name
        {
            get { return name; }
            protected set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Aquarium name cannot be null or empty.");
                }

                name = value;
            }
        }

        public int Capacity
        {
            get { return capacity; }
            protected set
            {
                capacity = value;
            }
        }

        public int Comfort
        {
            get
            {
                return comfort;
            }
            private set
            {
                int n = 0;
                foreach (var d in this.Decorations)
                {
                    n += d.Comfort;
                }

                comfort = n;
            }
        }


        public ICollection<IDecoration> Decorations => decorations;

        public ICollection<IFish> Fish => fishes;

        public void AddDecoration(IDecoration decoration)
        {
            this.decorations.Add(decoration);
        }

        public void AddFish(IFish fish)
        {
            if (this.Capacity >= this.Fish.Count + 1) // TODO: add Check
            {
                Fish.Add(fish);
            }
            else
            {
                throw new InvalidOperationException("Not enough capacity.");
            }
        }

        public void Feed()
        {
            foreach (var f in this.fishes)
            {
                f.Eat();
            }
        }

        public string GetInfo()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.Name} ({this.GetType().Name}):");

            if (this.Fish.Count == 0)
            {
                sb.AppendLine("none");
            }
            else
            {
                string str = "Fish: ";
                foreach (var f in this.Fish)
                {
                    str += "{";
                    str += $"{f.ToString()}";
                    str += "}";
                }
                sb.AppendLine(str);
            }

            sb.AppendLine($"Decorations: {Decorations.Count}");

            sb.AppendLine($"Comfort: {this.Comfort}");

            return sb.ToString().TrimEnd();
        }

        public bool RemoveFish(IFish fish)
        {
            return fishes.Remove(fish);
        }
    }
}
