using NUnit.Framework;
using System;

namespace TheRace.Tests
{
    public class RaceEntryTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void CounterTest()
        {
            UnitMotorcycle unitMotorcycle = new UnitMotorcycle("MotoP", 45, 250);
            UnitMotorcycle secoundUnitMotorcycle = new UnitMotorcycle("MotoC", 40, 260);

            UnitRider unitRider = new UnitRider("Kiro", unitMotorcycle);
            UnitRider secoundUnitRider = new UnitRider("Gosho", secoundUnitMotorcycle);

            RaceEntry race = new RaceEntry();

            race.AddRider(unitRider);
            race.AddRider(secoundUnitRider);

            Assert.AreEqual(2, race.Counter);
        }

        [Test]
        public void AddRiderThrowExceptionIfRiderIsNull()
        {
            UnitRider unitRider = null;

            RaceEntry race = new RaceEntry();

            Assert.Throws<InvalidOperationException>(() => race.AddRider(unitRider));
        }

        [Test]
        public void AddRiderThrowExceptionIfRiderAlreadyExist()
        {
            UnitMotorcycle unitMotorcycle = new UnitMotorcycle("MotoP", 45, 250);

            UnitRider unitRider = new UnitRider("Kiro", unitMotorcycle);

            RaceEntry race = new RaceEntry();

            string message = race.AddRider(unitRider);

            Assert.AreEqual("Rider Kiro added in race.", message);
        }

        [Test]
        public void AddRiderTestReturnString()
        {
            UnitMotorcycle unitMotorcycle = new UnitMotorcycle("MotoP", 45, 250);
            UnitMotorcycle secoundUnitMotorcycle = new UnitMotorcycle("MotoC", 40, 260);

            UnitRider unitRider = new UnitRider("Kiro", unitMotorcycle);
            UnitRider secoundUnitRider = new UnitRider("Kiro", secoundUnitMotorcycle);

            RaceEntry race = new RaceEntry();

            race.AddRider(unitRider);

            Assert.Throws<InvalidOperationException>(() => race.AddRider(secoundUnitRider));
        }

        [Test]
        public void CalculateAverageHorsePowerThrowsExceptionIfParticipantsAreBelowTwo()
        {
            UnitMotorcycle unitMotorcycle = new UnitMotorcycle("MotoP", 45, 250);

            UnitRider unitRider = new UnitRider("Kiro", unitMotorcycle);

            RaceEntry race = new RaceEntry();

            race.AddRider(unitRider);

            Assert.Throws<InvalidOperationException>(() => race.CalculateAverageHorsePower());
        }

        [Test]
        public void CalculateAverageHorsePowerTest()
        {
            UnitMotorcycle unitMotorcycle = new UnitMotorcycle("MotoP", 45, 250);
            UnitMotorcycle secoundUnitMotorcycle = new UnitMotorcycle("MotoC", 40, 260);

            UnitRider unitRider = new UnitRider("Kiro", unitMotorcycle);
            UnitRider secoundUnitRider = new UnitRider("Gosho", secoundUnitMotorcycle);

            RaceEntry race = new RaceEntry();

            race.AddRider(unitRider);
            race.AddRider(secoundUnitRider);

            Assert.AreEqual((45 + 40) / 2.0, race.CalculateAverageHorsePower());
        }
    }
}