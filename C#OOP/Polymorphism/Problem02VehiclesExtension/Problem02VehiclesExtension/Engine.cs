namespace Problem02VehiclesExtension
{
    using System;

    public class Engine
    {
        public void Run()
        {
            string[] carInfo = Console.ReadLine()
                .Split();
            
            string[] truckInfo = Console.ReadLine()
                .Split();

            string[] busInfo = Console.ReadLine()
                .Split();

            double carFuel = double.Parse(carInfo[1]);
            double carLitersPerKm = double.Parse(carInfo[2]) + 0.9;
            double carCapacity = double.Parse(carInfo[3]);

            double truckFuel = double.Parse(truckInfo[1]);
            double truckLitersPerKm = double.Parse(truckInfo[2]) + 1.6;
            double truckCapacity = double.Parse(truckInfo[3]);

            double busFuel = double.Parse(busInfo[1]);
            double busLitersPerKm = double.Parse(busInfo[2]);
            double busCapacity = double.Parse(busInfo[3]);

            Vehicle car = new Car(carFuel, carLitersPerKm, carCapacity);
            Vehicle truck = new Truck(truckFuel, truckLitersPerKm, truckCapacity);
            Vehicle bus = new Bus(busFuel, busLitersPerKm, busCapacity);

            int commandsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsCount; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split();

                string commandType = tokens[0];
                string vehicleType = tokens[1];
                double distanceOrLitters = double.Parse(tokens[2]);

                if (commandType == "Drive")
                {
                    if (vehicleType == "Car")
                    {
                        car.Drive(distanceOrLitters);
                    }
                    else if (vehicleType == "Truck")
                    {
                        truck.Drive(distanceOrLitters);
                    }
                    else if (vehicleType == "Bus")
                    {
                        bus.FuelConsumprionPerKm += 1.4;
                        bus.Drive(distanceOrLitters);
                        bus.FuelConsumprionPerKm -= 1.4;
                    }
                }
                else if (commandType == "Refuel")
                {
                    if (vehicleType == "Car")
                    {
                        car.Refuel(distanceOrLitters);
                    }
                    else if (vehicleType == "Truck")
                    {
                        truck.Refuel(distanceOrLitters);
                    }
                    else if (vehicleType == "Bus")
                    {
                        bus.Refuel(distanceOrLitters);
                    }
                }
                else if (commandType == "DriveEmpty")
                {
                    bus.Drive(distanceOrLitters);
                }
            }

            Console.WriteLine($"Car: {car.Fuel:F2}");
            Console.WriteLine($"Truck: {truck.Fuel:F2}");
            Console.WriteLine($"Bus: {bus.Fuel:F2}");
        }
    }
}
