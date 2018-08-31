using System;
namespace SimpleLists
{
    public class SinglyLinkedList : LinkedList<SingleNode>
    {

        public void Print()
        {
            var current = head;

            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }


        public string[] Values()
        {
            int i = 0;
            int count = Count();
            var current = head;

            string[] result = new string[count];

            while (current != null)
            {
                result[i] = current.Data;
                if (current.Next == null)
                {
                    break;
                }
                else
                {
                    current = current.Next;
                }
                
                i++;

            }
            return result;
        }

        public int Count()
        {
            int i = 0;
           var current = head;
            while (current != null)
            {
                i++;
                current = current.Next;
            }
            return i;
        }

        public virtual void Delete(string nodeName)
        {

            var node = Find(nodeName);

           SingleNode<string> previous = null, current = head;
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

                }
                current = current.Next;

            }
        }

        public INode<SingleNode<string>> Find(string search)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return null;

            }
            else
            {
                var current = head;

                while (current != null)
                {
                    if (current.Data.ToString() == search)
                    {
                        return (INode<SingleNode<string>>)current;
                    }
                    current = current.Next;

                }
                return null;
            }
        }

        public virtual void Add(string data)
        {
            if (head == null)
            {
               var head = new SingleNode<string>()
                {
                    Data = data,
                    Next = null
                };
            }
            else
            {
                var toAdd = new SingleNode<string>()
                {
                    Data = data
                };

                var current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = toAdd;
            }
        }
    }
}