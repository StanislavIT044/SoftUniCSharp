namespace SpaceStation.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Contracts;
    using SpaceStation.Models.Astronauts.Contracts;

    public class AstronautRepository : IRepository<IAstronaut>
    {
        private IList<IAstronaut> astronauts;

        public AstronautRepository()
        {
            this.astronauts = new List<IAstronaut>();
        }

        public IReadOnlyCollection<IAstronaut> Models  => this.astronauts.ToList();

        public void Add(IAstronaut model) => this.astronauts.Add(model);

        public IAstronaut FindByName(string name) => this.astronauts.FirstOrDefault(x => x.Name == name);

        public bool Remove(IAstronaut model)
        {
            bool isRemoveable = this.astronauts.Remove(model);
            return isRemoveable;
        }
    }
}
