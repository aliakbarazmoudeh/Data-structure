namespace ConsoleApp1;

public class DoublyLinkedList
{
    public DoublyNode head ;
    public DoublyNode tail ;

    public DoublyLinkedList()
    {
        this.head = null;
        this.tail = null;
    }

    public void AddNode(int data)
    {
        if (this.head == null)
        {
            DoublyNode newNode = new DoublyNode(data);
            this.head = newNode;
            this.tail = newNode;

        }
        else
        {
            DoublyNode current = this.head;
            while (current.Next != null)
            {
                current = current.Next;
            }

            DoublyNode newNode = new DoublyNode(data);
            current.Next = newNode;
            newNode.Prev = current;
            newNode.Next = null;
            this.tail = newNode;


        }
    }

    public DoublyLinkedList? Reverse()
    {
        if (this.head == null)
        {
            Console.WriteLine("the linked list is empty");
            return null;
        }
        else
        {
            DoublyLinkedList newList = new DoublyLinkedList();
            DoublyNode current = this.tail;
            while (current != null)
            {
                newList.AddNode(current.Data);
                current = current.Prev;
            }

            return newList;
        }
    }

    public void Log()
    {
        if (this.head == null)
        {
            Console.WriteLine("list is empty");
            return;
        }
        else
        {
            DoublyNode current = this.head;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }
    }
}