using System;
using System.Collections.Generic;
using System.Text;

namespace Problem04NeedForSpeed
{
    public class RaceMotorcycle : Motorcycle
    {
        public RaceMotorcycle(int horsePower, double fuel)
            : base(horsePower, fuel)
        {
            this.DefaultFuelConsumption = 8;
            this.FuelConsumption = this.DefaultFuelConsumption;
        }
    }
}
