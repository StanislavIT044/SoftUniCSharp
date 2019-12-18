namespace ParkingSystem.Tests
{
    using NUnit.Framework;
    using System;

    public class SoftParkTest
    {
        [Test]
        public void TestParkCarMethodShouldThrowExcetionIfParkSpotIsInvalid()
        {
            SoftPark softPark = new SoftPark();
            Car car = new Car("Audi", "123123");

            Assert.Throws<ArgumentException>(() => softPark.ParkCar("1", car));
        }

        [Test]
        public void TestParkCarMethodShouldThrowExcetionIfParkSpotIsNotNull()
        {
            SoftPark softPark = new SoftPark();
            Car car = new Car("Audi", "123123");
            Car car2 = new Car("AudiQ", "123123");

            softPark.ParkCar("A1", car);

            Assert.Throws<ArgumentException>(() => softPark.ParkCar("A1", car2));
        }

        [Test]
        public void RemoveMethod()
        {
            SoftPark softPark = new SoftPark();
            Car car = new Car("Audi", "123123");

            softPark.ParkCar("A1", car);

            Assert.Throws<ArgumentException>(() => softPark.RemoveCar("1", car));
        }

        [Test]
        public void RemoveMethod2()
        {
            SoftPark softPark = new SoftPark();
            Car car = new Car("Audi", "123123");

            softPark.ParkCar("A1", car);

            Assert.Throws<ArgumentException>(() => softPark.RemoveCar("B1", car));
        }

        [Test]
        public void FUKINGTEST()
        {
            SoftPark softPark = new SoftPark();

            var car = new Car("BMW", "ABC123");

            softPark.ParkCar("A1", car);

            Assert.Throws<InvalidOperationException>(
                () => softPark.ParkCar("B1", car));
        }


    }
}