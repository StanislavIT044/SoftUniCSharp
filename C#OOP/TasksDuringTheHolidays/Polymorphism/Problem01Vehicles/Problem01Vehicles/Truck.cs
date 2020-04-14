namespace Problem01Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQ, double fuelC) 
            : base(fuelQ, fuelC)
        {
            this.FuelConsumption += 1.6;
        }

        public override void Refuel(double quantity)
        {
            this.FuelQuantity += quantity * 0.95;
        }
    }
}
