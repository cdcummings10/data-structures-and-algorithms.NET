using System;
using System.Collections.Generic;
using System.Text;

namespace Trees
{
    public class Tree<T>
    {
        public Node<T> Root { get; set; }

        public Tree()
        {
            Root = null;
        }
        public Tree(T value)
        {
            Root = new Node<T>(value);
        }

        public List<T> PreOrder(Node<T> node)
        {
            List<T> traversal = new List<T>();
            PreOrder(node, traversal);
            return traversal;
        }

        private void PreOrder(Node<T> node, List<T> traversal)
        {
            traversal.Add(node.Value);
            if (node.LeftChild != null)
            {
                PreOrder(node.LeftChild, traversal);
            }
            if (node.RightChild != null)
            {
                PreOrder(node.RightChild, traversal);
            }
        }

        public List<T> InOrder(Node<T> node)
        {
            List<T> traversal = new List<T>();
            InOrder(node, traversal);
            return traversal;
        }

        private void InOrder(Node<T> node, List<T> traversal)
        {
            if (node.LeftChild != null)
            {
                InOrder(node.LeftChild, traversal);
            }
            traversal.Add(node.Value);
            if (node.RightChild != null)
            {
                InOrder(node.RightChild, traversal);
            }
        }

        public List<T> PostOrder(Node<T> node)
        {
            List<T> traversal = new List<T>();
            PostOrder(node, traversal);
            return traversal;
        }

        private void PostOrder(Node<T> node, List<T> traversal)
        {
            if (node.LeftChild != null)
            {
                PostOrder(node.LeftChild, traversal);
            }
            if (node.RightChild != null)
            {
                PostOrder(node.RightChild, traversal);
            }
            traversal.Add(node.Value);
        }

        public List<T> BreadthFirstTraversal(Node<T> node)
        {
            Queue<Node<T>> queue = new Queue<Node<T>>();
            List<T> values = new List<T>();

            queue.Enqueue(node);
            while (queue.TryPeek(out node))
            {
                Node<T> front = queue.Dequeue();
                values.Add(front.Value);

                if (front.LeftChild != null)
                {
                    queue.Enqueue(front.LeftChild);
                }
                if (front.RightChild != null)
                {
                    queue.Enqueue(front.RightChild);
                }
            }
            return values;
        }
    }
}
