namespace MXGP.Repositories
{
    using MXGP.Models.Races.Contracts;
    using MXGP.Repositories.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class RaceRepository : IRepository<IRace>
    {
        private List<IRace> races;

        public RaceRepository()
        {
            races = new List<IRace>();
        }

        public void Add(IRace model)
        {
            foreach (var race in races)
            {
                if (model.Name == race.Name)
                {
                    throw new InvalidOperationException($"Race {race.Name} is already created.");
                }
            }

            races.Add(model);
        }

        public IReadOnlyCollection<IRace> GetAll()
        {
            return races;
        }

        public IRace GetByName(string name)
        {
            IRace race = null;

            foreach (var r in races)
            {
                if (r.Name == name)
                {
                    race = r;
                    break;
                }
            }

            if (race == null)
            {
                throw new InvalidOperationException($"Race {name} could not be found.");
            }

            return race;
        }

        public bool Remove(IRace model)
        {
            return races.Remove(model);
        }
    }
}
