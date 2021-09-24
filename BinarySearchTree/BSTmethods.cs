using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{   
    class BSTmethods
    {
        public Node root;
        /// <summary>
        /// Insert() method to insert the element
        /// </summary>
        /// <param name="key">holds the value</param>
        public void Insert(int key)
        {
            this.root = InsertRec(root, key);
        }
        /// <summary>
        /// InsertRec() recursion method to pass the value to prev(left) or next(right)
        /// </summary>
        /// <param name="root">holds value and referance of left and right</param>
        /// <param name="key">holds value</param>
        /// <returns></returns>
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
        /// <summary>
        /// Print method to print the tree in PreOrder form(rootnode,leftnode,rightnode)
        /// </summary>
        public void Print()
        {
            PreOrder(root);
        }
        /// <summary>
        /// PreOrder() recursion method to pass the value to prev(left) or next(right)
        /// </summary>
        /// <param name="root"></param>
        void PreOrder(Node root)
        {
            if (root != null)
            {
                Console.WriteLine(root.Data + "  ");
                PreOrder(root.Prev);
                PreOrder(root.Next);
            }
        }
        /// <summary>
        /// Search() to search the element
        /// </summary>
        /// <param name="value">holds the searching value</param>
        /// <returns>If present gives True else False</returns>
        public bool Search(int value)
        {
            return recSearch(root,value);
        }
        /// <summary>
        /// recSearch() recursion method to pass the value to prev(left) or next(right)
        /// </summary>
        /// <param name="root">holds value and referance of left and right</param>
        /// <param name="val">holds value</param>
        /// <returns></returns>
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
            Console.WriteLine("Value {0} is Absent", val);
            return false;
        }
    }
}
