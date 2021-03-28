using System;
using System.Collections.Generic;
using System.Text;

namespace prac4
{
    public class Node<T>
    {
        public T Data { get; set; }

        public Node<T> Left { get; set; }

        public Node<T> Right { get; set; }

        public Node<T> Parent { get; set; }



        public Node<int> Tree(int n)
        {
            Node<int> newNode = null;
            if (n == 0)
                return null;
            else
            {
                var nl = n / 2;
                var nr = n - nl - 1;
                newNode = new Node<int>();
                newNode.Data = new Random().Next();
                newNode.Left = Tree(nl);
                newNode.Right = Tree(nr);
            }
            return newNode;
        }


        public Node <int> GetFreeNode(int value, Node<int> parent)
        {
            return new Node<int>
            {
                Data = value,
                Parent = parent
            };


        }

        public Node<int> Insert(Node<int> head, int value)
        {
            Node<int> tmp = null;
            if (head == null)
            {
                head = GetFreeNode(value, null);
                return head;
            }

            tmp = head;
            while (tmp != null)
            {
                if (value > tmp.Data)
                {
                    if (tmp.Right != null)
                    {
                        tmp = tmp.Right;
                        continue;
                    }
                    else
                    {
                        tmp.Right = GetFreeNode(value, tmp);
                        return head;
                    }
                }
                else if (value < tmp.Data)
                {
                    if (tmp.Left != null)
                    {
                        tmp = tmp.Left;
                        continue;
                    }
                    else
                    {
                        tmp.Left = GetFreeNode(value, tmp);
                        return head;
                    }
                }
                else
                {
                    throw new Exception("Wrong tree state");                  // Дерево построено неправильно
                }
            }
            return head;
        }

    }


}
