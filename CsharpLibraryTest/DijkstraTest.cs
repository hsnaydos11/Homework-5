using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CsharpLibraryTest
{
    [TestClass]
    public class DijkstraTest
    {
        [TestMethod]
        public void Ugly()
        {
            //The first result part takes the entered data,
            //the second result represents the output data.
            //Then the equality looks at the situation by comparing them to each other.
            int[,] graph = new int[,] { { 0, 0, 4, 14, 10, 0, 2, 0, 0  },
                                      { 4, 0, 8, 1, 0, 0, 0, 11, 0 },
                                      { 0, 8, 0, 7, 4, 4, 0, 0, 2 },
                                      { 0, 0, 7, 0, 9, 14, 0, 6, 0 },
                                      { 0, 0, 0, 9, 0, 10, 0, 0, 5 },
                                      { 4, 0, 8, 0, 0, 0, 0, 11, 0},
                                      { 0, 0, 2, 0, 0, 2, 0, 1, 6 },
                                      { 8, 0, 0, 0, 0, 0, 1, 0, 7 },
                                      { 0, 0, 2, 2, 0, 2, 6, 7, 1 } };
            CsharpLibrary.Dijkstra.GFG t = new CsharpLibrary.Dijkstra.GFG();
            int result = t.dijkstra(graph, 0);

            int[,] graph1 = new int[,] { { 0, 4, 0, 0, 0, 0, 0, 8, 0 },
                                      { 4, 0, 8, 0, 0, 0, 0, 11, 0 },
                                      { 0, 8, 0, 7, 0, 4, 0, 0, 2 },
                                      { 0, 0, 7, 0, 9, 14, 0, 0, 0 },
                                      { 0, 0, 0, 9, 0, 10, 0, 0, 0 },
                                      { 0, 0, 4, 14, 10, 0, 2, 0, 0 },
                                      { 0, 0, 0, 0, 0, 2, 0, 1, 6 },
                                      { 8, 11, 0, 0, 0, 0, 1, 0, 7 },
                                      { 0, 0, 2, 0, 0, 0, 6, 7, 0 } };
            CsharpLibrary.Dijkstra.GFG t1 = new CsharpLibrary.Dijkstra.GFG();
            int result1 = t1.dijkstra(graph, 0);

            Assert.AreNotEqual(result, result1);

        }

        [TestMethod]
        public void Good()
        {
            int[,] graph = new int[,] { { 0, 4, 0, 0, 0, 0, 0, 8, 0 },
                                      { 4, 0, 8, 0, 0, 0, 0, 11, 0 },
                                      { 0, 8, 0, 7, 0, 4, 0, 0, 2 },
                                      { 0, 0, 7, 0, 9, 14, 0, 0, 0 },
                                      { 0, 0, 0, 9, 0, 10, 0, 0, 0 },
                                      { 0, 0, 4, 14, 10, 0, 2, 0, 0 },
                                      { 0, 0, 0, 0, 0, 2, 0, 1, 6 },
                                      { 8, 11, 0, 0, 0, 0, 1, 0, 7 },
                                      { 0, 0, 2, 0, 0, 0, 6, 7, 0 } };
            CsharpLibrary.Dijkstra.GFG t = new CsharpLibrary.Dijkstra.GFG();
            int result = t.dijkstra(graph, 0);

            int[,] graph1 = new int[,] { { 0, 4, 0, 0, 0, 0, 0, 8, 0 },
                                      { 4, 0, 8, 0, 0, 0, 0, 11, 0 },
                                      { 0, 8, 0, 7, 0, 4, 0, 0, 2 },
                                      { 0, 0, 7, 0, 9, 14, 0, 0, 0 },
                                      { 0, 0, 0, 9, 0, 10, 0, 0, 0 },
                                      { 0, 0, 4, 14, 10, 0, 2, 0, 0 },
                                      { 0, 0, 0, 0, 0, 2, 0, 1, 6 },
                                      { 8, 11, 0, 0, 0, 0, 1, 0, 7 },
                                      { 0, 0, 2, 0, 0, 0, 6, 7, 0 } };
            CsharpLibrary.Dijkstra.GFG t1 = new CsharpLibrary.Dijkstra.GFG();
            int result1 = t1.dijkstra(graph, 0);

            Assert.AreEqual(result, result1);
        }

        [TestMethod]
        public void Bad()
        {
            int[,] graph = new int[,] { { 0, 0, 4, 14, 10, 0, 2, 0, 0  },
                                      { 4, 0, 8, 1, 0, 0, 0, 11, 0 },
                                      { 0, 8, 0, 7, 4, 4, 0, 0, 2 },
                                      { 0, 0, 7, 0, 9, 14, 0, 6, 0 },
                                      { 0, 0, 0, 9, 0, 10, 0, 0, 5 },
                                      { 4, 0, 8, 0, 0, 0, 0, 11, 0},
                                      { 0, 0, 2, 0, 0, 2, 0, 1, 6 },
                                      { 8, 0, 0, 0, 0, 0, 1, 0, 7 },
                                      { 0, 0, 2, 2, 0, 2, 6, 7, 1 } };
            CsharpLibrary.Dijkstra.GFG t = new CsharpLibrary.Dijkstra.GFG();
            int result = t.dijkstra(graph, 0);

            int[,] graph1 = new int[,] { { 0, 4, 0, 0, 0, 0, 0, 8, 0 },
                                      { 4, 0, 8, 0, 0, 0, 0, 11, 0 },
                                      { 0, 8, 0, 7, 0, 4, 0, 0, 2 },
                                      { 0, 0, 7, 0, 9, 14, 0, 0, 0 },
                                      { 0, 0, 0, 9, 0, 10, 0, 0, 0 },
                                      { 0, 0, 4, 14, 10, 0, 2, 0, 0 },
                                      { 0, 0, 0, 0, 0, 2, 0, 1, 6 },
                                      { 8, 11, 0, 0, 0, 0, 1, 0, 7 },
                                      { 0, 0, 2, 0, 0, 0, 6, 7, 0 } };
            CsharpLibrary.Dijkstra.GFG t1 = new CsharpLibrary.Dijkstra.GFG();
            int result1 = t1.dijkstra(graph, 0);

            Assert.IsFalse(result == result1);
        }
    }
}
