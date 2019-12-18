namespace Problem02VehiclesExtension
{
    using System;

    public abstract class Vehicle
    {
        private double fuel;
        public Vehicle(double fuel, double fuelConsumprionPerKm, double tankCapacity)
        {
            if (fuel <= tankCapacity)
            {
                this.Fuel = fuel;
            }
            this.FuelConsumprionPerKm = fuelConsumprionPerKm;
            this.TankCapacity = tankCapacity;
        }
        public double Fuel 
        {
            get
            {
                return fuel;
            }
            set
            {
                //if (fuel > this.TankCapacity)
                //{
                //    fuel = 0;
                //}
                //else
                //{
                //    fuel = value;
                //}
                fuel = value;
            }
        }
        public double FuelConsumprionPerKm { get; set; }
        public double TankCapacity { get; }

        public virtual void Drive(double distance)
        {

        }

        public virtual void Refuel(double liters)
        {
            if (liters > 0)
            {
                if (liters + this.fuel > this.TankCapacity) // + this.fuel ?
                {
                    Console.WriteLine($"Cannot fit {liters} fuel in the tank");
                }
                else
                {
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
