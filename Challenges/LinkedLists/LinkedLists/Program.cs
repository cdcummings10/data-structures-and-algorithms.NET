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
            linkedList.Head = node1;

            linkedList.InsertBefore(15, 20);
            Console.WriteLine(linkedList.Head.Data);
        }
    }
}
