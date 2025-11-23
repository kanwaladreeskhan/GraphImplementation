using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphImplementation
{
    internal class Graph
    {
        private int vertices;
        private Node[] adjacecyList;
        public Graph(int vertices)
        {
            this.vertices = vertices;
            adjacecyList = new Node[vertices];
        }
        public void AddEdges(int src, int dst)
        {
            Node newnode = new Node(dst);
            newnode.next = adjacecyList[src];
            adjacecyList[src] = newnode;

            Node newnode1 = new Node(src);
            newnode1.next = adjacecyList[dst];
            adjacecyList[dst] = newnode1;
        }
        public void PrintGraph()
        {
            for (int i = 0; i < vertices; i++)
            {
                Console.Write("Vertex " + i + " -> ");
                Node temp=adjacecyList[i];
                while (temp != null) 
                {
                    Console.Write(temp.vertex + " ");
                    temp=temp.next;
                }
                Console.WriteLine();
            }
        }
        public void BFS(int start)
        {
            bool[]visited= new bool[vertices];
            Queue<int>queue= new Queue<int>();
            visited[start] = true;
            queue.Enqueue(start);
            Console.WriteLine("BFS Traversal:");
            while (queue.Count > 0)
            {
                int current = queue.Dequeue();
                Console.Write(current + " ");
                Node temp= adjacecyList[current];
                while (temp != null)
                {
                    if (!visited[temp.vertex])
                    {
                        visited[temp.vertex]=true;
                        queue.Enqueue(temp.vertex);
                    }
                    temp = temp.next;
                }
            } 
            Console.WriteLine() ;
        }
    }
}
