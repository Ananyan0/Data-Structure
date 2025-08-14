namespace BinaryTree;

class Program
{
    static void Main(string[] args)
    {
        MyBinaryTree node = new();

        node.Insert(27);
        node.Insert(83);
        node.Insert(12);
        node.Insert(45);
        node.Insert(69);
        node.Insert(5);
        node.Insert(90);
        node.Insert(33);
        node.Insert(18);
        node.Insert(76);

        TreeNode? foundNode = node.Search(17);

        if (foundNode != null)
            System.Console.WriteLine(foundNode.val);
        else
        {
            System.Console.WriteLine("Tree doesn't contains that value");
        }

        //node.PreOrderTraversal(node.root);
        node.InOrderTraversal(node.root);
        //node.PostOrderTraversal(node.root);;

        //TreeNode? res = node.Successor(node.root, 45);
        //Console.WriteLine(res.val);

        TreeNode? res = node.Predecessor(node.root, 45);
        Console.WriteLine(res.val);



    }
}
