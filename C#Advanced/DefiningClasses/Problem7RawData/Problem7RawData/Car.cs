using System;
using System.Collections.Generic;
using System.Text;

namespace Problem7RawData
{
    public class Car
    {
        public string carModel;
        public Engine engine;
        public Cargo cargo;
        public List<Tire> tires;

        public Car(string carModel, Engine engine, Cargo cargo, List<Tire> tires)
        {
            this.carModel = carModel;
            this.engine = engine;
            this.cargo = cargo;
            this.tires = tires;
        }
    }
}
