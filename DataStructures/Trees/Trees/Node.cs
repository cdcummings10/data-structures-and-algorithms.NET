using System;
using System.Collections.Generic;
using System.Text;

namespace Trees
{
    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> LeftChild { get; set; } = null;
        public Node<T> RightChild { get; set; } = null;

        public Node(T value)
        {
            Value = value;
        }
    }
}
