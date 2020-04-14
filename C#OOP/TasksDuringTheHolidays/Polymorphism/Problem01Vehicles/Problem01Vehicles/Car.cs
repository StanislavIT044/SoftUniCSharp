namespace Problem01Vehicles
{
    public class Car : Vehicle
    {
        public Car(double fuelQ, double fuelC) 
            : base(fuelQ, fuelC)
        {
            this.FuelConsumption += 0.9;
        }

        public override void Refuel(double quantity)
        {
            this.FuelQuantity += quantity;
        }
    }
}
