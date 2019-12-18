namespace Problem02VehiclesExtension
{
    using System;

    public class Bus : Vehicle
    {
        public Bus(double fuel, double fuelConsumptionPerKm, double tankCapacity)
               : base(fuel, fuelConsumptionPerKm, tankCapacity)
        {
        }

        public override void Drive(double distance)
        {
            if (this.Fuel >= this.FuelConsumprionPerKm * distance)
            {
                this.Fuel -= this.FuelConsumprionPerKm * distance;

                Console.WriteLine($"Bus travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"Bus needs refueling");
            }
        }
    }
}
