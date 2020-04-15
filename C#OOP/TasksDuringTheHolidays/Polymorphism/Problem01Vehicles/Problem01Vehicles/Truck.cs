using System;

namespace Problem01Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQ, double fuelC, double tankC)
            : base(fuelQ, fuelC, tankC)
        {
            this.FuelConsumption += 1.6;
        }

        public override void Refuel(double quantity) //TODO: check
        {
            if (quantity <= 0)
            {
                Console.WriteLine($"Fuel must be a positive number");
            }
            else
            {
                if (quantity + this.FuelQuantity <= TankCapacity)
                {
                    this.FuelQuantity += quantity * 0.95;
                }
                else
                {
                    Console.WriteLine($"Cannot fit {quantity} fuel in the tank");
                }
            }
        }
    }
}
