using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLists
{
     public class QueueNode
    {
        public string Data { get; set; }
        public QueueNode Next { get; set; }
        public QueueNode(string data)
        {
            Data = data;
        }
    }
}
