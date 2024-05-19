using System;

public class Node
{
    public int Data;
    public Node Next;

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

public class LinkedList
{
     private Node head;

    public LinkedList()
    {
        head = null;
    }

    public void InsertAtBeginning(int data)
    {
        Node newNode = new Node(data);
        newNode.Next = head;
        head = newNode;
    }

    public void MidInsert(int data, int pos){
        Node newNode = new Node(data);
        Node tempPointer = head;

        int t = pos;
        while(t>0){
            tempPointer = tempPointer.Next;
            t--;
        }
        newNode.Next = tempPointer.Next;
        tempPointer.Next = newNode;
    }

    public void InsertAtEnd(int data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
            return;
        }

        Node lastNode = head;
        while (lastNode.Next != null)
        {
            lastNode = lastNode.Next;
        }
        lastNode.Next = newNode;
    }

    public void Display()
    {
        Node currentNode = head;
        while (currentNode != null)
        {
            Console.Write(currentNode.Data + " ");
            currentNode = currentNode.Next;
        }
        Console.WriteLine();
    }


    public void DeleteAtBeg(){
        Node temp = head;
        head = temp.Next;
        
    }

    public void DeleteAtMid(){
        int pos;
        Node temp = head;
        Console.WriteLine("Enter the position of Node to delete: ");
        pos = Convert.ToInt32(Console.ReadLine());
        while(pos > 1){
            temp = temp.Next;
            pos--;
        }
        temp.Next = temp.Next.Next;
    }

    public void DeleteAtEnd(){
        Node temp = head;
        while(temp.Next.Next != null){
            temp = temp.Next;
        }
        temp.Next = null;
    }
}

class Program
{
    static void Main(string[] args)
    {
        LinkedList myList = new LinkedList();

        myList.InsertAtEnd(1);
        myList.InsertAtEnd(2);
        myList.InsertAtEnd(3);
        myList.InsertAtEnd(4);
        myList.InsertAtEnd(6);
        myList.InsertAtEnd(4);

        Console.WriteLine("Linked List:");
        myList.Display();

        myList.MidInsert(4,1);

        Console.WriteLine("Linked List:");
        myList.Display();

        myList.DeleteAtBeg();

        Console.WriteLine("Linked List:");
        myList.Display();

        myList.DeleteAtEnd();

        Console.WriteLine("Linked List:");
        myList.Display();

        myList.DeleteAtMid();

        Console.WriteLine("Linked List:");
        myList.Display();
    }
}
