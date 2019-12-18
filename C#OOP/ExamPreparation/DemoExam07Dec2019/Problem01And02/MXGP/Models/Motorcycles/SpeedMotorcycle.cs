namespace MXGP.Models.Motorcycles
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class SpeedMotorcycle : Motorcycle
    {
        private const int minHorsePower = 50;
        private const int maxHorsePower = 69;

        public SpeedMotorcycle(string model, int horsePower) 
            : base(model, horsePower)
        {
            this.CubicCentimeters = 125;
        }
    }
}
