using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem01RawData
{
    public class Runner
    {
        public static void Run()
        {
            List<Car> cars = new List<Car>();

            CreateACar(cars);

            PrintCar(cars);
        }

        private static void PrintCar(List<Car> cars)
        {
            string command = Console.ReadLine();

            if (command == "fragile")
            {
                List<string> fragile = cars
                    .Where(x => x.CargoType == "fragile" && x.Tires.Any(y => y.TirePressure < 1))
                    .Select(x => x.Model)
                    .ToList();

                Console.WriteLine(string.Join(Environment.NewLine, fragile));
            }
            else
            {
                List<string> flamable = cars
                    .Where(x => x.CargoType == "flamable" && x.Engine.EnginePower > 250)
                    .Select(x => x.Model)
                    .ToList();

                Console.WriteLine(string.Join(Environment.NewLine, flamable));
            }
        }

        private static void CreateACar(List<Car> cars)
        {
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string model = parameters[0];
                int engineSpeed = int.Parse(parameters[1]);
                int enginePower = int.Parse(parameters[2]);
                int cargoWeight = int.Parse(parameters[3]);
                string cargoType = parameters[4];
                double tire1Pressure = double.Parse(parameters[5]);
                int tire1age = int.Parse(parameters[6]);
                double tire2Pressure = double.Parse(parameters[7]);
                int tire2age = int.Parse(parameters[8]);
                double tire3Pressure = double.Parse(parameters[9]);
                int tire3age = int.Parse(parameters[10]);
                double tire4Pressure = double.Parse(parameters[11]);
                int tire4age = int.Parse(parameters[12]);

                Engine engine = new Engine(engineSpeed, enginePower);

                Tire firstTire = new Tire(tire1Pressure, tire1age);
                Tire secoundTire = new Tire(tire2Pressure, tire2age);
                Tire thirthTire = new Tire(tire3Pressure, tire3age);
                Tire fourthTire = new Tire(tire4Pressure, tire4age);

                Car car = new Car(model, engine, cargoWeight, cargoType, new List<Tire> { firstTire, secoundTire, thirthTire, fourthTire });

                cars.Add(car);
            }
        }
    }
}
