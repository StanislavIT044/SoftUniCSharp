namespace MXGP.Repositories
{
    using MXGP.Models.Riders.Contracts;
    using MXGP.Repositories.Contracts;
    using System;
    using System.Collections.Generic;

    public class RiderRepository : IRepository<IRider>
    {
        private List<IRider> riders;

        public RiderRepository()
        {
            riders = new List<IRider>();
        }

        public void Add(IRider model)
        {
            riders.Add(model);
        }

        public IReadOnlyCollection<IRider> GetAll()
        {
            return riders;
        }

        public IRider GetByName(string name)
        {
            IRider rider = null;

            foreach (var r in riders)
            {
                if (r.Name == name)
                {
                    rider = r;
                    break;
                }
            }

            if (rider == null)
            {
                throw new InvalidOperationException($"Rider {name} could not be found.");
            }

            return rider;
        }

        public bool Remove(IRider model)
        {
            return riders.Remove(model);
        }
    }
}
