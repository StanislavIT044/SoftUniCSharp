namespace MXGP.Models.Races
{
    using MXGP.Models.Races.Contracts;
    using MXGP.Models.Riders.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Race : IRace
    {
        private string name;
        private int laps;
        private List<IRider> riders;

        public Race(int laps)
        {
            this.Laps = laps;
            riders = new List<IRider>();
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 5)
                {
                    throw new ArgumentException($"Name {value} cannot be less than 5 symbols.");
                }
                else
                {
                    name = value;
                }
            }
        }
        public int Laps
        {
            get { return laps; }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Laps cannot be less than 1.");
                }
            }
        }

        public IReadOnlyCollection<IRider> Riders => riders;

        public void AddRider(IRider rider)
        {
            if (rider == null)
            {
                throw new ArgumentNullException("Rider cannot be null.");
            }
            else
            {
                this.riders.Add(rider);

                if (rider.CanParticipate == false)
                {
                    throw new ArgumentException($"Rider {rider.Name} could not participate in race.");
                }

                foreach (var r in riders)
                {
                    if (r.Name == rider.Name)
                    {
                        throw new ArgumentNullException($"Rider {rider.Name} is already added in {this.Name} race.");
                    }
                }
            }
        }
    }
}
