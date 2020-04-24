using System.Collections.Generic;
using System.Linq;
using SpaceStation.Models.Astronauts;
using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Repositories.Contracts;

namespace SpaceStation.Repositories
{
    public class AstronautRepository : IRepository<IAstronaut>
    {
        private IList<IAstronaut> astronauts;

        public AstronautRepository()
        {
            astronauts = new List<IAstronaut>();
        }

        public void Add(IAstronaut model)
        {
            var obj = this.FindByName(model.Name);
            bool canBeAdded = true;

            if (obj != null)
            {
                canBeAdded = false;
            }

            if (canBeAdded)
            {
                astronauts.Add(model);
            }
        }

        public IReadOnlyCollection<IAstronaut> Models { get => astronauts.ToList(); }

        public IAstronaut FindByName(string name) => this.astronauts.FirstOrDefault(x => x.Name == name);

        public bool Remove(IAstronaut model)
        {
            return this.astronauts.Remove(model);
        }
    }
}
