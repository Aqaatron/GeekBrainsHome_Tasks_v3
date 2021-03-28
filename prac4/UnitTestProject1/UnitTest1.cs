using Microsoft.VisualStudio.TestTools.UnitTesting;
using task2;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodAddItem()
        {
            Tree MyTree = new Tree();

            MyTree.AddItem(5);

            Assert.AreEqual(5, MyTree.Head.Value);

            Assert.AreEqual(null, MyTree.Head.RightChild);

            Assert.AreEqual(null, MyTree.Head.LeftChild);

            MyTree.AddItem(10);

            Assert.AreEqual(10, MyTree.Head.RightChild.Value);

            Assert.AreEqual(null, MyTree.Head.LeftChild);

            MyTree.AddItem(4);

            Assert.AreEqual(10, MyTree.Head.RightChild.Value);

            Assert.AreEqual(null, MyTree.Head.RightChild.RightChild);

            Assert.AreEqual(null, MyTree.Head.RightChild.LeftChild);

            Assert.AreEqual(4, MyTree.Head.LeftChild.Value);


            MyTree.AddItem(4);

            Assert.AreEqual(10, MyTree.Head.RightChild.Value);

            Assert.AreEqual(null, MyTree.Head.RightChild.RightChild);

            Assert.AreEqual(null, MyTree.Head.RightChild.LeftChild);

            Assert.AreEqual(4, MyTree.Head.LeftChild.Value);


        }

        [TestMethod]
        public void TestMethodRemoveItem()
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

            Assert.AreEqual(5, MyTree.Head.Value);

            Assert.AreEqual(10, MyTree.Head.RightChild.Value);

            Assert.AreEqual(3, MyTree.Head.LeftChild.Value);

            MyTree.RemoveItem(10);

            Assert.AreEqual(5, MyTree.Head.Value);

            Assert.AreEqual(15, MyTree.Head.RightChild.Value);

            Assert.AreEqual(3, MyTree.Head.LeftChild.Value);

        }

        public void TestMethodGetNodeByValue()
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

            TreeNode find_node = MyTree.GetNodeByValue(26);

            Assert.AreEqual(26, find_node.Value);

            Assert.AreEqual(null, find_node.RightChild);

            Assert.AreEqual(null, find_node.LeftChild);


            find_node = MyTree.GetNodeByValue(15);

            Assert.AreEqual(15, find_node.Value);

            Assert.AreEqual(25, find_node.RightChild.Value);

            Assert.AreEqual(null, find_node.LeftChild);

        }
    }
}
