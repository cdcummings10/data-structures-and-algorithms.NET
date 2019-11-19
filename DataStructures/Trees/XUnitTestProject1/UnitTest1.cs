using System;
using Xunit;
using Trees;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestHappyPathPreOrder()
        {
            Tree<int> tree = new Tree<int>(10);
            tree.Root.LeftChild = new Node<int>(20);
            tree.Root.RightChild = new Node<int>(15);
            tree.Root.RightChild.LeftChild = new Node<int>(11);
            tree.Root.RightChild.RightChild = new Node<int>(16);
            tree.Root.LeftChild.LeftChild = new Node<int>(30);
            tree.Root.LeftChild.RightChild = new Node<int>(25);

            Assert.Equal("10, 20, 30, 25, 15, 11, 16", String.Join(", ", tree.PreOrder(tree.Root)));
        }
        [Fact]
        public void TestInOrderIsNotPreOrder()
        {
            Tree<int> tree = new Tree<int>(10);
            tree.Root.LeftChild = new Node<int>(20);
            tree.Root.RightChild = new Node<int>(15);
            tree.Root.RightChild.LeftChild = new Node<int>(11);
            tree.Root.RightChild.RightChild = new Node<int>(16);
            tree.Root.LeftChild.LeftChild = new Node<int>(30);
            tree.Root.LeftChild.RightChild = new Node<int>(25);

            Assert.NotEqual("10, 20, 30, 25, 15, 11, 16", String.Join(", ", tree.InOrder(tree.Root)));
        }
        [Fact]
        public void TestInHappyPathPostOrder()
        {
            Tree<int> tree = new Tree<int>(10);
            tree.Root.LeftChild = new Node<int>(20);
            tree.Root.RightChild = new Node<int>(15);
            tree.Root.RightChild.LeftChild = new Node<int>(11);
            tree.Root.RightChild.RightChild = new Node<int>(16);
            tree.Root.LeftChild.LeftChild = new Node<int>(30);
            tree.Root.LeftChild.RightChild = new Node<int>(25);

            Assert.Equal("30, 25, 20, 11, 16, 15, 10", String.Join(", ", tree.PostOrder(tree.Root)));
        }

        [Fact]
        public void TestInHappyPathBreadthTraversal()
        {
            Tree<int> tree = new Tree<int>(10);
            tree.Root.LeftChild = new Node<int>(20);
            tree.Root.RightChild = new Node<int>(15);
            tree.Root.RightChild.LeftChild = new Node<int>(11);
            tree.Root.RightChild.RightChild = new Node<int>(16);
            tree.Root.LeftChild.LeftChild = new Node<int>(30);
            tree.Root.LeftChild.RightChild = new Node<int>(25);

            Assert.Equal("10, 20, 15, 30, 25, 11, 16", String.Join(", ", tree.BreadthFirstTraversal(tree.Root)));
        }
        [Fact]
        public void TestIfTreeCanBeEmpty()
        {
            Tree<int> tree = new Tree<int>();
            Assert.Null(tree.Root);
        }
        [Fact]
        public void TestThatBreadthFirstIsNotInOrder()
        {
            Tree<int> tree = new Tree<int>(10);
            tree.Root.LeftChild = new Node<int>(20);
            tree.Root.RightChild = new Node<int>(15);
            tree.Root.RightChild.LeftChild = new Node<int>(11);
            tree.Root.RightChild.RightChild = new Node<int>(16);
            tree.Root.LeftChild.LeftChild = new Node<int>(30);
            tree.Root.LeftChild.RightChild = new Node<int>(25);

            Assert.NotEqual("30, 20, 25, 10, 11, 15, 16", String.Join(", ", tree.BreadthFirstTraversal(tree.Root)));
        }
    }
}
