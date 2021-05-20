using Microsoft.VisualStudio.TestTools.UnitTesting;
using CsharpLibrary;
using System;

namespace CsharpLibraryTest
{
    [TestClass]
    public class KruskalTest
    {
        [TestMethod]
        public void Ugly()
        {
            //The first result part takes the entered data,
            //the second result represents the output data.
            //Then the equality looks at the situation by comparing them to each other.
            CsharpLibrary.Kruskal.GFG krs = new CsharpLibrary.Kruskal.GFG();
            int INF = CsharpLibrary.Kruskal.GFG.INF;
            int[,] cost = {
        { INF, 0, INF, 5, INF },
        { 2, INF, 3, 8, 5 },
        { INF, 3, 6, INF, 7 },
        { 6, 8, INF, 0, 9 },
        { INF, 5, 7, 0, INF },
    };

            // Print the solution
            int result = Kruskal.GFG.kruskalMST(cost);

            int[,] cost1 = {
        { INF, 2, INF, 1, INF },
        { 2, INF, 3, 2, 5 },
        { INF, 3, INF, INF, 7 },
        { 6, 8, 0, INF, 9 },
        { 9, INF, INF, INF, 4 },
    };
            int result1 = Kruskal.GFG.kruskalMST(cost1);

            Assert.AreNotEqual(cost, cost1);
        }
        [TestMethod]
        public void Good()
        {
            CsharpLibrary.Kruskal.GFG krs = new CsharpLibrary.Kruskal.GFG();
            int INF = CsharpLibrary.Kruskal.GFG.INF;
            int[,] cost = {
        { INF, 2, INF, 6, INF },
        { 2, INF, 3, 8, 5 },
        { INF, 3, INF, INF, 7 },
        { 6, 8, INF, INF, 9 },
        { INF, 5, 7, 9, INF },
    };

            // Print the solution
            int result = Kruskal.GFG.kruskalMST(cost);

            int[,] cost1 = {
        { INF, 2, INF, 6, INF },
        { 2, INF, 3, 8, 5 },
        { INF, 3, INF, INF, 7 },
        { 6, 8, INF, INF, 9 },
        { INF, 5, 7, 9, INF },
    };
            int result1 = Kruskal.GFG.kruskalMST(cost1);

            Assert.AreEqual(cost, cost1);
        }
        [TestMethod]
        public void Bad()
        {
            CsharpLibrary.Kruskal.GFG krs = new CsharpLibrary.Kruskal.GFG();
            int INF = CsharpLibrary.Kruskal.GFG.INF;
            int[,] cost = {
        { 0, 2, 5, 6, INF },
        { 2, INF, 3, INF, 5 },
        { INF, 3, INF, INF, 7 },
        { 6, INF, INF, INF, 9 },
        { INF, INF, 7, INF, INF },
    };

            // Print the solution
            int result = Kruskal.GFG.kruskalMST(cost);

            int[,] cost1 = {
        { 0, 2, 5, 6, INF },
        { 2, INF, 3, INF, 5 },
        { INF, 3, INF, INF, 7 },
        { 6, INF, INF, INF, 9 },
        { INF, INF, 7, INF, INF },
    };
            int result1 = Kruskal.GFG.kruskalMST(cost1);

            Assert.AreNotSame(cost, cost1);
        }

    }
}
