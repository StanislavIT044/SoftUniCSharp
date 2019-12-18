using NUnit.Framework;

namespace Tests
{
    using FightingArena;
    using System;

    public class ArenaTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("Gosho", 100, 30)]
        public void TestArenaEnrollException(string name, int damage, int hp)
        {
            Warrior attacher = new Warrior(name, damage, hp);
            Warrior deffender = new Warrior(name, damage, hp);

            Arena arena = new Arena();

            arena.Enroll(attacher);

            Assert.Throws<InvalidOperationException>(() => arena.Enroll(deffender));
        }

        [TestCase("Gosho", 100, 30)]
        public void TestArenaFightException(string name, int damage, int hp)
        {
            Warrior attacher = new Warrior(name, damage, hp);
            Warrior deffender = new Warrior("Pesho", damage, hp);

            Arena arena = new Arena();
           
            if (arena.Count == 0)
            {
                Assert.Throws<InvalidOperationException>(() => attacher.Attack(deffender));
            }

            if (arena.Count == 1)
            {
                arena.Enroll(attacher);

                Assert.Throws<InvalidOperationException>(() => attacher.Attack(deffender));
            }

            if (arena.Count == 1)
            {
                arena.Enroll(deffender);

                Assert.Throws<InvalidOperationException>(() => attacher.Attack(deffender));
            }
        }

        [TestCase("Gosho", 100, 30)]
        public void TestArenaCount(string name, int damage, int hp)
        {
            Warrior attacher = new Warrior(name, damage, hp);
            Warrior deffender = new Warrior("Pesho", damage, hp);
        
            Arena arena = new Arena();
        
            arena.Enroll(attacher);

            Assert.That(arena.Count == 1);

            arena.Enroll(deffender);
        
            Assert.That(arena.Count == 2);
            Assert.AreEqual(2, arena.Warriors.Count);
        }

        
    }
}
