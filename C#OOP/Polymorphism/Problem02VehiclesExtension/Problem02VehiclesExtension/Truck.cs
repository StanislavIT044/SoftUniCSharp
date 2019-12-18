namespace Problem02VehiclesExtension
{
    using System;

    public class Truck : Vehicle
    {
        public Truck(double fuel, double fuelConsumptionPerKm, double tankCapacity)
               : base(fuel, fuelConsumptionPerKm, tankCapacity)
        {
        }

        public override void Drive(double distance)
        {
            if (this.Fuel >= this.FuelConsumprionPerKm * distance)
            {
                this.Fuel -= this.FuelConsumprionPerKm * distance;

                Console.WriteLine($"Truck travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"Truck needs refueling");
            }
        }

        public override void Refuel(double liters)
        {
            if (liters > 0)
            {
                if (liters + base.Fuel > this.TankCapacity) // + this.fuel ?
                {
                    Console.WriteLine($"Cannot fit {liters} fuel in the tank");
                }
                else
                {
                    liters -= liters * 0.05;
                    this.Fuel += liters;
                }
            }
            else
            {
                Console.WriteLine("Fuel must be a positive number");
            }
        }
    }
}
