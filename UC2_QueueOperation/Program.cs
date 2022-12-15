using System;
using System.Collections;
public class UC2_QueueOperation
{
    public static void Main()
    {
        Queue myQ = new Queue();
        myQ.Enqueue("56");
        myQ.Enqueue("30");
        myQ.Enqueue("70");

        Console.Write("Queue values:");
        PrintValues(myQ);

        Console.WriteLine("(Dequeue)\t{0}", myQ.Dequeue());

        Console.Write("Queue values:");
        PrintValues(myQ);

        Console.WriteLine("(Dequeue)\t{0}", myQ.Dequeue());

        Console.Write("Queue values:");
        PrintValues(myQ);

        Console.WriteLine("(Peek)   \t{0}", myQ.Peek());

        Console.Write("Queue values:");
        PrintValues(myQ);
    }
    public static void PrintValues(IEnumerable myCollection)
    {
        foreach (Object obj in myCollection)
            Console.Write("    {0}", obj);
        Console.WriteLine();
    }
}


