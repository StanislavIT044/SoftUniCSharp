using SpaceStation.Models.Planets;
using SpaceStation.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStation.Repositories
{
    public class PlanetRepository : IRepository<IPlanet>
    {
        private IList<IPlanet> planets;

        public PlanetRepository()
        {
            planets = new List<IPlanet>();
        }

        public IReadOnlyCollection<IPlanet> Models => planets.ToList();

        public void Add(IPlanet model)
        {
            var obj = this.FindByName(model.Name);
            bool canBeAdded = true;

            if (obj != null)
            {
                canBeAdded = false;
            }

            if (canBeAdded)
            {
                planets.Add(model);
            }
        }

        public IPlanet FindByName(string name) => this.planets.FirstOrDefault(x => x.Name == name);

        public bool Remove(IPlanet model) => this.planets.Remove(model);
    }
}
