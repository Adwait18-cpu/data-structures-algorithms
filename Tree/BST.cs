using System;

public class TreeNode
{
    public int Data;
    public TreeNode Left;
    public TreeNode Right;

    public TreeNode(int data)
    {
        Data = data;
        Left = null;
        Right = null;
    }
}

public class BinaryTree
{
    private TreeNode root;

    public BinaryTree()
    {
        root = null;
    }

    public void Insert(int data)
    {
        root = InsertRecursive(root, data);
    }

    private TreeNode InsertRecursive(TreeNode current, int data)
    {
        if (current == null)
        {
            return new TreeNode(data);
        }

        if (data < current.Data)
        {
            current.Left = InsertRecursive(current.Left, data);
        }
        else if (data > current.Data)
        {
            current.Right = InsertRecursive(current.Right, data);
        }
        // If data is already present in the tree, do nothing
        return current;
    }

    public void InorderTraversal()
    {
        InorderTraversalRecursive(root);
        Console.WriteLine();
    }

    private void InorderTraversalRecursive(TreeNode node)
    {
        if (node != null)
        {
            InorderTraversalRecursive(node.Left);
            Console.Write(node.Data + " ");
            InorderTraversalRecursive(node.Right);
        }
    }

    public void PreorderTraversal(){
        PreorderTraversalRecursive(root);
        Console.WriteLine();
    }

    private void PreorderTraversalRecursive(TreeNode node){
        if(node != null){
            Console.Write(node.Data + " ");
            PreorderTraversalRecursive(node.Left);
            PreorderTraversalRecursive(node.Right);
        }
    }

    public void PostorderTraversal(){
        PostorderTraversalRecursive(root);
        Console.WriteLine();
    }

    private void PostorderTraversalRecursive(TreeNode node){
        if(node != null){
            PreorderTraversalRecursive(node.Left);
            PreorderTraversalRecursive(node.Right);
            Console.Write(node.Data + " ");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        BinaryTree tree = new BinaryTree();

        // Inserting elements into the binary tree
        tree.Insert(10);
        tree.Insert(5);
        tree.Insert(15);
        tree.Insert(3);
        tree.Insert(7);

        Console.WriteLine("Inorder Traversal:");
        tree.InorderTraversal();

        Console.WriteLine("Preorder Traversal:");
        tree.PreorderTraversal();

        Console.WriteLine("Postorder Traversal:");
        tree.PostorderTraversal();
    }
}
