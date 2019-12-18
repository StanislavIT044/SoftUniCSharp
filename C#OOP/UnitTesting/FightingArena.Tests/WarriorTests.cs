using NUnit.Framework;

namespace Tests
{
    using FightingArena;
    using System;

    public class WarriorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("Gosho", 100, 1000, "ValidTest")]
        [TestCase(null, 100, 1000, "Not")]
        [TestCase(" ", 100, 1000, "Not")]
        [TestCase("", 100, 1000, "Not")]
        [TestCase("Gosho", 0, 1000, "Not")]
        [TestCase("Gosho", -10, 1000, "Not")]
        [TestCase("Gosho", 100, -10, "Not")]
        public void TestWarriorConstructorAndProps(string name, int damage, int hp, string validOrNot)
        {
            if (validOrNot == "ValidTest")
            {
                Warrior warrior = new Warrior(name, damage, hp);

                Assert.AreEqual(name, warrior.Name);
                Assert.AreEqual(damage, warrior.Damage);
                Assert.AreEqual(hp, warrior.HP);
            }
            else
            {
                Assert.Throws<ArgumentException>(() => new Warrior(name, damage, hp));
            }

        }

        [TestCase("Gosho", 100, 30, "Not", "Petkan", 100, 40)]//1st invalid warrior
        [TestCase("Gosho", 100, 29, "Not", "Petkan", 100, 40)]//1st invalid warrior
        [TestCase("Gosho", 100, 40, "Not", "Petkan", 100, 30)]//2nd invalid warrior
        [TestCase("Gosho", 100, 40, "Not", "Petkan", 100, 29)]//2nd invalid warrior
        [TestCase("Gosho", 90, 40, "Not", "Petkan", 100, 29)]//1nd invalid warrior
        [TestCase("Gosho", 200, 200, "ValidTest", "Petkan", 100, 200)]//Valid warriors
        [TestCase("Gosho", 210, 200, "ValidTest", "Petkan", 100, 200)]//Valid warriors
        [TestCase("Gosho", 100, 200, "ValidTest", "Petkan", 200, 100)]//just testing
        [TestCase("Gosho", 200, 200, "ValidTest", "Petkan", 200, 200)]//just testing
        [TestCase("Gosho", 200, 100, "Not", "Petkan", 200, 100)]//just testing
        public void TestWarriorAttackMethod
            (string name, int damage, int hp, string validOrNot, string secoundName, int secoundDamage, int secoundHp)
        {
            if (validOrNot == "ValidTest")
            {
                Warrior warrior = new Warrior(name, damage, hp);
                Warrior warriorAttacked = new Warrior(name, secoundDamage, secoundHp);

                warrior.Attack(warriorAttacked);

                Assert.AreEqual(hp - secoundDamage, warrior.HP);

                if (warrior.Damage > warriorAttacked.HP)
                {
                    Assert.AreEqual(0, warriorAttacked.HP);
                }
                else
                {
                    Assert.AreEqual(secoundDamage - damage, warriorAttacked.HP);
                }
            }
            else
            {
                Warrior warrior = new Warrior(name, damage, hp);
                Warrior warriorAttacked = new Warrior(validOrNot, secoundDamage, secoundHp);

                Assert.Throws<InvalidOperationException>(() => warrior.Attack(warriorAttacked));
            }
        }

    }
}