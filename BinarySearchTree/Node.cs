using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    public class Node
    {
        public int Data;
        public Node Prev;
        public Node Next;

        public Node(int data)
        {
            this.Data = data;
            this.Prev = null;
            this.Next = null;
        }
    }
}
