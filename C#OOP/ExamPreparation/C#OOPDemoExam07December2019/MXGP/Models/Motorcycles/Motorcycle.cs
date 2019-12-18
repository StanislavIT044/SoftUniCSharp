namespace MXGP.Models.Motorcycles
{
    using MXGP.Models.Motorcycles.Contracts;
    using System;

    public abstract class Motorcycle : IMotorcycle
    {
        private string model;

        protected Motorcycle(string model, int horsePower, double cubicCentimeters)
        {
            this.Model = model;
            this.HorsePower = horsePower;
            this.CubicCentimeters = cubicCentimeters;
        }
        
        public string Model 
        {
            get { return model; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 4)
                {
                    throw new ArgumentException($"Model {value} cannot be less than 4 symbols.");
                }

                model = value;
            }
        }

        public abstract int HorsePower { get; protected set; }
       // {
       //     get { return horsePower; }
       //     protected set
       //     {
       //         if (value > maxHP || value < minHP)
       //         {
       //             throw new ArgumentException($"Invalid horse power: {value}.");
       //         }
       //
       //         horsePower = value;
       //     }
       // }

        public double CubicCentimeters { get; protected set; }

        public double CalculateRacePoints(int laps)
        {
            double points = this.CubicCentimeters / this.HorsePower * laps;
           
            return points;
        }
    }
}
