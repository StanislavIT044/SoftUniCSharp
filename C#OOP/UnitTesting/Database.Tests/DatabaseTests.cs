using NUnit.Framework;


namespace Tests
{
    using Database;

    [TestFixture]
    public class DatabaseTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void StoringArrayCapacity()
        {
            int[] data = new int[]
            {
                0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15
            };

            Database database = new Database(data);

            Assert.That(() => database.Add(0), Throws.InvalidOperationException);

            Assert.Pass(); //??
        }

        [Test]
        public void AddAnElementAtTheNextFreeCell()
        {
            int[] data = new int[]
            {
                0, 1, 2, 3, 4, 5, 6, 7, 8, 9
            };

            Database database = new Database(data);

            database.Add(0);

            Assert.That(database.Count is 11);
        }

        [Test]
        public void RemovingAnElementAtTheLastIndex()
        {
            int[] data = new int[]
            {
                0, 1, 2, 3, 4, 5, 6, 7, 8, 9
            };

            Database database = new Database(data);

            database.Remove();

            Assert.That(database.Count is 9);
        }

        [Test]
        public void RemoveMethodShtouldThrowInfalidOperatonException()
        {
            Database database = new Database();

            Assert.That(() => database.Remove(), Throws.InvalidOperationException);
        }

        [Test]
        public void Fetch()
        {
            int[] data = new int[]
            {
                0, 1, 2, 3, 4, 5, 6, 7, 8, 9
            };

            Database database = new Database(data);

            int[] dbFetch = database.Fetch();

            Assert.AreEqual(data, dbFetch);
        }
    }
}