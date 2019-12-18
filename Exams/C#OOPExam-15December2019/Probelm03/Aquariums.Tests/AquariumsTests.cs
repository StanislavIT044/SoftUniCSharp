namespace Aquariums.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class AquariumsTests
    {
        [TestCase("")]
        [TestCase(null)]
        [TestCase("gosho")]
        public void TestName(string name)
        {
            Aquarium aquarium = null;

            if (string.IsNullOrEmpty(name))
            {
                Assert.Throws<ArgumentNullException>(
                    () => aquarium = new Aquarium(name, 10));
            }
            else
            {
                aquarium = new Aquarium(name, 10);
                Assert.AreEqual("gosho", aquarium.Name);
            }
        }

        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(10)]
        [TestCase(100)]
        public void TestCapacity(int capacity)
        {
            Aquarium aquarium = null;

            if (capacity < 0)
            {
                Assert.Throws<ArgumentException>(
                    () => new Aquarium("Gosho", capacity));
            }
            else
            {
                aquarium = new Aquarium("Gosho", capacity);
                Assert.AreEqual(capacity, aquarium.Capacity);
            }
        }

        [TestCase(1)]
        [TestCase(2)]
        public void TestCount(int capacity)
        {
            Aquarium aquarium = new Aquarium("gosho", capacity);

            aquarium.Add(new Fish("Gaco"));

            if (capacity == 1)
            {
                Assert.AreEqual(1, aquarium.Count);
            }
            else
            {
                aquarium.Add(new Fish("Gosho"));
                Assert.AreEqual(2, aquarium.Count);
            }
        }

        [TestCase]
        public void TestAdd()
        {
            Aquarium aquarium = new Aquarium("gosho", 1);

            aquarium.Add(new Fish("Gaco"));
            Assert.AreEqual(1, aquarium.Count);

            Assert.Throws<InvalidOperationException>(
                () => aquarium.Add(new Fish("Gosho")));

        }

        [TestCase]
        public void TestRemove()
        {
            Aquarium aquarium = new Aquarium("gosho", 1);

            Fish fish = new Fish("Gaco");

            aquarium.Add(fish);

            Assert.Throws<InvalidOperationException>(
                () => aquarium.RemoveFish(null));

            aquarium.RemoveFish("Gaco");

            Assert.AreEqual(0, aquarium.Count);
        }

        [TestCase]
        public void TestSellFish() // ton shure
        {
            Aquarium aquarium = new Aquarium("gosho", 1);

            Fish fish = new Fish("Gaco");

            aquarium.Add(fish);

            Assert.Throws<InvalidOperationException>(
                () => aquarium.SellFish(null));

            Assert.AreEqual(fish, aquarium.SellFish("Gaco"));

        }

        [TestCase]
        public void TestReport()
        {
            Aquarium aquarium = new Aquarium("gosho", 1);

            Fish fish = new Fish("Gaco");

            aquarium.Add(fish);

            string str = $"Fish available at {aquarium.Name}: {fish.Name}";

            Assert.AreEqual(str, aquarium.Report());
        }
    }
}
