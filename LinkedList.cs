namespace ConsoleApp1;

public class LinkedList
{
    public Node head;
    public Node tail;

    public LinkedList()
    {
        this.head = null;
        this.tail = null;
    }

    public void AddLast(int value)
    {
        if (this.head == null)
        {
            Node newNode = new Node(value);
            this.head = newNode;
            this.tail = newNode;

        }
        else
        {
            Node current = this.head;
            while (current.Next != null)
            {
                current = current.Next;
            }

            Node newNode = new Node(value);
            current.Next = newNode;
            this.tail = newNode;
        }
    }

    public Node Search(int value)
    {
        Node current = this.head;
        while (current != null)
        {
            if (current.Value == value)
            {
                return current;
            }
            current = current.Next;
             
        }

        return null;

    }

    public void DeleteNode(int value)
    {
        Node node = Search(value);
        if (node==null)
        {
            Console.WriteLine("not found");
        }
        if (this.head.Value == value)
        {
            this.head = this.head.Next;
        }
        else
        {
            Node current = this.head;
            for (current = this.head; current.Next.Value != value; current = current.Next) ;
            
            current.Next = current.Next.Next;
        }
        
    }

    public int Instance(int value)
    {
        if (this.head == null)
        {
            Console.WriteLine("list is empty");
            return -1;
        }
        else
        {
            Node current = this.head;
            int counter = 0;
            while (current != null)
            {
                if (current.Value == value) counter ++;
                current = current.Next;
            }

            return counter;
        }
    }

    public void Log()
    {
        if (this.head == null)
        {
            Console.WriteLine("Linked List is empty");
        }
        else
        {
            Node current = this.head;
            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }

            
        }
    }

    public static LinkedList stick(LinkedList list1, LinkedList list2)
    {
        if (list1.head == null || list1.tail == null)
        {
            Console.WriteLine("invalid linked list");           
        }
        
        if (list2.head == null || list2.tail == null)
        {
            Console.WriteLine("invalid linked list");           
        }

        list1.tail.Next = list2.head;
        list1.tail = list2.tail;
        return list1;
        

    }

    public void Sort()
    {
        if (this.head == null)
        {
            Console.WriteLine("Linked list is empty");
            return;
        }
        else
        {
            Node current;
            for (current = this.head; current != null; current = current.Next)
            {
                Node node;
                for (node = current.Next; node != null; node = node.Next)
                {
                    if (node.Value < current.Value)
                    {
                        (node.Value, current.Value) = (current.Value, node.Value);
                    }
                }
            }
        }
    }

    public void RemoveDuplications()
    {
        Node current = head;
        Node runner;

        while (current != null)
        {
            runner = current;
            while (runner.Next != null)
            {
                if (runner.Next.Value == current.Value)
                {
                    runner.Next = runner.Next.Next;
                }
                else
                {
                    runner = runner.Next;
                }
            }
            current = current.Next;
        }
    }
}