namespace Problem01Vehicles
{
    public class Vehicle
    {
        public Vehicle(double fuelQ, double fuelC)
        {
            this.FuelQuantity = fuelQ;
            this.FuelConsumption = fuelC;
        }

        public double FuelQuantity { get; set; }

        public double FuelConsumption { get; set; }

        public virtual string Drive()
        {
            return null;
        }

        public virtual void Refuel(double quantity)
        {
            
        }
    }
}
