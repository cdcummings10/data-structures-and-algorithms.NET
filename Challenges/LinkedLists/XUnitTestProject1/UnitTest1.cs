using System;
using Xunit;
using LinkedLists;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        #region Challenge6
        //Can successfully add a node to the end of the linked list
        //Can successfully add multiple nodes to the end of a linked list
        //Can successfully insert a node before a node located i the middle of a linked list
        //Can successfully insert a node before the first node of a linked list
        //Can successfully insert after a node in the middle of the linked list
        //Can successfully insert a node after the last node of the linked list
        [Fact]
        public void TestAppendFunctionToAddToEndOfList()
        {
            LinkedList linkedList = new LinkedList();
            Node node1 = new Node(15);
            Node node2 = new Node(20);
            Node node3 = new Node(25);
            Node node4 = new Node(30);
            linkedList.Head = node1;
            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;

            linkedList.Append(35);
            Assert.Equal(35, node4.Next.Data);
        }
        [Fact]
        public void TestAddingMultipleNodesToEndofLinkedList()
        {
            LinkedList linkedList = new LinkedList();
            Node node1 = new Node(15);
            Node node2 = new Node(20);
            Node node3 = new Node(25);
            Node node4 = new Node(30);
            linkedList.Head = node1;
            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;

            linkedList.Append(35);
            linkedList.Append(40);
            linkedList.Append(45);
            Assert.Equal(35, node4.Next.Data);
            Assert.Equal(40, node4.Next.Next.Data);
            Assert.Equal(45, node4.Next.Next.Next.Data);
        }
        [Fact]
        public void TestInsertBeforeFunctionToInsertNodeInMiddleOfLinkedList()
        {
            LinkedList linkedList = new LinkedList();
            Node node1 = new Node(15);
            Node node2 = new Node(20);
            Node node3 = new Node(25);
            Node node4 = new Node(30);
            linkedList.Head = node1;
            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;

            linkedList.InsertBefore(25, 22);
            Assert.Equal(22, node2.Next.Data);
        }
        [Fact]
        public void TestInsertBeforeFirstNodeOfLinkedList()
        {
            LinkedList linkedList = new LinkedList();
            Node node1 = new Node(15);
            linkedList.Head = node1;

            linkedList.InsertBefore(15, 20);
            Assert.Equal(20, linkedList.Head.Data);
        }
        [Fact]
        public void TestInsertAfterMiddleNode()
        {
            LinkedList linkedList = new LinkedList();
            Node node1 = new Node(15);
            Node node2 = new Node(20);
            Node node3 = new Node(25);
            Node node4 = new Node(30);
            linkedList.Head = node1;
            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;

            linkedList.InsertAfter(25, 27);
            Assert.Equal(27, node3.Next.Data);
        }
        [Fact]
        public void TestInsertAfterIfLastNodeIsTargetValue()
        {
            LinkedList linkedList = new LinkedList();
            Node node1 = new Node(15);
            Node node2 = new Node(20);
            Node node3 = new Node(25);
            Node node4 = new Node(30);
            linkedList.Head = node1;
            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;

            linkedList.InsertAfter(30, 35);
            Assert.Equal(35, node4.Next.Data);
        }
        #endregion
    }
}
