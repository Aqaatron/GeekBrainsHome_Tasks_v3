using System;
using System.Collections.Generic;
using System.Text;

namespace prac6
{
    class Program
    {
        static void Main(string[] args)
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

            var vis1 = test_graph.BFS("B");

            var vis2 = test_graph.DFS("B");
        }
    }
}
