using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLists
{
    public class LinkedList<T> where  T : INode<T>
    {
        public INode<T> head;
    }
}
