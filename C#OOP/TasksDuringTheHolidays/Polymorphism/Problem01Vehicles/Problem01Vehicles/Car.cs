namespace Problem01Vehicles
{
    public class Car : Vehicle
    {
        public Car(double fuelQ, double fuelC) 
            : base(fuelQ, fuelC)
        {
        }

        public override string Drive()
        {
            return base.Drive();
        }

        public override void Refuel(double quantity)
        {
            this.FuelQuantity += quantity;
        }
    }
}
