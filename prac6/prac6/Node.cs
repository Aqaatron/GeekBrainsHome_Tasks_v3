using System;
using System.Collections.Generic;
using System.Text;

namespace prac6
{
    public class Node
    {
        public string Name { get; set; }
        public List<Edge> Edges { get; set; }


        public void Add_Link(int weight, Node node)
        {
            Edges.Add(new Edge
            {
                Weight = weight,
                Node = node
            });
        }

    }
}
