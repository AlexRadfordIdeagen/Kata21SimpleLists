using System;


namespace SimpleLists
{
    public class DoublyLinkedList
    {
        private DoubleNode head;

        public void Print()
        {
            DoubleNode current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }


        public string[] Values()
        {
            int i = 0;
            int count = Count();
            DoubleNode current = head;

            string[] result = new string[count];

            while (current != null)
            {
                result[i] = current.data;
                if (current.next == null)
                {
                    break;
                }
                else
                {
                    current = current.next;
                }

                i++;

            }
            return result;
        }

        public int Count()
        {
            int i = 0;
            DoubleNode current = head;
            while (current != null)
            {
                i++;
                current = current.next;
            }
            return i;
        }

        public void Delete(string nodeName)

        {
            var node = Find(nodeName);

            DoubleNode previous = null, current = head;
            while (current != null)
            {
                if (current == node)
                {
                    head = current.next;
                }
                if (current.next == node)
                {
                    previous = current;
                    previous.next = current.next.next;
                    if (current.next != null)
                    {
                        current.next.previous = current;
                    }
                }
                current = current.next;

            }
        }

        public DoubleNode Find(string search)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return null;

            }
            else
            {
                DoubleNode current = head;

                while (current != null)
                {
                    if (current.data.ToString() == search)
                    {
                        return current;
                    }
                    current = current.next;

                }
                return null;
            }
        }

        public void Add(string data)
        {
            if (head == null)
            {
                head = new DoubleNode
                {
                    data = data,
                    next = null,
                    previous = null
                };
            }
            else
            {
                DoubleNode toAdd = new DoubleNode
                {
                    data = data
                };

                DoubleNode current = head;
                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = toAdd;
                toAdd.previous = current;
            }
        }
    }
}