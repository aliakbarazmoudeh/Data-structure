namespace ConsoleApp1;

public class BinaryTree
{
    public BinaryNode? Root;

    public void Insert(int data)
    {
        this.Root = InsertRecursive(this.Root, data);
    }
    private static BinaryNode InsertRecursive(BinaryNode? current , int data)
    {
        if (current == null)
        {
            return new BinaryNode(data);
        }

        if (data < current.Data)
        {
            current.Left = InsertRecursive(current.Left, data);
        }
        else if (data > current.Data)
        {
            current.Right = InsertRecursive(current.Right, data);
        }

        return current;

    }

    public void PreOrder(BinaryNode? current)
    {
        if (current == null)
        {
            return;
        }

        Console.WriteLine(current.Data);
        PreOrder(current.Left);
        PreOrder(current.Right);
    }

    public void InOrder(BinaryNode? node)
    {
        if (node == null)
        {
            return;
        }
        InOrder(node.Left);
        Console.WriteLine(node.Data);
        InOrder(node.Right);
    }

    public void PostOrder(BinaryNode? node)
    {
        if (node == null)
        {
            return;
        }
        PostOrder(node.Left);
        PostOrder(node.Right);
        Console.WriteLine(node.Data);
    }

    public void Search(int data)
    {
        if (this.Root == null)
        {
            Console.WriteLine("the tree is empty");
        }

        SearchRecursive(this.Root, data);
        
    }
    private static void SearchRecursive(BinaryNode? node, int data)
    {
        
        if (node == null)
        {
            Console.WriteLine("cant find any node with this data");
        }
        else if (node.Data == data)
        {
            Console.WriteLine("find the node and the node data is : " + node.Data);
        }
        
        else if (data > node.Data)
        {
            SearchRecursive(node.Right, data);
        }
        else
        {
            SearchRecursive(node.Left,data);
        }

    }
    
}