using System;

class Program
{
    static void Main()
    {
        MyBinaryTree tree = new MyBinaryTree();

        Console.WriteLine("=== Inserting values into the tree ===");
        int[] values = { 50, 30, 70, 20, 40, 60, 80 };
        foreach (int v in values)
        {
            tree.Insert(v);
        }

        Console.WriteLine("InOrder Traversal (sorted order):");
        tree.InOrderTraversal(tree.root);
        Console.WriteLine("\n");

        Console.WriteLine("PreOrder Traversal:");
        tree.PreOrderTraversal(tree.root);
        Console.WriteLine("\n");

        Console.WriteLine("PostOrder Traversal:");
        tree.PostOrderTraversal(tree.root);
        Console.WriteLine("\n");

        Console.WriteLine("=== Searching for a value ===");
        int searchValue = 40;
        var found = tree.Search(searchValue);
       

        Console.WriteLine("\n=== Deleting a value ===");
        tree.root = tree.Delete(tree.root, 30);
        tree.InOrderTraversal(tree.root);
        Console.WriteLine();

        Console.WriteLine("\n=== Finding successor and predecessor ===");
        int target = 60;
        var successor = tree.Successor(tree.root, target);
        var predecessor = tree.Predecessor(tree.root, target);
    }
}
