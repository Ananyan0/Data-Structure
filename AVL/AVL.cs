public class TreeNode
{
    public int val;
    public TreeNode? left;
    public TreeNode? right;

    public TreeNode(int val)
    {
        this.val = val;
        this.left = null;
        this.right = null;
    }
}

class MyBinaryTree
{
    public TreeNode? root;

    public MyBinaryTree()
    {
        root = null;
    }


    public void Insert(int val)
    {
        root = RecursiveInsert(root, val);
    }

    private TreeNode RecursiveInsert(TreeNode? node, int val)
    {
        if (node == null) return new TreeNode(val);

        if (node.val < val)
        {
            node.right = RecursiveInsert(node.right, val);
        }
        else
        {
            node.left = RecursiveInsert(node.left, val);
        }

        return node;
    }

    public void InsertAVL(int val)
    {
        root = RecInsertAVL(root, val);
    }

    private TreeNode? RecInsertAVL(TreeNode? node, int val)
    {
        if (node == null)
        {
            return new TreeNode(val);
        }

        if (val > node.val)
        {
            node.right = RecInsertAVL(node.right, val);
        }
        else if (val < node.val)
        {
            node.left = RecInsertAVL(node.left, val);
        }
        else
        {
            return node;
        }

        int balance = getHeight(node.left) - getHeight(node.right);

        if (balance > 1 && node.left != null && val < node.left!.val)
            return RightRotate(node);

        if (balance < -1 && node.right != null && val > node.right.val)
            return LeftRotate(node);

        if (balance > 1 && node.left != null && val > node.left.val)
        {
            node.left = LeftRotate(node.left);

            return RightRotate(node);
        }

        if (balance < -1 && val < node.right!.val)
        {
            node.right = RightRotate(node.right);

            return LeftRotate(node);
        }

        return node;
    }

    private TreeNode? RightRotate(TreeNode z)
    {
        TreeNode y = z.left;
        TreeNode T3 = y.right;

        y.right = z;
        z.left = T3;

        return y;
    }

    private TreeNode? LeftRotate(TreeNode z)
    {
        TreeNode y = z.right;
        TreeNode T3 = y.left;

        y.left = z;
        z.right = T3;

        return y;
    }

    

    public TreeNode? Search(int val)
    {
        return RecursiveSearch(root, val);
    }

    private TreeNode? RecursiveSearch(TreeNode? node, int val)
    {
        if (node == null) return null;
        if (node.val == val) return node;

        if (node.val > val)
        {
            return RecursiveSearch(node.left, val);
        }
        else
        {
            return RecursiveSearch(node.right, val);
        }
    }

    public TreeNode? Delete(TreeNode? root, int val)
    {
        return RecursiveDelete(root, val);
    }

    private TreeNode? RecursiveDelete(TreeNode? node, int val)
    {
        if (node == null) return null;

        if (val > node.val)
        {
            node.right = RecursiveDelete(node.right, val);
        }
        else if (val < node.val)
        {
            node.left = RecursiveDelete(node.left, val);
        }
        else
        {
            if (node.left == null) return node.right;
            if (node.right == null) return node.left;

            TreeNode succ = getMin(node.right);

            (node.val, succ.val) = (succ.val, node.val);
            node.right = RecursiveDelete(node.right, succ.val);
        }

        return node;
    }

    public void DeleteAVL(int val)
    {
        root = DelAVL(root, val);
    }

    public TreeNode? DelAVL(TreeNode? node, int val)
    {
        if (node == null) return node;

        if (node.val > val)
        {
            node.left = DelAVL(node.left, val);
        }
        else if (node.val < val)
        {
            node.right = DelAVL(node.right, val);
        }
        else
        {
            if (node.left == null) return node.right;
            if (node.right == null) return node.left;

            TreeNode succ = getMin(node.right);

            (node.val, succ.val) = (succ.val, node.val);
            node.right = DelAVL(node.right, succ.val);
        }


        int balance = getHeight(node.left) - getHeight(node.right);


        if (balance > 1)
        {
            int childBalance = getHeight(node.left.left) - getHeight(node.left.right);
            if (childBalance >= 0)
                return RightRotate(node); 
            else
            {
                node.left = LeftRotate(node.left);
                return RightRotate(node);
            }
        }

        // RR
        if (balance < -1)
        {
            int childBalance = getHeight(node.right.left) - getHeight(node.right.right);
            if (childBalance <= 0)
                return LeftRotate(node); // RR
            else
            {
                node.right = RightRotate(node.right);
                return LeftRotate(node); // RL
            }
        }    

      return node;
    }


    private int getHeight(TreeNode? node)
    {
        if (node == null) return 0;

        return 1 + Math.Max(getHeight(node.left), getHeight(node.right));
    }

    // private int GetBalance(TreeNode? node)
    // {
    //     if (node == null) return 0;
    //     return getHeight(node.left) - getHeight(node.right);
    // }


    public TreeNode? Successor(TreeNode? node, int val)
    {
        return SuccessorRec(node, val);
    }

    private TreeNode? SuccessorRec(TreeNode? node, int target)
    {
        if (node == null) return null;

        TreeNode? succ = null;
        while (node != null)
        {
            if (target > node.val)
            {
                node = node.right;
            }
            else if (target < node.val)
            {
                succ = node;
                node = node.left;
            }
            else
            {
                break;
            }
        }

        if (node != null && node.right != null)
        {
            succ = getMin(node.right);
        }

        return succ;
    }

    public TreeNode? Predecessor(TreeNode? node, int val)
    {
        return PredecessorRec(node, val);
    }

    private TreeNode? PredecessorRec(TreeNode? node, int target)
    {
        TreeNode? pred = null;

        while (node != null)
        {
            if (node.val < target)
            {
                pred = node;
                node = node.right;
            }
            else if (node.val > target)
            {
                node = node.left;
            }
            else
            {
                break;
            }
        }

        if (node != null && node.left != null)
        {
            pred = getMax(node.left);
        }

        return pred;
    }


    private TreeNode getMin(TreeNode node)
    {
        if (node.left == null) return node;

        return getMin(node.left);
    }

    private TreeNode getMax(TreeNode node)
    {
        if (node.right == null) return node;

        return getMax(node.right);
    }

    //////////////Traversals\\\\\\\\\\\
    public void PreOrderTraversal(TreeNode? node)
    {
        if (node == null) return;

        Console.Write($"{node.val} -> ");

        PreOrderTraversal(node.left);
        PreOrderTraversal(node.right);
    }

    public void InOrderTraversal(TreeNode? node)
    {
        if (node == null) return;

        InOrderTraversal(node.left);
        Console.Write($"{node.val} -> ");
        InOrderTraversal(node.right);
    }

    public void PostOrderTraversal(TreeNode? node)
    {
        if (node == null) return;

        PostOrderTraversal(node.left);
        PostOrderTraversal(node.right);
        Console.Write($"{node.val} -> ");
    }

    public List<int> BFS_Traversal(TreeNode? node)
    {
        if (node == null) return new List<int>();

        Queue<TreeNode> q = new Queue<TreeNode>();
        List<int> list = new List<int>();
        q.Enqueue(node);

        while (q.Count > 0)
        {
            TreeNode tmp = q.Dequeue();
            list.Add(tmp.val);

            if (tmp.left != null) q.Enqueue(tmp.left);
            if (tmp.right != null) q.Enqueue(tmp.right);
        }
        
        return list;
    }
}