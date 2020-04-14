namespace Problem01Vehicles
{
    public class Bus : Vehicle
    {
        public Bus(double fuelQ, double fuelC, double tankC) 
            : base(fuelQ, fuelC, tankC)
        {
        }

        public string DriveWithPassangers(double distance)
        {
            double currentConsumption = distance * (this.FuelConsumption + 1.4);

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
    }
}
