using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class BSTmethods
    {
        public Node root;
        public void Insert(int key)
        {
            this.root = InsertRec(root, key);
        }
        Node InsertRec(Node root, int key)
        {
            if (root == null)
            {
                root = new Node(key);
                return root;
            }
            if (key < root.Data)
            {
                root.Prev = InsertRec(root.Prev, key);
            }
            else if (key > root.Data)
            {
                root.Next = InsertRec(root.Next, key);
            }
            return root;
        }
        public void Print()
        {
            PreOrder(root);
        }
        void PreOrder(Node root)
        {
            if (root != null)
            {
                Console.WriteLine(root.Data + "  ");
                PreOrder(root.Prev);
                PreOrder(root.Next);
            }
        }
    }
}
