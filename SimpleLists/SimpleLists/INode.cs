using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLists
{
    public interface INode<T>
    {
        T Data
        {
            get;
            set;
        }

        INode<T> Next
        {
            get;
            set;
        }
    }
}
