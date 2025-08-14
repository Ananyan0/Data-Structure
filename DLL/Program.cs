using System.Runtime.InteropServices;

namespace Project_;

class Program
{
    static void Main(string[] args)
    {
        

        DoublyLinkedList<int> list = new DoublyLinkedList<int>();

        // Add elements
        list.AddFirst(10);
        list.AddLast(20);
        list.AddLast(30);
        list.AddFirst(5);

        Console.WriteLine("List printed forward:");
        list.PrintForward();
        Console.WriteLine();

        Console.WriteLine("List printed backward:");
        list.PrintBackward();
        Console.WriteLine();

        // Find a value
        bool found20 = list.Find(20);
        Console.WriteLine($"Is 20 in the list? {found20}");  // True

        // Find a node and add before/after
        DoublyNode<int> node = list.FindNode(20);
        if (node != null)
        {
            list.AddBefore(node, 15); 
            list.AddAfter(node, 25); 
        }

        Console.WriteLine("List after adding 15 before 20 and 25 after 20:");
        list.PrintForward(); 
        Console.WriteLine();

        // Remove first and last
        list.RemoveFirst();
        list.RemoveLast();  

        Console.WriteLine("List after removing first and last:");
        list.PrintForward(); 
        Console.WriteLine();

        Console.WriteLine("Iterate with foreach:");
        foreach (var item in list)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        list.Clear();
        Console.WriteLine($"List is empty? {list.isEmpty()}");









    }
}
