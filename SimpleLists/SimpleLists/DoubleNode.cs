using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLists
{
     public class DoubleNode<T> : SingleNode<T>
    {
        public DoubleNode<T> Previous;
    }
}