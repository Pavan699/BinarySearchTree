using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary-Search-Tree(BST)");

            BSTmethods bstm = new BSTmethods();
            bstm.Insert(56);
            bstm.Insert(30);
            bstm.Insert(70);

            bstm.Print();
        }
    }
}
