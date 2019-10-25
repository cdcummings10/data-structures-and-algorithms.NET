using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists
{
    public class LinkedList
    {
        public Node Head { get; set; }
        public LinkedList()
        {
            Head = null;
        }
        public void Insert(int value)
        {
            Node newNode = new Node(value);
            newNode.Next = Head;
            Head = newNode;
        }
        public bool Includes(int value)
        {
            Node currentNode = Head;
            while (currentNode != null)
            {
                if (currentNode.Data == value)
                {
                    return true;
                }
                currentNode = currentNode.Next;
            }
            return false;
        }
        public string DataToString()
        {
            Node currentNode = Head;
            string answerString = "";
            while(currentNode.Next != null)
            {
                answerString += $"{currentNode.Data}, ";
                currentNode = currentNode.Next;
            }
            answerString += currentNode.Data;
            return answerString;
        }
        public void Append(int value)
        {
            Node newNode = new Node(value);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node currentNode = Head;
                while (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }
                currentNode.Next = newNode;
            }
        }
        public void InsertBefore(int value, int newValue)
        {
            Node newNode = new Node(newValue);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node currentNode = Head;
                Node previousNode = null;

                bool found = false;
                while (found == false && currentNode != null)
                {
                    if (currentNode.Data == value)
                    {
                        if (previousNode == null)
                        {
                            Head = newNode;
                            newNode.Next = currentNode;
                            found = true;
                        }
                        else
                        {
                            newNode.Next = currentNode;
                            previousNode.Next = newNode;
                            found = true;
                        }
                    }
                    else
                    {
                        previousNode = currentNode;
                        currentNode = currentNode.Next;
                    }
                }
            }
        }
        public void InsertAfter(int value, int newValue)
        {
            Node newNode = new Node(newValue);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node currentNode = Head;
                bool found = false;
                while (found == false && currentNode != null)
                {
                    if (currentNode.Data == value)
                    {
                        if (currentNode.Next == null)
                        {
                            currentNode.Next = newNode;
                            found = true;
                        }
                        else
                        {
                            newNode.Next = currentNode.Next;
                            currentNode.Next = newNode;
                            found = true;
                        }
                    }
                    else
                    {
                        currentNode = currentNode.Next;
                    }
                }
            }
        }
        public int KthFromTheEnd(int k)
        {
            k = Math.Abs(k);
            if (Head == null)
            {
                return 0;
            }
            else
            {
                Node currentNode = Head;
                Node answerNode = null;
                int counter = 0;
                bool toggle = false;

                while (currentNode.Next != null)
                {
                    if (toggle)
                    {
                        answerNode = answerNode.Next;
                        currentNode = currentNode.Next;
                        counter++;
                    }
                    else if (counter == k)
                    {
                        answerNode = this.Head;
                        toggle = true;
                    }
                    else
                    {
                        currentNode = currentNode.Next;
                        counter++;
                    }
                }
                if (counter == k)
                {
                    answerNode = this.Head;
                }
                if (answerNode == null)
                {
                    return 0;
                }
                else
                {
                return answerNode.Data;
                }
            }
        }
        public Node MergeLists(LinkedList linkedList1, LinkedList linkedList2)
        {
            Node currentNode1 = linkedList1.Head;
            Node currentNode2 = linkedList2.Head;

            Node holder1 = null;
            Node holder2 = null;

            while(currentNode1 != null && currentNode2 != null)
            {
                holder1 = currentNode1.Next;
                currentNode1.Next = currentNode2;
                if(holder1 == null)
                {
                    break;
                }
                holder2 = currentNode2.Next;
                currentNode2.Next = holder1;

                currentNode1 = holder1;
                currentNode2 = holder2;
            }
            if (linkedList1.Head == null)
            {
                return linkedList2.Head;
            }
            else
            {
                return linkedList1.Head;
            }
        }
    }
}
