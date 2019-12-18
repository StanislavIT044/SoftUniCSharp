using System;
using System.Collections.Generic;
using System.Text;

namespace Problem04NeedForSpeed
{
    public class Car : Vehicle
    {
        public Car(int horsePower, double fuel)
            : base(horsePower, fuel)
        {
            this.DefaultFuelConsumption = 3;
            this.FuelConsumption = this.DefaultFuelConsumption;
        }
    }
}
