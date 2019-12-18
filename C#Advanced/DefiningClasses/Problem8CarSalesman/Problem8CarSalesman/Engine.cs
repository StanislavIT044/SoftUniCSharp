using System;
using System.Collections.Generic;
using System.Text;

namespace Problem8CarSalesman
{
    public class Engine
    {
        public string Model { get; set; }
        public int Power { get; set; }
        public int Displacement { get; set; }
        public string Efficiency { get; set; }

        public Engine(string engineModel, int power)
        {
            this.Model = engineModel;
            this.Power = power;
        }

        public Engine(string engineModel, int power, int displacement)
            : this(engineModel, power)
        {
            this.Displacement = displacement;
        }

        public Engine(string engineModel, int power, string efficiency)
            : this(engineModel, power)
        {
            this.Efficiency = efficiency;
        }
        public Engine(string engineModel, int power, int displacement, string efficiency)
            : this(engineModel, power)
        {
           
            this.Displacement = displacement;
            this.Efficiency = efficiency;
        }
    }
}
