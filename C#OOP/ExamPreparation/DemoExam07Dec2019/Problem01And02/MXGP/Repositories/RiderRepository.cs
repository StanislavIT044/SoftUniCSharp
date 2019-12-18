using MXGP.Models.Races;
using MXGP.Models.Riders.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MXGP.Repositories.Contracts
{
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

        public bool Remove(IRider model)
        {
            return riders.Remove(model);
        }

        public IReadOnlyCollection<IRider> GetAll()
        {
            return riders;
        }

        public IRider GetByName(string name)
        {
            foreach (var rider in riders)
            {
                if (rider.Name == name)
                {
                    return rider;
                }
            }

            return null;
        }
    }
}
