namespace Problem02VehiclesExtension
{
    using System;

    public class Car : Vehicle
    {
        public Car(double fuel, double fuelConsumptionPerKm, double tankCapacity)
            : base(fuel, fuelConsumptionPerKm, tankCapacity)
        {
        }

        public override void Drive(double distance)
        {
            if (this.Fuel >= this.FuelConsumprionPerKm * distance)
            {
                this.Fuel -= this.FuelConsumprionPerKm * distance;

                Console.WriteLine($"Car travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"Car needs refueling");
            }
        }
    }
}
