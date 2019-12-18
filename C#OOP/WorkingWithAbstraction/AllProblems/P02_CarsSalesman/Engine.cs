using System.Text;

namespace Problem02CarsSalesman
{
    public class Engine
    {
        public string Model { get; set; }
        public int Power { get; set; }
        public int Displacement { get; set; }
        public string Efficiency { get; set; }

        public Engine(string model, int power)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = -1;
            this.Efficiency = "n/a";
        }

        public Engine(string model, int power, int displacement)
            :this(model, power)
        {
            this.Displacement = displacement;
            this.Efficiency = "n/a";
        }

        public Engine(string model, int power, string efficiency)
            : this(model, power)
        {
            this.Displacement = -1;
            this.Efficiency = efficiency;
        }

        public Engine(string model, int power, int displacement, string efficiency)
            : this(model, power)
        {
            this.Displacement = displacement;
            this.Efficiency = efficiency;
        }



        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"  {this.Model}:");
            sb.AppendLine($"    Power: {this.Power}");
            if (this.Displacement == -1)
            {
                sb.AppendLine("    Displacement: n/a");
            }
            else
            {
                sb.AppendLine($"    Displacement: {this.Displacement.ToString()}");
            }
            sb.AppendLine($"    Efficiency: {this.Efficiency}");

            return sb.ToString();
        }
    }

}
