namespace Problem01Vehicles
{
    public class Car : Vehicle
    {
        public Car(double fuelQ, double fuelC, double tankC) 
            : base(fuelQ, fuelC, tankC)
        {
            this.FuelConsumption += 0.9;
        }
    }
}
