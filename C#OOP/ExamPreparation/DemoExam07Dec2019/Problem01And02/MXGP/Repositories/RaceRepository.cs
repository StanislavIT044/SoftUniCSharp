namespace MXGP.Repositories
{
    using MXGP.Models.Races.Contracts;
    using MXGP.Repositories.Contracts;
    using System.Collections.Generic;

    public class RaceRepository : IRepository<IRace>
    {
        private List<IRace> races;

        public RaceRepository()
        {
            races = new List<IRace>();
        }

        public void Add(IRace model)
        {
            races.Add(model);
        }

        public IReadOnlyCollection<IRace> GetAll()
        {
            return races;
        }

        public IRace GetByName(string name)
        {
            foreach (var race in races)
            {
                if (race.Name == name)
                {
                    return race;
                }
            }

            return null;
        }

        public bool Remove(IRace model)
        {
            return races.Remove(model);
        }
    }
}
