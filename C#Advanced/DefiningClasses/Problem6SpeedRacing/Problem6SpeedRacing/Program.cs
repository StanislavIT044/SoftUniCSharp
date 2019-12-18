using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem6SpeedRacing
{
    public class Program
    {
        static void Main()
        {
            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            int countCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < countCars; i++)
            {
                string[] carInfo = Console.ReadLine().Split();

                string carModel = carInfo[0];
                double fuelAmount = double.Parse(carInfo[1]);
                double fuelConsumptionPerKm = double.Parse(carInfo[2]);

                cars.Add(carModel, new Car(carModel, fuelAmount, fuelConsumptionPerKm));
            }

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }

                string[] tokens = command.Split();
                string carModel = tokens[1];
                double distanceToDrive = double.Parse(tokens[2]);

                cars[carModel].Drive(distanceToDrive);
                
               // Car car = cars.First(c => c.Model == carModel);
               // if (!car.Drive(distanceToDrive))
               // {
               //     Console.WriteLine("Insufficient fuel for the drive");
               // }
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Value.Model} {car.Value.FuelAmount:F2} {car.Value.TraveledDistance}");
            }
        }
    }
}
