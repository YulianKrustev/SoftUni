using NUnit.Framework;

namespace Tests
{
    using Database;
    using System;
    public class DatabaseTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void InitializeDatabeseWith16Elements()
        {
            int[] data = new int[16];
            Database database = new Database(data);
            Assert.AreEqual(16, database.Count);
        }

        [Test]
        public void InitializeDatabeseWith17Elements()
        {
            int[] data = new int[17];
            Assert.Throws<InvalidOperationException>(() => new Database(data));
        }

        [Test]
        public void InitializeDatabeseWith15Elements()
        {
            int[] data = new int[15];
            Database database = new Database(data);
            Assert.That(database.Count, Is.EqualTo(15));
        }

        [Test]
        public void RemoveElemntFromEmptyCollection()
        {
            Database database = new Database();
            Assert.Throws<InvalidOperationException>(() => database.Remove());
        }

        [Test]
        public void AddElemntFromEmptyCollection()
        {
            Database database = new Database();
            database.Add(4);
            Assert.That(database.Count == 1);
        }

        [Test]
        public void RemoveElemntFromCollection()
        {
            Database database = new Database();
            database.Add(4);
            database.Remove();
            Assert.That(database.Count == 0);
        }

        [Test]
        [TestCase(new int[] {2, 4, 6})]
        public void FetchShouldReturnArrayCollection(int[] array)
        {
            Database database = new Database(array);
            int[] test = database.Fetch();

            CollectionAssert.AreEqual(test, array);
        }
    }
}