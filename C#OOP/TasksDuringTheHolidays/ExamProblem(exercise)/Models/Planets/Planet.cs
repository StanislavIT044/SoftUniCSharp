using System;
using System.Collections.Generic;
using System.Linq;

namespace SpaceStation.Models.Planets
{
    public class Planet : IPlanet
    {
        private string name;
        private IList<string> items;

        public Planet(string name, string[] items)
        {
            this.Name = name;
            this.items = items.ToList();
        }

        public ICollection<string> Items { get => items; }

        public string Name
        {
            get 
            {
                return name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Invalid name!");
                }
            }
        }
    }
}
