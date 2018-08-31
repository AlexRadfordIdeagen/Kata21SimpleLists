using System;


namespace SimpleLists
{
    public class DoublyLinkedList : SinglyLinkedList
    {
        private DoubleNode<string> head;

  

        public override void Delete(string nodeName)

        {
            var node = Find(nodeName);

            DoubleNode<string> previous = null, current = head;
            while (current != null)
            {
                if (current == node)
                {
                    head = (DoubleNode<string>)current.next;
                }
                if (current.next == node)
                {
                    previous = current;
                    previous.next = current.next.next;
                    if (current.next != null)
                    {
                        var next = (DoubleNode<string>)current.next;
                        next.previous = current;
                    }
                }
                current = (DoubleNode<string>)current.next;

            }
        }

        public override void Add(string data)
        {
            if (head == null)
            {
                head = new DoubleNode<string>
                {
                    data = data,
                    next = null,
                    previous = null
                };
            }
            else
            {
                DoubleNode<string> toAdd = new DoubleNode<string>
                {
                    data = data
                };

                DoubleNode<string> current = head;
                while (current.next != null)
                {
                    current = (DoubleNode<string>)current.next;
                }

                current.next = toAdd;
                toAdd.previous = current;
            }
        }
    }
}