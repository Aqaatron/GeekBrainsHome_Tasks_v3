using Microsoft.VisualStudio.TestTools.UnitTesting;
using prac5;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodBFS()
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

            var find = MyTree.BFS(5);

            Assert.AreEqual(5, find.Value);

            find = MyTree.BFS(10);

            Assert.AreEqual(10, find.Value);

            find = MyTree.BFS(3);

            Assert.AreEqual(3, find.Value);

            find = MyTree.BFS(15);

            Assert.AreEqual(15, find.Value);

            find = MyTree.BFS(4);

            Assert.AreEqual(4, find.Value);

            find = MyTree.BFS(25);

            Assert.AreEqual(25, find.Value);

            find = MyTree.BFS(26);

            Assert.AreEqual(26, find.Value);
        }

        [TestMethod]
        public void TestMethodDFS()
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

            var find = MyTree.DFS(5);

            Assert.AreEqual(5, find.Value);

            find = MyTree.DFS(10);

            Assert.AreEqual(10, find.Value);

            find = MyTree.DFS(3);

            Assert.AreEqual(3, find.Value);

            find = MyTree.DFS(15);

            Assert.AreEqual(15, find.Value);

            find = MyTree.DFS(4);

            Assert.AreEqual(4, find.Value);

            find = MyTree.DFS(25);

            Assert.AreEqual(25, find.Value);

            find = MyTree.DFS(26);

            Assert.AreEqual(26, find.Value);
        }
    }
}
