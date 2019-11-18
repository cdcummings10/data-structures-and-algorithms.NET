using System;
using System.Collections.Generic;
using System.Text;

namespace Trees
{
    class BinaryTree : Tree<int>
    {

        public void Add(int value)
        {
            Node<int> newNode = new Node<int>(value);
            Node<int> node = Root;
            if(Root == null)
            {
                Root = newNode;
            }
            else
            {
            Add(node, newNode);
            }
        }
        private void Add(Node<int> node, Node<int> newNode)
        {
            if (newNode.Value >= node.Value && node.RightChild != null)
            {
                Add(node.RightChild, newNode);
            }
            else if (newNode.Value <= node.Value && node.LeftChild != null)
            {
                Add(node.LeftChild, newNode);
            }
            else
            {
                if (newNode.Value >= node.Value)
                {
                    node.RightChild = newNode;
                }
                else
                {
                    node.LeftChild = newNode;
                }
            }
        }
        public bool Contains(int value)
        {
            bool answer = false;
            if (Root == null)
            {
                return answer;
            }
            else
            {
                answer = Contains(Root, value);
            }
            return answer;
        }
        private bool Contains(Node<int> node, int value)
        {
            if (value > node.Value && node.RightChild != null)
            {
                Contains(node.RightChild, value);
            }
            else if (value < node.Value && node.LeftChild != null)
            {
                Contains(node.LeftChild, value);
            }
            else if (value == node.Value)
            {
                return true;
            }
                return false;
        }
    }
}
