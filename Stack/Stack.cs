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

public class Stack{
    private Node top;
    public Stack(){
        top = null;
    }

    public void Push(int data){
        Node newNode = new Node(data);
        if(top == null){
            top = newNode;
            return;
        }
        else{
            newNode.Next = top;
            top = newNode;
        }
    }

    public void Pop(){
        if(top == null){
            return;
        }
        else{
            Node temp = top;
            top = temp.Next;
            Console.WriteLine(temp.Data + " Popped");
        }
    }

    public void display(){
        Node currentNode = top;
        while (currentNode != null)
        {
            Console.Write(currentNode.Data + " ");
            currentNode = currentNode.Next;
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Stack myStack = new Stack();
        myStack.Push(10);
        myStack.Push(20);
        myStack.Push(30);
        myStack.Push(40);
        myStack.Push(50);
        myStack.display();
        myStack.Pop();
        myStack.display();
    }
}
