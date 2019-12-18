namespace Problem01Vehicles
{
    using System;
    using System.Collections.Generic;

    public class Engine
    {
        public void Run()
        {
            string[] carInfo = Console.ReadLine()
                .Split();
            
            string[] truckInfo = Console.ReadLine()
                .Split();

            double carFuel = double.Parse(carInfo[1]);
            double carLitersPerKm = double.Parse(carInfo[2]) + 0.9;

            double truckFuel = double.Parse(truckInfo[1]);
            double truckLitersPerKm = double.Parse(truckInfo[2]) + 1.6;

            Vehicle car = new Car(carFuel, carLitersPerKm);
            Vehicle truck = new Truck(truckFuel, truckLitersPerKm);

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
                }
                else if (commandType == "Refuel")
                {
                    if (vehicleType == "Car")
                    {
                        car.Refuel(distanceOrLitters);
                    }
                    else if (vehicleType == "Truck")
                    {
                        distanceOrLitters -= distanceOrLitters * 0.05;
                       truck.Refuel(distanceOrLitters);
                    }
                }
            }

            Console.WriteLine($"Car: {car.Fuel:F2}");
            Console.WriteLine($"Truck: {truck.Fuel:F2}");

        }
    }
}
