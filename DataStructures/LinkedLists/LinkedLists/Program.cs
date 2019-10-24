using System;

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LinkedList linkedList = new LinkedList();
            Node node1 = new Node(15);
            Node node2 = new Node(20);
            Node node3 = new Node(25);
            Node node4 = new Node(30);
            linkedList.Head = node1;
            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;


            linkedList.KthFromTheEnd(4);
        }
    }
}
