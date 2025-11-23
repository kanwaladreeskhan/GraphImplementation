using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphImplementation
{
    internal class Node
    {
        public int vertex;
        public Node next;
        public Node(int vertex)
        {
            this.vertex = vertex;
            next = null;
        }
    }
}
