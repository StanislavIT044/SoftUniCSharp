using System;

namespace Problem01Vehicles
{
    public class Vehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;
        private double tankCapacity;

        public Vehicle(double fuelQ, double fuelC, double tankC)
        {
            this.TankCapacity = tankC;
            this.FuelQuantity = fuelQ;
            this.FuelConsumption = fuelC;            
        }

        public double FuelQuantity 
        {
            get
            {
                return this.fuelQuantity;
            }
            set
            {
                if (value > this.TankCapacity)
                {
                    this.fuelQuantity = 0;
                }
                else
                {
                    this.fuelQuantity = value;
                }
            } 
        }

        public double FuelConsumption { get; set; }

        public double TankCapacity { get; set; }

        public virtual string Drive(double distance)
        {
            double currentConsumption = distance * this.FuelConsumption;
            
            if (this.FuelQuantity >= currentConsumption)
            {
                this.FuelQuantity -= currentConsumption;

                return $"{this.GetType().Name} travelled {distance} km";
            }
            else
            {
                return $"{this.GetType().Name} needs refueling";
            }
        }

        internal virtual string DriveWithPassangers(double disOrLit)
        {
            throw new NotImplementedException();
        }

        public virtual void Refuel(double quantity)
        {
            if (quantity <= 0)
            {
                Console.WriteLine($"Fuel must be a positive number");
            }
            else
            {
                if (quantity + this.FuelQuantity <= TankCapacity)
                {
                    this.FuelQuantity += quantity;
                }
                else
                {
                    Console.WriteLine($"Cannot fit {quantity} fuel in the tank");
                }
            }
        }
    }
}
