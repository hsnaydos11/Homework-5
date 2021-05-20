﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLibrary
{
    public class Kruskal
    {
        public class GFG
        {

            public static int V = 5;
            public static int[] parent = new int[V];
            public static int INF = int.MaxValue;

            // Find set of vertex i
            public static int find(int i)
            {
                while (parent[i] != i)
                    i = parent[i];
                return i;
            }

            // Does union of i and j. It returns
            // false if i and j are already in same
            // set.
            public static void union1(int i, int j)
            {
                int a = find(i);
                int b = find(j);
                parent[a] = b;
            }

            // Finds MST using Kruskal's algorithm
            public static int kruskalMST(int[,] cost)
            {
                int mincost = 0; // Cost of min MST.

                // Initialize sets of disjoint sets.
                for (int i = 0; i < V; i++)
                    parent[i] = i;

                // Include minimum weight edges one by one
                int edge_count = 0;
                while (edge_count < V - 1)
                {
                    int min = INF, a = -1, b = -1;
                    for (int i = 0; i < V; i++)
                    {
                        for (int j = 0; j < V; j++)
                        {
                            if (find(i) != find(j) && cost[i, j] < min)
                            {
                                min = cost[i, j];
                                a = i;
                                b = j;
                            }
                        }
                    }

                    union1(a, b);
                    Console.Write("Edge {0}:({1}, {2}) cost:{3} \n",
                        edge_count++, a, b, min);
                    mincost += min;
                }
                Console.Write("\n Minimum cost= {0} \n", mincost);
                return 0;
            }

            // Driver code
            public static void Main(String[] args)
            {
                /* Let us create the following graph
                        2 3
                    (0)--(1)--(2)
                    | / \ |
                    6| 8/ \5 |7
                    | /     \ |
                    (3)-------(4)
                            9         */
                int[,] cost = {
        { INF, 2, INF, 6, INF },
        { 2, INF, 3, 8, 5 },
        { INF, 3, INF, INF, 7 },
        { 6, 8, INF, INF, 9 },
        { INF, 5, 7, 9, INF },
    };

                // Print the solution
                kruskalMST(cost);
            }
        }
    }
}
