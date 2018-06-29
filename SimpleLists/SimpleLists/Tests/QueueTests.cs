using NUnit.Framework;
using SimpleListsNetCore;

namespace SimpleLists.Tests
{
    [TestFixture]
    class QueueTests
    {
        [Test]
        public void FindNameFail()
        {
            Queue queue = new Queue();

            Assert.IsNull(queue.Peek());
        }

        [Test]
        public void FindNameSuccess()
        {
            Queue queue = new Queue();
            queue.Enqueue("David");

            Assert.IsNotNull(queue.Peek());
        }

        [Test]
        public void ListToArray()
        {
            string[] queueArray = { "David", "James", "Pirate Pete", "Brenda" };
            Queue queue = new Queue();
            queue.Enqueue("David");
            queue.Enqueue("James");
            queue.Enqueue("Pirate Pete");
            queue.Enqueue("Brenda");
            string[] result = queue.Values();
            CollectionAssert.AreEqual(queueArray, result);

        }

        [Test]
        public void RemoveItem()
        {
            Queue queue = new Queue();
            queue.Enqueue("James");
            queue.Dequeue();
            Assert.IsNull(queue.Peek());
        }

        [Test]
        public void RemoveFromCount()
        {
            Queue queue = new Queue();
            queue.Enqueue("David");
            queue.Enqueue("James");
            queue.Enqueue("Pirate Pete");
            queue.Enqueue("Brenda");
            queue.Dequeue();
            Assert.AreEqual(queue.Count(), 3);
        }
    }
}