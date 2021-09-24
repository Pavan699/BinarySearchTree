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
            bstm.Insert(22);
            bstm.Insert(95);
            bstm.Insert(40);
            bstm.Insert(60);
            bstm.Insert(11);
            bstm.Insert(65);
            bstm.Insert(67);
            bstm.Insert(3);
            bstm.Insert(16);
            bstm.Insert(63);

            bstm.Print();
        }
    }
}
