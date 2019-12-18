namespace SpaceStation.Models.Planets
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Planet : IPlanet
    {
        private string name;
        private IList<string> items;

        public Planet(string name, string[] items)
        {
            this.Name = name;
            this.items = items.ToList();
        }

        public string Name 
        {
            get 
            { 
                return name; 
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(name), "Invalid name!");
                }

                name = value;
            } 
        }

        public ICollection<string> Items { get => items; }
    }
}
