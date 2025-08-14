using System.Runtime.InteropServices;

namespace Project_;

class Program
{
    static void Main(string[] args)
    {
        SingleLinkedList<int> list = new SingleLinkedList<int>();

        list.Push_Back(5);
        list.Push_Back(1);
        list.Push_Back(7);
        list.Push_Back(3);
        list.Push_Back(2);

        Console.WriteLine("До сортировки:");
        list.Print();

        // Сортировка
        Node<int>? sortedHead = list.MergeSort(list.Head);
        list.Head = sortedHead;

        Console.WriteLine("После сортировки:");
        list.Print();


        // list.Push_Back(1);
        // list.Push_Back(2);

        // Node<int> current = list.Head;

        // while(current != null)
        // {
        //     System.Console.WriteLine(current.Value);
        //     current = current.Next;
        // }


        // var list1 = new SingleLinkedList<int>();
        // list1.Push_Back(1);
        // list1.Push_Back(7);
        // list1.Push_Back(3);

        // var list2 = new SingleLinkedList<int>();
        // list2.Push_Back(4);
        // list2.Push_Back(2);
        // list2.Push_Back(6);

        // var merged = SingleLinkedList<int>.Merge(list1, list2);

        // Node<int> current = merged.Head.Next;

        // while(current != null)
        // {
        //     System.Console.WriteLine(current.Value);
        //     current = current.Next;
        // }












    }
}
