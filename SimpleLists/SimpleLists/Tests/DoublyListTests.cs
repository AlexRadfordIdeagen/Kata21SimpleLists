using NUnit.Framework;
namespace SimpleLists.Tests
{
    [TestFixture]
    class DoublyLinkedListTests
    {
        [Test]
        public void FindNameFail()
        {
            DoublyLinkedList doubleList = new DoublyLinkedList();

            Assert.IsNull(doubleList.Find("David"));
        }

        [Test]
        public void FindNameSuccess()
        {
            DoublyLinkedList doubleList = new DoublyLinkedList();
            doubleList.Add("David");

            Assert.IsNotNull(doubleList.Find("David"));
        }

        [Test]
        public void ListToArray()
        {
            string[] doublyNodeArray = { "David", "James", "Pirate Pete", "Brenda" };
            DoublyLinkedList doubleList = new DoublyLinkedList();
            doubleList.Add("David");
            doubleList.Add("James");
            doubleList.Add("Pirate Pete");
            doubleList.Add("Brenda");
            string[] result = doubleList.Values();
            CollectionAssert.AreEqual(doublyNodeArray, result);

        }

        [Test]
        public void RemoveItem()
        {
            DoublyLinkedList doubleList = new DoublyLinkedList();
            doubleList.Delete("James");
            Assert.IsNull(doubleList.Find("James"));
        }

        [Test]
        public void RemoveFromCount()
        {
            DoublyLinkedList doubleList = new DoublyLinkedList();
            doubleList.Add("David");
            doubleList.Add("James");
            doubleList.Add("Pirate Pete");
            doubleList.Add("Brenda");
            doubleList.Delete("James");
            Assert.AreEqual(doubleList.Count(), 3);
        }

        [Test]
        public void RemoveFromEnd()
        {
            var testList = new DoublyLinkedList();
            testList.Add("one");
            testList.Add("two");
            testList.Add("three");

            testList.Delete("three");
            string[] expected = { "one", "two" };

            Assert.AreEqual(expected, testList.Values());
        }
    }
}