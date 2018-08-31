using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLists
{
    public class INode<T>
    {
        public INode<T> next;
        public T data;
    }
}
