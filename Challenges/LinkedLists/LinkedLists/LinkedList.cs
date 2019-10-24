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
    }
}
