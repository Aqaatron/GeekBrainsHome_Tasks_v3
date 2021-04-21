using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using System.Text;
using prac6;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BFS()
        {
            Graph test_graph = new Graph("test");

            test_graph.Add_Node("A");

            test_graph.Add_Node("B");

            test_graph.Add_Node("C");

            test_graph.Add_Node("D");

            test_graph.Add_Link("A", "B", 4);

            test_graph.Add_Link("D", "A", 5);

            test_graph.Add_Link("B", "D", 6);

            test_graph.Add_Link("D", "B", 6);

            test_graph.Add_Link("B", "C", 3);

            test_graph.Add_Link("C", "C", 2);

            var vis = test_graph.BFS("B");

            string result = "B";

            Assert.AreEqual(result, vis[0]);


            result = "D";

            Assert.AreEqual(result, vis[1]);

            result = "C";

            Assert.AreEqual(result, vis[2]);


            result = "A";

            Assert.AreEqual(result, vis[3]);

        }
        [TestMethod]
        public void DFS()
        {
            Graph test_graph = new Graph("test");

            test_graph.Add_Node("A");

            test_graph.Add_Node("B");

            test_graph.Add_Node("C");

            test_graph.Add_Node("D");

            test_graph.Add_Link("A", "B", 4);

            test_graph.Add_Link("D", "A", 5);

            test_graph.Add_Link("B", "D", 6);

            test_graph.Add_Link("D", "B", 6);

            test_graph.Add_Link("B", "C", 3);

            test_graph.Add_Link("C", "C", 2);

            var vis = test_graph.DFS("B");

            string result = "B";

            Assert.AreEqual(result, vis[0]);


            result = "C";

            Assert.AreEqual(result, vis[1]);

            result = "D";

            Assert.AreEqual(result, vis[2]);


            result = "A";

            Assert.AreEqual(result, vis[3]);

        }
    }
}
