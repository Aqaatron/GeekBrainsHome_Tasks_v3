using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using task1;

namespace task1_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodAddNode()
        {
            // arrange
            MyList TestList = new MyList();
            
            // act
            TestList.AddNode(5);

            Assert.AreEqual(5, TestList.StartNode.Value);

            Assert.AreEqual(5, TestList.FinishNode.Value);

            Assert.AreEqual(null, TestList.FinishNode.NextNode);

            Assert.AreEqual(null, TestList.StartNode.PrevNode);

            TestList.AddNode(90);

            TestList.AddNode(46);


            //assert
            Assert.AreEqual(5, TestList.StartNode.Value);

            Assert.AreEqual(46, TestList.FinishNode.Value);

            Assert.AreEqual(90, TestList.FinishNode.PrevNode.Value);
        }
        [TestMethod]
        public void TestMethodAddNodeAfter()
        {
            // arrange
            MyList TestList = new MyList();

            // act
            TestList.AddNode(5);

            TestList.AddNode(46);

            TestList.AddNodeAfter(TestList.StartNode, 101);


            //assert
            Assert.AreEqual(5, TestList.StartNode.Value);

            Assert.AreEqual(46, TestList.FinishNode.Value);

            Assert.AreEqual(101, TestList.FinishNode.PrevNode.Value);
        }

        [TestMethod]
        public void TestMethodGetCount()
        {
            // arrange
            MyList TestList = new MyList();

            // act
            TestList.AddNode(5);

            Assert.AreEqual(1, TestList.GetCount());

            TestList.AddNode(46);

            Assert.AreEqual(2, TestList.GetCount());

            TestList.AddNodeAfter(TestList.StartNode, 101);

            Assert.AreEqual(3, TestList.GetCount());

            TestList.RemoveNode(0);

            Assert.AreEqual(2, TestList.GetCount());
        

        }

        [TestMethod]
        public void TestMethodRemoveNode()
        {
            // arrange
            MyList TestList = new MyList();

            // act
            TestList.AddNode(5);

            TestList.AddNode(46);

            TestList.AddNode(95);

            TestList.RemoveNode(1);

            Assert.AreEqual(95, TestList.StartNode.NextNode.Value);

            TestList.AddNode(101);

            TestList.RemoveNode(TestList.StartNode);

            Assert.AreEqual(95, TestList.StartNode.Value);


        }

        [TestMethod]
        public void TestMethodFindNode()
        {
            // arrange
            MyList TestList = new MyList();

            // act
            TestList.AddNode(5);

            TestList.AddNode(46);

            TestList.AddNode(95);

            var find_node = TestList.FindNode(5);

            Assert.AreEqual(46, find_node.NextNode.Value);

            Assert.AreEqual(TestList.StartNode, find_node);

            find_node = TestList.FindNode(45);

            Assert.AreEqual(null, find_node);

        }
    }
}
