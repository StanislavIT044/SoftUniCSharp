using NUnit.Framework;

namespace Tests
{
    using CarManager;
    using System;

    public class CarTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ConstructorInitializeCorrectly()
        {
            string make = "Audi";
            string model = "A3";
            double fuelConsumption = 4.5;
            double fuelCapacity = 55.5;

            Car car = new Car(make, model, fuelConsumption, fuelCapacity);

            Assert.AreEqual(make, car.Make);
            Assert.AreEqual(model, car.Model);
            Assert.AreEqual(fuelConsumption, car.FuelConsumption);
            Assert.AreEqual(fuelCapacity, car.FuelCapacity);
        }

        [TestCase(null, "A3", 4.5, 55)]
        [TestCase("Audi", null, 4.5, 55)]
        [TestCase("Audi", "A3", -1, 55)]
        [TestCase("Audi", "A3", 4.5, -1)]
        public void PropertiesShouldThrows(string make, string model, double fuelConsumption, double fuelCapacity)
        {
            Assert.Throws<ArgumentException>(() => new Car(make, model, fuelConsumption, fuelCapacity));
        }

        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(10.1)]
        [TestCase(1000)]
        public void TestMethodRefuel(double quantity)
        {
            string make = "Audi";
            string model = "A3";
            double fuelConsumption = 4.5;
            double fuelCapacity = 55.5;

            Car car = new Car(make, model, fuelConsumption, fuelCapacity);

            if (quantity > 0)
            {
                car.Refuel(quantity);
                if (quantity + car.FuelAmount > fuelCapacity)
                {
                    Assert.AreEqual(fuelCapacity, car.FuelAmount);
                }
                else
                {
                    Assert.AreEqual(quantity, car.FuelAmount);
                }
            }
            else
            {
                Assert.Throws<ArgumentException>(() => car.Refuel(quantity));
            }
        }

        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(10)]
        [TestCase(100)]
        [TestCase(1000)]
        [TestCase(10000)]
        public void TestDriveMethod(double distance)
        {
            string make = "Audi";
            string model = "A3";
            double fuelConsumption = 10;
            double fuelCapacity = 50;

            Car car = new Car(make, model, fuelConsumption, fuelCapacity);

            double fuelNeeded = (distance / 100) * car.FuelConsumption;

            if (fuelNeeded > car.FuelAmount)
            {
                Assert.Throws<InvalidOperationException>(() => car.Drive(distance));
            }
            else
            {
                double expected = car.FuelAmount - fuelNeeded;
                car.Drive(distance);
                Assert.AreEqual(expected, car.FuelAmount);
            }
        }
    }
}