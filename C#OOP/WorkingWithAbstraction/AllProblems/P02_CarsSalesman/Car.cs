using System.Linq;
using System.Text;

namespace Problem02CarsSalesman
{
    public class Car
    {
        public Car(string model)
        {
            Model = model;
        } 
        public Car(string model, Engine engine)
            :this(model)
        {
            this.Engine = engine;
            this.Weight = -1;
            this.Color = "n/a";
        }

        public Car(string model, Engine engine, int weight)
            : this(model, engine)
        {
            this.Weight = weight;
            this.Color = "n/a";
        }

        public Car(string model, Engine engine, string color)
            : this(model, engine)
        {
            this.Weight = -1;
            this.Color = color;
        }

        public Car(string model, Engine engine, int weight, string color)
            : this(model, engine, weight)
        {
            this.Color = color;
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Model}:");
            sb.Append(this.Engine.ToString());
            if (this.Weight == -1)
            {
                sb.AppendLine("  Weight: n/a");
            }
            else
            {
                sb.AppendLine($"  Weight: {this.Weight.ToString()}");
            }
            sb.AppendFormat($"  Color: {this.Color}");

            return sb.ToString();
        }
    }

}
