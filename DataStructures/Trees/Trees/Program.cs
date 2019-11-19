using System;

namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree<int> tree = new Tree<int>(10);
            tree.Root.LeftChild = new Node<int>(20);
            tree.Root.RightChild = new Node<int>(15);
            tree.Root.RightChild.LeftChild = new Node<int>(11);
            tree.Root.RightChild.RightChild = new Node<int>(16);
            tree.Root.LeftChild.LeftChild = new Node<int>(30);
            tree.Root.LeftChild.RightChild = new Node<int>(25);
            Console.WriteLine(String.Join(", ", tree.PreOrder(tree.Root)));
            Console.WriteLine(String.Join(", ", tree.InOrder(tree.Root)));
            Console.WriteLine(String.Join(", ", tree.PostOrder(tree.Root)));
            Console.WriteLine(String.Join(", ", tree.BreadthFirstTraversal(tree.Root)));

            BinaryTree bTree = new BinaryTree();
            bTree.Add(10);
            bTree.Add(15);
            bTree.Add(5);
            bTree.Add(200);
            bTree.Add(250);
            Console.WriteLine(String.Join(", ", bTree.InOrder(bTree.Root)));
            Console.WriteLine(bTree.Contains(15));

        }
    }
}
