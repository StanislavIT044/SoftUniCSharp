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
            IMotorcycle motorcycle = null;

            foreach (var m in motorcycles)
            {
                if (m.Model  == name)
                {
                    motorcycle = m;
                    break;
                }
            }

            if (motorcycle == null)
            {
                throw new InvalidOperationException($"Motorcycle {name} could not be found.");
            }

            return motorcycle;
        }

        public bool Remove(IMotorcycle model)
        {
            return motorcycles.Remove(model);
        }
    }
}
