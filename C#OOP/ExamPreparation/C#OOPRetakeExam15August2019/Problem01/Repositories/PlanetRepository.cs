namespace SpaceStation.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Contracts;
    using SpaceStation.Models.Astronauts.Contracts;
    using SpaceStation.Models.Planets;

    public class PlanetRepository : IRepository<IPlanet>
    {
        private IList<IPlanet> planets;

        public PlanetRepository()
        {
            this.planets = new List<IPlanet>();
        }

        public IReadOnlyCollection<IPlanet> Models => this.planets.ToList();

        public void Add(IPlanet model) => this.planets.Add(model);

        public IPlanet FindByName(string name) => this.planets.FirstOrDefault(x => x.Name == name);

        public bool Remove(IPlanet model)
        {
            bool isRemoveable = this.planets.Remove(model);
            return isRemoveable;
        }
    }
}
