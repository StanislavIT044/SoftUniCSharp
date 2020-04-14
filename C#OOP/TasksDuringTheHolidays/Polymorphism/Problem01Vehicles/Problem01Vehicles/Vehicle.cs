namespace Problem01Vehicles
{
    public class Vehicle
    {
        public Vehicle(double fuelQ, double fuelC)
        {
            this.FuelQuantity = fuelQ;
            this.FuelConsumption = fuelC;
        }

        public double FuelQuantity { get; set; }

        public double FuelConsumption { get; set; }

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

        public virtual void Refuel(double quantity)
        {
            
        }
    }
}
