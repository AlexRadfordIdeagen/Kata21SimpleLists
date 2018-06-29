using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLists
{
    public class SinglyLinkedList
    {
        private SingleNode head;

        public void Print()
        {
            SingleNode current = head;
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
            SingleNode current = head;

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
            SingleNode current = head;
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

            SingleNode previous = null, current = head;
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

                }
                current = current.next;

            }
        }

        public SingleNode Find(string search)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return null;

            }
            else
            {
                SingleNode current = head;

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
                head = new SingleNode
                {
                    data = data,
                    next = null
                };
            }
            else
            {
                SingleNode toAdd = new SingleNode
                {
                    data = data
                };

                SingleNode current = head;
                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = toAdd;
            }
        }
    }
}