using SimpleLists;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleListsNetCore
{
    public class Queue
    {
        private QueueNode _head;
        private QueueNode _tail;
        private int _count = 0;

        public Queue() { }
        public void Enqueue(string data)
        {
            QueueNode _newNode = new QueueNode(data);
            if (_head == null)
            {
                _head = _newNode;
                _tail = _head;
            }
            else
            {
                _tail.Next = _newNode;
                _tail = _tail.Next;
            }
            _count++;
        }

        public string[] Values()
        {
            int i = 0;
            var current = _head;
             string[] result = new string[Count()];
            while (current != null)
            {
                result[i] = current.Data;
                i++;
                current = current.Next;
            }
            return result;
        }
        public string Dequeue()
        {
            if (_head == null)
            {
                throw new Exception("Queue is Empty");
            }
            string _result = _head.Data;
            _head = _head.Next;
            return _result;
        }
        public int Count()
        {
            var current = _head;
            int result = 0;
            while (current != null)
            {
                result++;
                current = current.Next;
            }
            return result;
        }

        public QueueNode Peek()
        {
            return _head;
        }
    }
}
