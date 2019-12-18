namespace MXGP.Models.Motorcycles
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class PowerMotorcycle : Motorcycle
    {
        private const int minHorsePower = 70;
        private const int maxHorsePower = 100;

        public PowerMotorcycle(string model, int horsePower) 
            : base(model, horsePower)
        {
            this.CubicCentimeters = 450;
        }
    }
}
