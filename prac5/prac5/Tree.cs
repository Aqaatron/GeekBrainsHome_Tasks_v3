using System;
using System.Collections.Generic;
using System.Text;

namespace prac5
{
    public class Tree : ITree
    {
        public TreeNode Head { get; set; }


        public TreeNode BFS(int value)
        {

            var bufer = new Queue<TreeNode>();

            bufer.Enqueue(Head);

            while (bufer.Count != 0)
            {
                var element = bufer.Dequeue();

                if (element.Value == value)
                {
                    return element;
                }

                if (element.LeftChild != null)
                {
                    bufer.Enqueue(element.LeftChild);
                }
                if (element.RightChild != null)
                {
                    bufer.Enqueue(element.RightChild);
                }
            }
            return null;
        }

        public TreeNode DFS(int value)
        {

            var bufer = new Stack<TreeNode>();

            bufer.Push(Head);

            while (bufer.Count != 0)
            {
                var element = bufer.Pop();

                if (element.Value == value)
                {
                    return element;
                }

                if (element.RightChild != null)
                {
                    bufer.Push(element.RightChild);
                }
                if (element.LeftChild != null)
                {
                    bufer.Push(element.LeftChild);
                }
            }
            return null;
        }

        public void PrintTree()
        {
            
            int startX = 60;
            int startY = 1;
            int marginYRight = 3;
            int marginYRight_initial = marginYRight;
            int marginYLeft = marginYRight;
            int marginYLeft_initial = marginYRight;
            int marginPrintRight = 1;
            int marginPrintRight_initial = marginPrintRight;
            int marginPrintLeft = marginPrintRight;
            int marginPrintLeft_initial = marginPrintRight;
            TreeNode tmp = null;
            tmp = Head;
            Console.Clear();
            Console.SetCursorPosition(startX, startY);
            Console.Write("[" + tmp.Value.ToString() + "]");
            Console.SetCursorPosition(startX + 1, startY + marginPrintRight);
            Console.Write("|");
            int delta = 20;
            int d_delta = 10;
            int delta_initial = delta;

            int startXRight = startX;

            int startXLeft = startX;

            while (tmp != null)
            {
                if (tmp.RightChild != null)
                {
                    if ((tmp.RightChild.RightChild == null) && (tmp.RightChild.LeftChild == null))
                    {
                        Console.SetCursorPosition(startXRight + 2, startY + marginPrintRight);
                        Console.Write(get_string(delta));
                        Console.SetCursorPosition(startXRight + delta + 1, startY + marginPrintRight + 1);
                        Console.Write("|");
                        Console.SetCursorPosition(startXRight + delta, startY + marginYRight);
                        Console.Write("[" + tmp.RightChild.Value.ToString() + "]");
                    }
                    else
                    {
                        Console.SetCursorPosition(startXRight + 2, startY + marginPrintRight);
                        Console.Write(get_string(delta));
                        Console.SetCursorPosition(startXRight + delta + 1, startY + marginPrintRight + 1);
                        Console.Write("|");
                        Console.SetCursorPosition(startXRight + delta, startY + marginYRight);
                        Console.Write("[" + tmp.RightChild.Value.ToString() + "]");
                        Console.SetCursorPosition(startXRight + delta + 1, startY + marginYRight + 1);
                        Console.Write("|");
                        startXRight = startXRight + delta;
                        marginPrintRight = marginYRight + 1;
                        marginYRight += 3;
                    }


                }
                else
                {
                    if ((tmp.RightChild.RightChild == null) && (tmp.RightChild.LeftChild == null))
                    {
                        break;
                    }
                    startXRight = startXLeft;
                    marginPrintRight = marginYRight + 1;
                    marginYRight += 3;
                }
                if (tmp.LeftChild != null)
                {
                    if ((tmp.LeftChild.RightChild == null) && (tmp.LeftChild.LeftChild == null))
                    {
                        Console.SetCursorPosition(startXLeft + 1 - delta, startY + marginPrintLeft);
                        Console.Write(get_string(delta));
                        Console.SetCursorPosition(startXLeft + 1 - delta, startY + marginPrintLeft + 1);
                        Console.Write("|");
                        Console.SetCursorPosition(startXLeft - delta, startY + marginYLeft);
                        Console.Write("[" + tmp.LeftChild.Value.ToString() + "]");
                    }
                    else
                    {
                        Console.SetCursorPosition(startXLeft + 1 - delta, startY + marginPrintLeft);
                        Console.Write(get_string(delta));
                        Console.SetCursorPosition(startXLeft + 1 - delta, startY + marginPrintLeft + 1);
                        Console.Write("|");
                        Console.SetCursorPosition(startXLeft - delta, startY + marginYLeft);
                        Console.Write("[" + tmp.LeftChild.Value.ToString() + "]");
                        Console.SetCursorPosition(startXLeft - delta + 1, startY + marginYLeft + 1);
                        Console.Write("|");
                        startXLeft -= delta;
                        marginPrintLeft = marginYLeft + 1;
                        marginYLeft += 3;
                    }


                }
                else
                {
                    if ((tmp.RightChild.RightChild == null) && (tmp.RightChild.LeftChild == null))
                    {
                        break;
                    }
                    startXLeft = startXRight;
                    marginPrintLeft = marginYLeft + 1;
                    marginYLeft += 3;
                }


                if (delta > 10)
                {
                    delta = delta - d_delta;
                }
                else
                {
                    delta = 5;
                }
                //k = k + 3; ;
                tmp = tmp.RightChild;

            }
            tmp = Head;

            marginYRight = marginYLeft = marginYLeft_initial;

            marginPrintRight = marginPrintLeft = marginPrintRight_initial;

            delta = delta_initial;

            startXRight = startXLeft = startX;

            while (tmp != null)
            {
                if (tmp.RightChild != null)
                {
                    if (delta == 20)
                    {

                        marginPrintRight = marginPrintLeft = marginYRight + 1;
                        marginYRight += 3;
                        marginYLeft += 3;
                        startXRight = startXLeft = startXRight - delta;
                        delta = delta - d_delta;
                        tmp = tmp.LeftChild;
                        continue;

                    }
                    if ((tmp.RightChild.RightChild == null) && (tmp.RightChild.LeftChild == null))
                    {
                        Console.SetCursorPosition(startXRight + 2, startY + marginPrintRight);
                        Console.Write(get_string(delta));
                        Console.SetCursorPosition(startXRight + delta + 1, startY + marginPrintRight + 1);
                        Console.Write("|");
                        Console.SetCursorPosition(startXRight + delta, startY + marginYRight);
                        Console.Write("[" + tmp.RightChild.Value.ToString() + "]");
                    }
                    else
                    {
                        Console.SetCursorPosition(startXRight + 2, startY + marginPrintRight);
                        Console.Write(get_string(delta));
                        Console.SetCursorPosition(startXRight + delta + 1, startY + marginPrintRight + 1);
                        Console.Write("|");
                        Console.SetCursorPosition(startXRight + delta, startY + marginYRight);
                        Console.Write("[" + tmp.RightChild.Value.ToString() + "]");
                        Console.SetCursorPosition(startXRight + delta + 1, startY + marginYRight + 1);
                        Console.Write("|");
                        startXRight = startXRight + delta;
                        marginPrintRight = marginYRight + 1;
                        marginYRight += 3;
                    }


                }
                else
                {
                    startXRight = startXLeft;
                    marginPrintRight = marginYRight + 1;
                    marginYRight += 3;
                }
                if (tmp.LeftChild != null)
                {
                    if ((tmp.LeftChild.RightChild == null) && (tmp.LeftChild.LeftChild == null))
                    {
                        Console.SetCursorPosition(startXLeft + 1 - delta, startY + marginPrintLeft);
                        Console.Write(get_string(delta));
                        Console.SetCursorPosition(startXLeft + 1 - delta, startY + marginPrintLeft + 1);
                        Console.Write("|");
                        Console.SetCursorPosition(startXLeft - delta, startY + marginYLeft);
                        Console.Write("[" + tmp.LeftChild.Value.ToString() + "]");
                    }
                    else
                    {
                        Console.SetCursorPosition(startXLeft + 1 - delta, startY + marginPrintLeft);
                        Console.Write(get_string(delta));
                        Console.SetCursorPosition(startXLeft + 1 - delta, startY + marginPrintLeft + 1);
                        Console.Write("|");
                        Console.SetCursorPosition(startXLeft - delta, startY + marginYLeft);
                        Console.Write("[" + tmp.LeftChild.Value.ToString() + "]");
                        Console.SetCursorPosition(startXLeft - delta + 1, startY + marginYLeft + 1);
                        Console.Write("|");
                        startXLeft -= delta;
                        marginPrintLeft = marginYLeft + 1;
                        marginYLeft += 3;
                    }


                }
                else
                {

                    startXLeft = startXRight;
                    marginPrintLeft = marginYLeft + 1;
                    marginYLeft += 3;
                }


                if (delta > 10)
                {
                    delta = delta - d_delta;
                }
                else
                {
                    delta = 5;
                }
                tmp = tmp.LeftChild;

            }
        }
        public string get_string(int length)
        {
            string str = "";

            for (int i = 0; i < length; i++)
            {
                str += "_";
            }
            return str;
        }
        public TreeNode GetNodeByValue(int value)
        {
            TreeNode tmp = null;

            if (Head.Value == value)
            {
                return Head;
            }

            tmp = Head;

            while (tmp != null)
            {
                if (value > tmp.Value)
                {
                    if (tmp.RightChild != null)
                    {
                        if (tmp.RightChild.Value == value)
                        {
                            return tmp.RightChild;
                        }
                        else
                        {


                            tmp = tmp.RightChild;
                            continue;
                        }
                    }
                    else
                        return null;
                }
                else if (value < tmp.Value)
                {
                    if (tmp.LeftChild != null)
                    {
                        if (tmp.LeftChild.Value == value)
                        {
                            return tmp.LeftChild;
                        }
                        else
                        {
                            tmp = tmp.LeftChild;
                            //if ((tmp.LeftChild.RightChild == null) && (tmp.LeftChild.LeftChild == null))
                            //{
                            //    return null;
                            //}
                            continue;
                        }

                    }
                    else
                        return null;

                }

            }
            return null;
        }
        public void AddItem(int value)
        {
            TreeNode tmp = null;

            if (Head == null)
            {
                Head = GetRoot();
                Head.Value = value;
            }
            else
            {
                tmp = Head;

                while (tmp != null)
                {
                    if (value > tmp.Value)
                    {
                        if (tmp.RightChild != null)
                        {
                            tmp = tmp.RightChild;
                            continue;
                        }
                        else
                        {
                            tmp.RightChild = GetRoot();
                            tmp.RightChild.Value = value;
                            break;
                        }
                    }
                    else if (value < tmp.Value)
                    {
                        if (tmp.LeftChild != null)
                        {
                            tmp = tmp.LeftChild;
                            continue;
                        }
                        else
                        {
                            tmp.LeftChild = GetRoot();
                            tmp.LeftChild.Value = value;
                            break;
                        }
                    }
                    else if (value == tmp.Value)
                    {
                        break;
                    }
                    else
                    {
                        throw new Exception("Wrong tree state");                  // Дерево построено неправильно
                    }
                }
            }

        }
        public void RemoveItem(int value)
        {
            TreeNode tmp = null;

            if (Head.Value == value)
            {
                return;
            }
            tmp = Head;

            while (tmp != null)
            {
                if (value > tmp.Value)
                {
                    if (tmp.RightChild != null)
                    {
                        if (tmp.RightChild.Value == value)
                        {
                            if ((tmp.RightChild.RightChild != null) && (tmp.RightChild.LeftChild != null))
                            {
                                tmp.RightChild = tmp.RightChild.LeftChild;
                                break;
                            }
                            else if ((tmp.RightChild.RightChild != null) && (tmp.RightChild.LeftChild == null))
                            {
                                tmp.RightChild = tmp.RightChild.RightChild;
                                break;
                            }
                            else if ((tmp.RightChild.RightChild == null) && (tmp.RightChild.LeftChild != null))
                            {
                                tmp.RightChild = tmp.RightChild.LeftChild;
                                break;
                            }
                            else if ((tmp.RightChild.RightChild == null) && (tmp.RightChild.LeftChild == null))
                            {
                                tmp.RightChild = null;
                                break;
                            }


                        }
                        else
                        {
                            tmp = tmp.RightChild;
                            continue;
                        }
                    }
                }
                else if (value < tmp.Value)
                {
                    if (tmp.LeftChild != null)
                    {
                        if (tmp.LeftChild.Value == value)
                        {
                            if ((tmp.LeftChild.RightChild != null) && (tmp.LeftChild.LeftChild != null))
                            {
                                tmp.RightChild = tmp.RightChild.RightChild;
                                break;
                            }
                            else if ((tmp.LeftChild.RightChild != null) && (tmp.LeftChild.LeftChild == null))
                            {
                                tmp.RightChild = tmp.LeftChild.RightChild;
                                break;
                            }
                            else if ((tmp.LeftChild.RightChild == null) && (tmp.LeftChild.LeftChild != null))
                            {
                                tmp.RightChild = tmp.LeftChild.LeftChild;
                                break;
                            }
                            else if ((tmp.LeftChild.RightChild == null) && (tmp.LeftChild.LeftChild == null))
                            {
                                tmp.LeftChild = null;
                                break;
                            }
                        }
                        else
                        {
                            tmp = tmp.LeftChild;
                            continue;
                        }

                    }

                }

            }
        }


        public TreeNode GetRoot()
        {
            return new TreeNode();
        }

    }
}