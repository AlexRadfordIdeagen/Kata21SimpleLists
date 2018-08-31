namespace SimpleLists
{
    public class DoublyLinkedList : SinglyLinkedList
    {
        public override void Delete(string nodeName)

        {
            var node = Find(nodeName);

            DoubleNode<string> previous = null, current = head;
            while (current != null)
            {
                if (current == node)
                {
                    head = current.Next;
                }
                if (current.Next == node)
                {
                    previous = current;
                    previous.Next = current.Next.Next;
                    if (current.Next != null)
                    {
                        var next = current.Next;
                        next.Previous = current;
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

                current.Next = toAdd;
                toAdd.Previous = current;
            }
        }
    }
}