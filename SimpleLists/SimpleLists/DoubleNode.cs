using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLists
{
     public class DoubleNode<T>
    {
        public DoubleNode<T> next;
        public DoubleNode<T> previous;
        public T data;
    }
}