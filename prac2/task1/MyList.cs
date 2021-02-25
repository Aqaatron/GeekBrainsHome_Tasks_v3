using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class MyList: ILinkedList
    {

        public Node StartNode { get; set; }

        public Node FinishNode { get; set; }


        public int GetCount()
        {
            int count = 1;
            var node = StartNode;

            while (node.NextNode != null)
            {
                count++;
                node = node.NextNode;
            }

            return count;
        }

        public void AddNodeAfter(Node node, int value)
        {

            var newNode = new Node { Value = value };

            var nextItem = node.NextNode;

            if((node != FinishNode) && (node.NextNode != FinishNode))
            {
                node.NextNode = newNode;

                newNode.NextNode = nextItem;

                newNode.PrevNode = node;
            }
            if(node == FinishNode)
            {
                node.NextNode = newNode;

                newNode.NextNode = nextItem;

                newNode.PrevNode = node;

                FinishNode = newNode;
            }

            if(node.NextNode == FinishNode)
            {
                node.NextNode = newNode;

                newNode.NextNode = nextItem;

                newNode.PrevNode = node;

                FinishNode.PrevNode = newNode;
            }
                
 
        }

        public void AddNode(int value)
        {
            var node = StartNode;

            var newNode = new Node { Value = value };

            if (node == null)
            {
                StartNode = newNode;

                FinishNode = newNode;
            }
            else
            {
                while (node.NextNode != null)
                {
                    node = node.NextNode;
                }



                node.NextNode = newNode;

                newNode.PrevNode = node;

                FinishNode = newNode;
            }
            

        }

        public void RemoveNode(Node node) //удаление
        {
           
            if ((node != StartNode) && (node != FinishNode))
            {
                node.PrevNode.NextNode = node.NextNode;

                node.NextNode.PrevNode = node.PrevNode;

            }

            if (node == StartNode)
            {
                var newStartNode = node.NextNode;

                newStartNode.PrevNode = null;

                node.NextNode = null;

                StartNode = newStartNode;
            }

            if (node == FinishNode)
            {
                var newFinishNode = node.PrevNode;

                newFinishNode.NextNode = null;

                node.PrevNode = null;

                FinishNode = newFinishNode;
            }

        }

        public void RemoveNode(int itemIndex) 
        {
            int currentIndex = 0;

            var currentNode = StartNode;

            if (itemIndex == 0)
            {
                var newStartNode = StartNode.NextNode;

                newStartNode.PrevNode = null;

                StartNode.NextNode = null;

                StartNode = newStartNode;
            }
            else
            {
                while (currentNode != null)
                {
                    if (currentIndex == itemIndex)
                    {
                        RemoveNode(currentNode);
                    }

                    currentNode = currentNode.NextNode;

                    currentIndex++;
                }
            }
           

            
        }

        public Node FindNode(int searchValue)
        {
            var currentNode = StartNode;

            while (currentNode != null)
            {
                if (currentNode.Value == searchValue)

                    return currentNode;

                currentNode = currentNode.NextNode;
            }

            return null; 
        }
    }
}
