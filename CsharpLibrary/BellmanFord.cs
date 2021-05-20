using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLibrary
{
    public class BellmanFORD
    {
        public class Graph
        {
            // it is written to define the edges in the graph.
            public class Edge
            {
                public int src, dest, weight;
                public Edge()
                {
                    src = dest = weight = 0;
                }
            }

            public int V, E;  //public is put in order to share.
            public Edge[] edge;

            // Creates a graph with V vertices and E edges
            public Graph(int v, int e)
            {
                V = v;
                E = e;
                edge = new Edge[e];
                for (int i = 0; i < e; ++i)
                    edge[i] = new Edge();
            }

            //The main function is to find the shortest path from all corners using bellman ford.
            public int BellmanFord(Graph graph, int src)
            {
                int V = graph.V, E = graph.E;
                int[] dist = new int[V];

                // Initialize distances from src to all other vertices as INFINITE
                for (int i = 0; i < V; ++i)
                    dist[i] = int.MaxValue;
                dist[src] = 0;

                // Relax all edges |V| - 1 times. A simple
                // shortest path from src to any other vertex can
                // have at-most |V| - 1 edges
                for (int i = 1; i < V; ++i)
                {
                    for (int j = 0; j < E; ++j)
                    {
                        int u = graph.edge[j].src;
                        int v = graph.edge[j].dest;
                        int weight = graph.edge[j].weight;
                        if (dist[u] != int.MaxValue && dist[u] + weight < dist[v])
                            dist[v] = dist[u] + weight;
                    }
                }

                //It is the function written to control negative loops. If there is no negative loop, it allows to find the shortest path.
                for (int j = 0; j < E; ++j)
                {
                    int u = graph.edge[j].src;
                    int v = graph.edge[j].dest;
                    int weight = graph.edge[j].weight;
                    if (dist[u] != int.MaxValue && dist[u] + weight < dist[v])
                    {
                        Console.WriteLine("Graph contains negative weight cycle");
                        return 0;
                    }
                }
                printArr(dist, V);
                return 0;
            }

            // A utility function used to print the solution
            public void printArr(int[] dist, int V)
            {
                Console.WriteLine("Vertex Distance from Source");
                for (int i = 0; i < V; ++i)
                    Console.WriteLine(i + "\t\t" + dist[i]);
            }

            // Driver method to test above function
            public static void Main()
            {
                int V = 5; // Number of vertices in graph
                int E = 3; // Number of edges in graph

                Graph graph = new Graph(V, E);

                // add edge 0-1 (or A-B in above figure)
                graph.edge[0].src = 0;
                graph.edge[0].dest = 1;
                graph.edge[0].weight = -1;

                // add edge 0-2 (or A-C in above figure)
                graph.edge[1].src = 0;
                graph.edge[1].dest = 2;
                graph.edge[1].weight = 4;

                // add edge 1-2 (or B-C in above figure)
                graph.edge[2].src = 1;
                graph.edge[2].dest = 2;
                graph.edge[2].weight = 3;

                graph.BellmanFord(graph, 0);
            }
        }
    }
}
