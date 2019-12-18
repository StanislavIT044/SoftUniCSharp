using System;
using System.Collections.Generic;
using System.Text;

namespace Problem8CarSalesman
{
    public class Car
    {
        public string Model { get; set; }

        public Engine Engine { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }

        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
        }

        public Car(string model, Engine engine, int weight)
            : this(model, engine)
        {
            this.Weight = weight;
        }

        public Car(string model, Engine engine, string color)
            : this(model, engine)
        {
            this.Color = color;
        }

        public Car(string model, Engine engine, int weight, string color)
            : this(model, engine)
        {
            this.Weight = weight;
            this.Color = color;
        }

        public override string ToString()
        {
            StringBuilder print = new StringBuilder();

            print.AppendLine($"{Model}:");
            print.AppendLine($"  {Engine.Model}:");
            print.AppendLine($"    Power: {Engine.Power}");
            if (Engine.Displacement == 0)
            {
                print.AppendLine($"    Displacement: n/a");
            }
            else
            {
                print.AppendLine($"    Displacement: {Engine.Displacement}");
            }
            if (Engine.Efficiency == null)
            {
                print.AppendLine($"    Efficiency: n/a");
            }
            else
            {
                print.AppendLine($"    Efficiency: {Engine.Efficiency}");
            }
            if (Weight == 0)
            {
                print.AppendLine($"  Weight: n/a");
            }
            else
            {
                print.AppendLine($"  Weight: {Weight}");
            }
            if (Color == null)
            {
                print.AppendLine($"  Color: n/a");
            }
            else
            {
                print.AppendLine($"  Color: {Color}");
            }

            return print.ToString();
        }
    }
}
