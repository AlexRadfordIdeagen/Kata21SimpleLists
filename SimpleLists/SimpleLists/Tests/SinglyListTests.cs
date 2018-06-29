using NUnit.Framework;
namespace SimpleLists.Tests
{
    [TestFixture]
    class SinglyListTests
    {
        [Test]
        public void FindNameFail()
        {
            SinglyLinkedList singleList = new SinglyLinkedList();

            Assert.IsNull(singleList.Find("David"));
        }

        [Test]
        public void FindNameSuccess()
        {
            SinglyLinkedList singleList = new SinglyLinkedList();
            singleList.Add("David");

            Assert.IsNotNull(singleList.Find("David"));
        }

        [Test]
        public void ListToArray()
        {
            string[] singleNodeArray = { "David", "James", "Pirate Pete", "Brenda" };
            SinglyLinkedList singleList = new SinglyLinkedList();
            singleList.Add("David");
            singleList.Add("James");
            singleList.Add("Pirate Pete");
            singleList.Add("Brenda");
            string[] result = singleList.Values();
            CollectionAssert.AreEqual(singleNodeArray, result);

        }

        [Test]
        public void RemoveItem()
        {
            SinglyLinkedList singleList = new SinglyLinkedList();
            singleList.Delete("James");
            Assert.IsNull(singleList.Find("James"));
        }

        [Test]
        public void RemoveFromCount()
        {
            SinglyLinkedList singleList = new SinglyLinkedList();
            singleList.Add("David");
            singleList.Add("James");
            singleList.Add("Pirate Pete");
            singleList.Add("Brenda");
            singleList.Delete("James");
            Assert.AreEqual(singleList.Count(), 3);
        }
    }
}