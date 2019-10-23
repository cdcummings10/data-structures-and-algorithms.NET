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
    }
}
