using System;

namespace Project_
{
    class Program
    {
        static void Main(string[] args)
        {
            MyBinaryTree tree = new MyBinaryTree();

            // BST insert
            tree.Insert(10);
            tree.Insert(5);
            tree.Insert(20);

            Console.Write("BST In-order: ");
            tree.InOrderTraversal(tree.root);
            Console.WriteLine();

            // AVL insert
            MyBinaryTree avl = new MyBinaryTree();
            avl.InsertAVL(10);
            avl.InsertAVL(20);
            avl.InsertAVL(5);
            avl.InsertAVL(25);

            Console.Write("AVL In-order: ");
            avl.InOrderTraversal(avl.root);
            Console.WriteLine();
        }
    }
}
