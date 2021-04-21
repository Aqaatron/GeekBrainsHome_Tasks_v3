using System;
using System.Collections.Generic;
using System.Text;

namespace prac6
{
    public class Graph
    {
        public string Name { get; set; }
        public List<Node> Nodes { get; set; }


        public Graph(string name)
        {
            this.Name = name;
            this.Nodes = new List<Node>();
        }

        public void Add_Node(string name)
        {
            Node node = new Node
            {
                Name = name,
                Edges = new List<Edge>()
            };

            Nodes.Add(node);

        }

        public void Add_Link(string name_output, string name_input, int weight)
        {
            var output = new Node();

            var input = new Node();

            foreach (var Node in Nodes)
            {
                if (Node.Name == name_output)
                {
                    output = Node;
                }

                if (Node.Name == name_input)
                {
                    input = Node;
                }
            }

            output.Edges.Add(new Edge
            {
                Weight = weight,
                Node = input

            });

            


        }

        public List<String> BFS(string start_Edge_name)
        {
            var bufer = new Queue<Node>();

            var Visited = new List<string>();


            foreach(var node in Nodes)
            {
                if (node.Name == start_Edge_name)
                    bufer.Enqueue(node);
            }


            while (bufer.Count!=0)
            {
                var temp = bufer.Dequeue();

                int k = 0;

                foreach(var str in Visited)
                {
                    if (str == temp.Name)
                        k++;                   
                }

                if (k == 0)
                    Visited.Add(temp.Name);



                foreach (var edge in temp.Edges)
                {
                    if (k==0)
                    bufer.Enqueue(edge.Node);
                }
    
            }

            return Visited;  
                
        }


        public List<String> DFS(string start_Edge_name)
        {
            var bufer = new Stack<Node>();

            var Visited = new List<string>();


            foreach (var node in Nodes)
            {
                if (node.Name == start_Edge_name)
                    bufer.Push(node);
            }


            while (bufer.Count != 0)
            {
                var temp = bufer.Pop();

                int k = 0;

                foreach (var str in Visited)
                {
                    if (str == temp.Name)
                        k++;
                }

                if (k == 0)
                    Visited.Add(temp.Name);



                foreach (var edge in temp.Edges)
                {
                    if (k == 0)
                        bufer.Push(edge.Node);
                }

            }

            return Visited;

        }


    }

    
}
