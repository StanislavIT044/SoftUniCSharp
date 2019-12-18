namespace MXGP.Models.Motorcycles
{
    using MXGP.Models.Motorcycles.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Motorcycle : IMotorcycle
    {
        private const int minHorsePower = 0;
        private const int maxHorsePower = 0;
        private string model;
        private int horsePower;
        private double cubicCentimeters;

        protected Motorcycle(string model, int horsePower)
        {
            this.Model = model;
            this.HorsePower = horsePower;
        }

        public string Model 
        {
            get { return model; }
            private set 
            {
                if (string.IsNullOrEmpty(value) || value.Length < 4)
                {
                    throw new ArgumentException($"Model {value} cannot be less than 4 symbols.");
                }
                else
                {
                    model = value;
                }
            }
        }

        public int HorsePower
        {
            get { return horsePower; }
            private set
            {
                if (value <= minHorsePower || value >= maxHorsePower)
                {
                    throw new ArgumentException($"Invalid horse power: {value}.");
                }
                else
                {
                    horsePower = value;
                }
            }
        }

        public double CubicCentimeters
        {
            get { return cubicCentimeters; }
            protected set { cubicCentimeters = value; }
        }

        public double CalculateRacePoints(int laps)
        {
            double racePoints = this.CubicCentimeters / this.HorsePower * laps;

            return racePoints;
        }
    }
}
