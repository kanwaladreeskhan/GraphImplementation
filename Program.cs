using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Graph g = new Graph(5);
            g.AddEdges(0, 1);
            g.AddEdges(0, 4);
            g.AddEdges(1, 2);
            g.AddEdges(1, 4);
            g.AddEdges(2, 3);
            g.AddEdges(2, 4);
            g.AddEdges(3, 4);
            g.PrintGraph();
            g.BFS(0);
        }
    }
}
