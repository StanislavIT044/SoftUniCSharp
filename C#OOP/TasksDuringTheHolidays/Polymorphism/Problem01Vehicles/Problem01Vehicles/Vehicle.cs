namespace Problem01Vehicles
{
    public class Vehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;
        private double tankCapacity;

        public Vehicle(double fuelQ, double fuelC, double tankC)
        {
            this.FuelQuantity = fuelQ;
            this.FuelConsumption = fuelC;
            this.TankCapacity = tankC;
        }

        public double FuelQuantity { get; set; }// TODO: logig to set !

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

        public virtual void Refuel(double quantity)// TODO: logig to refuel
        {
            
        }
    }
}
