namespace Problem01Vehicles
{
    using System;

    public abstract class Vehicle
    {
        public Vehicle(double fuel, double fuelConsumprionPerKm)
        {
            this.Fuel = fuel;
            this.FuelConsumprionPerKm = fuelConsumprionPerKm;
        }
        public double Fuel { get; set; }
        public double FuelConsumprionPerKm { get; set; }

        public void Drive(double distance)
        {
            if (this.Fuel >= this.FuelConsumprionPerKm * distance)
            {
                this.Fuel -= this.FuelConsumprionPerKm * distance;

                if (this is Car)
                {
                    Console.WriteLine($"Car travelled {distance} km");
                }
                else if (this is Truck)
                {
                    Console.WriteLine($"Truck travelled {distance} km");
                }
            }
            else
            {
                if (this is Car)
                {
                    Console.WriteLine($"Car needs refueling");
                }
                else if (this is Truck)
                {
                    Console.WriteLine($"Truck needs refueling");
                }
            }
        }

        public void Refuel(double liters)
        {
            this.Fuel += liters;
        }
    }
}
