using System;

namespace prac5
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree MyTree = new Tree();

            MyTree.AddItem(5);

            MyTree.AddItem(10);

            MyTree.AddItem(3);

            MyTree.AddItem(15);

            MyTree.AddItem(15);

            MyTree.AddItem(4);

            MyTree.AddItem(25);

            MyTree.AddItem(26);


            var find1 = MyTree.BFS(4);
             
            var find2 = MyTree.DFS(4);

            //var finded_node = MyTree.BFS(4);



        }
    }
}
