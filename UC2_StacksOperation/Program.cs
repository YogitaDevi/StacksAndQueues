using System;
using System.Security.Cryptography.X509Certificates;
using UC2_StacksOperation;

public class Program
{
    public static void Main(String[] args)
    {

        StacksUsingLinkedList obj = new StacksUsingLinkedList();

        obj.push(70);
        obj.push(30);
        obj.push(56);
        obj.display();
        Console.Write("\nTop of the stacks {0}\n", obj.peek());
    }
}
