namespace SimpleLists
{
    public class DoublyLinkedList : SinglyLinkedList
    {
        public override void Delete(string nodeName)

        {
            var node = Find(nodeName);

            DoubleNode<string> previous = null;
            INode<DoubleNode<string>> current = (INode<DoubleNode<string>>)head;
            while (current != null)
            {
                if (current == node)
                {
                   var head = current.Next;
                }
                if (current.Next == node)
                {
                    previous = current.Data;
                    previous.Next = current.Next.Next.Data;
                    if (current.Next != null)
                    {
                        var Next = current.Next;
                        Next.Data.Previous = current.Data;
                    }
                }
                current = current.Next;

            }
        }

        public override void Add(string data)
        {
            if (head == null)
            {
                var head = new DoubleNode<string>
                {
                    Data = data,
                    Next = null,
                    Previous = null
                };
            }
            else
            {
                var toAdd = new DoubleNode<string>
                {
                    Data = data
                };

                var current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }

                current.Next.Data = toAdd;
                toAdd.Previous = (DoubleNode<string>)current;
            }
        }
    }
}