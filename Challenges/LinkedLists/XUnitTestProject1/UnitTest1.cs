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
    public class UnitTest2
    {
        #region Challenge7
        [Fact]
        public void TestIfKIsGreaterThanLinkedListLength()
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


            Assert.Equal(0, linkedList.KthFromTheEnd(5));
        }
        [Fact]
        public void TestIfKIsEqualToListLength()
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


            Assert.Equal(15, linkedList.KthFromTheEnd(3));
        }
        [Fact]
        public void TestIfKIsNotAPositiveNumber()
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


            Assert.Equal(25, linkedList.KthFromTheEnd(-1));
        }
        [Fact]
        public void TestIfLinkedListIsSizeOne()
        {
            LinkedList linkedList = new LinkedList();
            Node node1 = new Node(15);
            linkedList.Head = node1;


            Assert.Equal(15, linkedList.KthFromTheEnd(0));
        }
        [Fact]
        public void TestIfKIsInMiddle()
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


            Assert.Equal(20, linkedList.KthFromTheEnd(2));
        }
        #endregion
    }
    public class UnitTest3
    {
        #region Challenge8
        [Fact]
        public void TestIfTwoListsAreMergedCorrectly()
        {
            LinkedList linkedList1 = new LinkedList();
            Node node1 = new Node(10);
            Node node2 = new Node(20);
            Node node3 = new Node(30);
            Node node4 = new Node(40);
            linkedList1.Head = node1;
            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;
            LinkedList linkedList2 = new LinkedList();
            Node node5 = new Node(15);
            Node node6 = new Node(25);
            Node node7 = new Node(35);
            Node node8 = new Node(45);
            linkedList2.Head = node5;
            node5.Next = node6;
            node6.Next = node7;
            node7.Next = node8;

            linkedList1.MergeLists(linkedList1, linkedList2);

            Assert.Equal(25, node2.Next.Data);
        }
        [Fact]
        public void TestIfListOneIsLargerThanListTwo()
        {
            LinkedList linkedList1 = new LinkedList();
            Node node1 = new Node(10);
            Node node2 = new Node(20);
            Node node3 = new Node(30);
            Node node4 = new Node(40);
            linkedList1.Head = node1;
            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;
            LinkedList linkedList2 = new LinkedList();
            Node node5 = new Node(15);
            Node node6 = new Node(25);
            linkedList2.Head = node5;
            node5.Next = node6;

            linkedList1.MergeLists(linkedList1, linkedList2);

            Assert.Equal(20, node5.Next.Data);
        }
        [Fact]
        public void TestIfListTwoIsLongerThanListOne()
        {
            LinkedList linkedList1 = new LinkedList();
            Node node1 = new Node(10);
            Node node2 = new Node(20);
            linkedList1.Head = node1;
            node1.Next = node2;
            LinkedList linkedList2 = new LinkedList();
            Node node5 = new Node(15);
            Node node6 = new Node(25);
            Node node7 = new Node(35);
            Node node8 = new Node(45);
            linkedList2.Head = node5;
            node5.Next = node6;
            node6.Next = node7;
            node7.Next = node8;

            linkedList1.MergeLists(linkedList1, linkedList2);

            Assert.Equal(20, node5.Next.Data);
        }
        [Fact]
        public void TestIfOneListisEmpty()
        {
            LinkedList linkedList1 = new LinkedList();
            LinkedList linkedList2 = new LinkedList();
            Node node5 = new Node(15);
            Node node6 = new Node(25);
            Node node7 = new Node(35);
            Node node8 = new Node(45);
            linkedList2.Head = node5;
            node5.Next = node6;
            node6.Next = node7;
            node7.Next = node8;

            Assert.NotNull(linkedList1.MergeLists(linkedList1, linkedList2));
        }
        #endregion
    }
}
