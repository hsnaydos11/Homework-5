using Microsoft.VisualStudio.TestTools.UnitTesting;
using CsharpLibrary;
using System;

namespace CsharpLibraryTest
{
    [TestClass]
    public class BellmanFORDTest
    {
        [TestMethod]
        public void Ugly()
        {
            //The first result part takes the entered data,
            //the second result represents the output data.
            //Then the equality looks at the situation by comparing them to each other.
            int V = 5; // Number of vertices in graph
            int E = 3; // Number of edges in graph

            CsharpLibrary.BellmanFORD.Graph graph = new CsharpLibrary.BellmanFORD.Graph(V, E);

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

            int result = graph.BellmanFord(graph, 0);

            CsharpLibrary.BellmanFORD.Graph graph1 = new CsharpLibrary.BellmanFORD.Graph(V, E);

            graph1.edge[0].src = -1;
            graph1.edge[0].dest = 0;
            graph1.edge[0].weight = 1;

            // add edge 0-2 (or A-C in above figure)
            graph1.edge[1].src = 4;
            graph1.edge[1].dest = 2;
            graph1.edge[1].weight = 0;

            // add edge 1-2 (or B-C in above figure)
            graph1.edge[2].src = 3;
            graph1.edge[2].dest = 1;
            graph1.edge[2].weight = 2;

            int result1 = graph1.BellmanFord(graph1, 0);

            Assert.AreEqual(result, result1);
        }
        [TestMethod]
        public void Good()
        {
            int V = 5; // Number of vertices in graph
            int E = 3; // Number of edges in graph

            CsharpLibrary.BellmanFORD.Graph graph = new CsharpLibrary.BellmanFORD.Graph(V, E);

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

            int result = graph.BellmanFord(graph, 0);

            CsharpLibrary.BellmanFORD.Graph graph1 = new CsharpLibrary.BellmanFORD.Graph(V, E);

            graph1.edge[0].src = 0;
            graph1.edge[0].dest = 1;
            graph1.edge[0].weight = -1;

            // add edge 0-2 (or A-C in above figure)
            graph1.edge[1].src = 0;
            graph1.edge[1].dest = 2;
            graph1.edge[1].weight = 4;

            // add edge 1-2 (or B-C in above figure)
            graph1.edge[2].src = 1;
            graph1.edge[2].dest = 2;
            graph1.edge[2].weight = 3;

            int result1 = graph1.BellmanFord(graph1, 0);

            Assert.AreEqual(result, result1);
        }
        [TestMethod]
        public void Bad()
        {
            int V = 5; // Number of vertices in graph
            int E = 3; // Number of edges in graph

            CsharpLibrary.BellmanFORD.Graph graph = new CsharpLibrary.BellmanFORD.Graph(V, E);

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

            int result = graph.BellmanFord(graph, 0);

            CsharpLibrary.BellmanFORD.Graph graph1 = new CsharpLibrary.BellmanFORD.Graph(V, E);

            graph1.edge[0].src = -1;
            graph1.edge[0].dest = 0;
            graph1.edge[0].weight = 1;

            // add edge 0-2 (or A-C in above figure)
            graph1.edge[1].src = 4;
            graph1.edge[1].dest = 2;
            graph1.edge[1].weight = 0;

            // add edge 1-2 (or B-C in above figure)
            graph1.edge[2].src = 3;
            graph1.edge[2].dest = 1;
            graph1.edge[2].weight = 2;

            int result1 = graph1.BellmanFord(graph1, 0);

            Assert.AreNotEqual(result, result1);
        }
    }
}
