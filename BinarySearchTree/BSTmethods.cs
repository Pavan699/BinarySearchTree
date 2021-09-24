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

        public bool Search(int value)
        {
            return recSearch(root,value);
        }
        bool recSearch(Node root,int val)
        {
            
            while(root != null)
            {
                if(root.Data == val)
                {
                    Console.WriteLine("Value {0} is Present",val);
                    return true;
                }
                else if(root.Data > val)
                {
                    return recSearch(root.Prev, val);                   
                }
                else
                {
                    return recSearch(root.Next, val);
                }
            }
            return false;
        }
    }
}
