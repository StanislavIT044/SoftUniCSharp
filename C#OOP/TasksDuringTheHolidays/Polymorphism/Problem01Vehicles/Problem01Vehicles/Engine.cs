using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem01Vehicles
{
    public class Engine
    {
        public void Run()
        {
            Dictionary<string, Vehicle> vehicles = VehicleInitializer();

            DoActions(vehicles);

            WriteRemainingLitersToConsole(vehicles);
        }

        private static void WriteRemainingLitersToConsole(Dictionary<string, Vehicle> vehicles)
        {
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"{vehicle.Key}: {vehicle.Value.FuelQuantity:F2}");
            }
        }

        private static void DoActions(Dictionary<string, Vehicle> vehicles)
        {
            double numberOfCommands = double.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split(" ").ToArray();

                string action = command[0];
                string vehicle = command[1];
                double disOrLit = double.Parse(command[2]);

                if (action == "Drive")
                {
                    if (vehicle == "Bus")
                    {
                        Console.WriteLine(vehicles[vehicle].DriveWithPassangers(disOrLit));
                    }
                    else
                    {
                        Console.WriteLine(vehicles[vehicle].Drive(disOrLit));
                    }
                }
                else if (action == "DriveEmpty")
                {
                    Console.WriteLine(vehicles["Bus"].DriveWithPassangers(disOrLit));
                }
                else if (action == "Refuel")
                {
                    vehicles[vehicle].Refuel(disOrLit);
                }
            }
        }

        private Dictionary<string, Vehicle> VehicleInitializer()
        {
            Dictionary<string, Vehicle> vehicles = new Dictionary<string, Vehicle>();

            string[] carInfo = Console.ReadLine()
                            .Split(" ")
                            .ToArray();

            double carFuelQ = double.Parse(carInfo[1]);
            double carFuelC = double.Parse(carInfo[2]);
            double carTankC = double.Parse(carInfo[3]);

            Vehicle car = new Car(carFuelQ, carFuelC, carTankC);

            string[] truckInfo = Console.ReadLine()
                .Split(" ")
                .ToArray();

            double truckFuelQ = double.Parse(truckInfo[1]);
            double truckFuelC = double.Parse(truckInfo[2]);
            double truckTankC = double.Parse(truckInfo[3]);

            Vehicle truck = new Truck(truckFuelQ, truckFuelC, truckTankC);

            string[] busInfo = Console.ReadLine()
                .Split(" ")
                .ToArray();

            double busFuelQ = double.Parse(busInfo[1]);
            double busFuelC = double.Parse(busInfo[2]);
            double busTankC = double.Parse(busInfo[3]);

            Vehicle bus = new Bus(busFuelQ, busFuelC, busTankC);

            vehicles.Add("Car", car);
            vehicles.Add("Truck", truck);
            vehicles.Add("Bus", bus);

            return vehicles;
        }
    }
}
