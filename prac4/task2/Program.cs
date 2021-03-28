using System;

namespace task2
{
    class Program
    {
        //public static void printBranchs(int margin, int level)
        //{
        //    Console.SetCursorPosition(margin - 2, level);
        //    Console.Write("/");
        //    Console.SetCursorPosition(margin + 2, level);
        //    Console.Write("\\");
        //    Console.SetCursorPosition(margin - 3, level + 1);
        //    Console.Write("/");
        //    Console.SetCursorPosition(margin + 3, level + 1);
        //    Console.Write("\\");
        //}
        //public static void Print(Node<int> p, int margin)
        //{
        //    int level = 1;
        //    if (p != null)
        //    {
        //        Console.SetCursorPosition(margin, 0);
        //        Console.Write(p.Data.ToString());

        //        printBranchs(margin, 1);

        //        if (p.Right != null)
        //        {
        //            level = level + 2;
        //            Print(p.Right, margin + 6);
        //        }
        //        //else
        //        //{
        //        //    Console.WriteLine(p.Data.ToString().PadLeft(padding + 6));
        //        //}

        //        //Console.SetCursorPosition(49, 0);
        //        //    if (padding > 0)
        //        //    {
        //        //        Console.Write(" ".PadLeft(padding));
        //        //    }
        //        //    if (p.Right != null)
        //        //    {
        //        //        Console.Write("/\n");
        //        //        Console.Write(" ".PadLeft(padding));
        //        //    }

        //        //if (p.Left != null)
        //        //{
        //        //    Print(p.Left, padding - 6);
        //        //}
        //    }
        //}
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

            MyTree.RemoveItem(5);

            //MyTree.AddItem(2);

            //MyTree.AddItem(1);

            //MyTree.AddItem(0);

            //MyTree.AddItem(13);

            //MyTree.PrintTree();

            //TreeNode Find = MyTree.GetNodeByValue(13);

            //TreeHelper treeHelper = new TreeHelper();

            //NodeInfo[] node_info;

            //node_info = treeHelper.GetTreeInLine(MyTree);


            //int[] mas;

            //mas = treeHelper.GetTreeInLine(MyTree);

            //MyTree.RemoveItem(15);

            //MyTree.RemoveItem(2);

            Console.ReadLine();
        }
    }
}
