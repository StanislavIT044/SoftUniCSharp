using NUnit.Framework;
using System.Runtime.Serialization;

namespace Tests
{
    using ExtendedDatabase;
    using System;

    [TestFixture]
    public class ExtendedDatabaseTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void IfThereAreAlreadyUsersWithThisUsername()
        {
            Person person = new Person(1, "Pesho");
            Person secoundPerson = new Person(2, "Pesho");

            ExtendedDatabase db = new ExtendedDatabase(person);

            Assert.That(() => db.Add(secoundPerson), Throws.InvalidOperationException);
        }

        [Test]
        public void IfThereAreAlreadyUsersWithThisId()
        {
            Person person = new Person(2, "Pesho");
            Person secoundPerson = new Person(2, "Gosho");

            ExtendedDatabase db = new ExtendedDatabase(person);

            Assert.That(() => db.Add(secoundPerson), Throws.InvalidOperationException);
        }

        [Test]
        public void IfAddMoreThan16PersonsShouldThrowException()
        {
            Person[] persons =
            {
                 new Person(1, "Pesho"),
                 new Person(2, "a"),
                 new Person(3, "s"),
                 new Person(4, "d"),
                 new Person(5, "f"),
                 new Person(6, "g"),
                 new Person(7, "1"),
                 new Person(8, "2"),
                 new Person(9, "3"),
                 new Person(10, "5"),
                 new Person(11, "6"),
                 new Person(12, "Pe7sho"),
                 new Person(13, "Pe8sho"),
                 new Person(14, "Pe9sho"),
                 new Person(15, "Pe0sho"),
                 new Person(16, "fPe0sho")
        
            };
        
            Person otherPerson = new Person(564, "fdf");
        
            ExtendedDatabase db = new ExtendedDatabase(persons);
        
            Assert.That(() => db.Add(otherPerson), Throws.InvalidOperationException);
        }

        [Test]
        public void IfRemovePersonAndTheCoundIs0ShouldThrowException()
        {
            ExtendedDatabase db = new ExtendedDatabase();

            Assert.That(() => db.Remove(), Throws.InvalidOperationException);
        }

        [Test]
        public void IfNoUserIsPresentByThisUsernameShouldThrowException()
        {
            Person person = new Person(2, "Pesho");

            ExtendedDatabase db = new ExtendedDatabase(person);

            Assert.That(() => db.FindByUsername("Gosho"), Throws.InvalidOperationException);
        }

        [TestCase(null)]
        [TestCase("")]
        public void IfSearchPersonWhithNullOrEmptyNameShouldThrowException(string name)
        {
            ExtendedDatabase db = new ExtendedDatabase();

            Assert.That(() => db.FindByUsername(name), Throws.ArgumentNullException);
        }

        [Test]
        public void IfNoUserIsPresentByThisIdShouldThrowException()
        {
            Person person = new Person(2, "Pesho");

            ExtendedDatabase db = new ExtendedDatabase(person);

            Assert.That(() => db.FindById(1), Throws.InvalidOperationException);
        }

        [TestCase(-2323232300002)]
        [TestCase(-1)]
        public void IfNegativeIdsAreFoundShouldThrowException(long id)
        {
            Person person = new Person(2, "Pesho");

            ExtendedDatabase db = new ExtendedDatabase(person);

            Assert.Throws<ArgumentOutOfRangeException>(() => db.FindById(id));
        }

        [Test]
        public void ReturnCountNumber()
        {
            Person person = new Person(2, "Pesho");
        
            ExtendedDatabase db = new ExtendedDatabase(person);
        
            Assert.AreEqual(1, db.Count);
        }

        [TestCase(1, "Pesho")]
        [TestCase(2, "Gosho")]
        public void TestPersonConstructor(long id, string name)
        {
            Person person = new Person(id, name);

            Assert.AreEqual(id, person.Id);
            Assert.AreEqual(name, person.UserName);
        }
    }
}