using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem7RawData
{
    class StartUp
    {
        static void Main()
        {
            int numOfCars = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < numOfCars; i++)
            {
                string[] carInfo = Console.ReadLine().Split();

                string carModel = carInfo[0];
                int engineSpeed = int.Parse(carInfo[1]);
                int enginPower = int.Parse(carInfo[2]);
                int cargoWeight = int.Parse(carInfo[3]);
                string cargoType = carInfo[4];
                double tire1Pressure = double.Parse(carInfo[5]);
                int tire1Age = int.Parse(carInfo[6]);
                double tire2Pressure = double.Parse(carInfo[7]);
                int tire2Age = int.Parse(carInfo[8]);
                double tire3Pressure = double.Parse(carInfo[9]);
                int tire3Age = int.Parse(carInfo[10]);
                double tire4Pressure = double.Parse(carInfo[11]);
                int tire4Age = int.Parse(carInfo[12]);

                cars.Add(new Car(carModel, 
                         new Engine(engineSpeed, enginPower), 
                         new Cargo(cargoWeight, cargoType),
                         new List<Tire>
                         {
                         new Tire(tire1Pressure, tire1Age),
                         new Tire(tire2Pressure, tire2Age),
                         new Tire(tire3Pressure, tire3Age),
                         new Tire(tire4Pressure, tire4Age)
                         }));
            }

            string command = Console.ReadLine();

            List<Car> carsForPrint = new List<Car>();

            if (command == "fragile")
            {
                foreach (var car in cars)
                {
                    foreach (var tire in car.tires)
                    {
                        if (tire.tirePressure < 1)
                        {
                            carsForPrint.Add(car);
                            break;
                        }
                    }
                }
            }
            else if (command == "flamable")
            {
                foreach (var car in cars)
                {
                    if (car.engine.power > 250)
                    {
                        carsForPrint.Add(car);
                    }
                }
            }

            foreach (var car in carsForPrint)
            {
                Console.WriteLine(car.carModel);
            }
        }
    }
}
