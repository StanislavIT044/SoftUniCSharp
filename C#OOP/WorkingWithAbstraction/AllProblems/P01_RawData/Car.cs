using System.Collections.Generic;

namespace Problem01RawData
{
    public class Car
    {
        public Car(string model ,Engine engine, int cargoWeight, string cargoType, List<Tire> tires)
        {
            this.Model = model;
            this.Engine = engine;
            this.CargoWeight = cargoWeight;
            this.CargoType = cargoType;
            this.Tires = tires;
        }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int CargoWeight { get; set; }
        public string CargoType { get; set; }

        public List<Tire> Tires;
    }
}
