namespace MXGP.Repositories
{
    using MXGP.Models.Motorcycles;
    using MXGP.Models.Motorcycles.Contracts;
    using MXGP.Repositories.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class MotorcycleRepository : IRepository<IMotorcycle>
    {
        private List<IMotorcycle> motorcycles;

        public MotorcycleRepository()
        {
            motorcycles = new List<IMotorcycle>();
        }
        public void Add(IMotorcycle model)
        {
            motorcycles.Add(model);
        }

        public IReadOnlyCollection<IMotorcycle> GetAll()
        {
            return motorcycles;
        }

        public IMotorcycle GetByName(string name)
        {
            foreach (var motorcycle in motorcycles)
            {
                if (motorcycle.Model == name)
                {
                    return motorcycle;
                }
            }

            return null;
        }

        public bool Remove(IMotorcycle model)
        {
            return motorcycles.Remove(model);
        }
    }
}
