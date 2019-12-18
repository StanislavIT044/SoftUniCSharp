namespace MXGP.Models.Races
{
    using MXGP.Models.Motorcycles.Contracts;
    using MXGP.Models.Riders.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Rider : IRider
    {
        private string name;

        public Rider(string name)
        {
            this.Name = name;
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

        public IMotorcycle Motorcycle { get; private set; }

        public int NumberOfWins { get; private set; }

        public bool CanParticipate { get; private set; }

        public void AddMotorcycle(IMotorcycle motorcycle)
        {
            if (motorcycle == null)
            {
                throw new ArgumentNullException("Motorcycle cannot be null.");
            }
            else
            {
                this.Motorcycle = motorcycle;

                CanParticipate = true;
            }
        }

        public void WinRace()
        {
            this.NumberOfWins++;
        }
    }
}
