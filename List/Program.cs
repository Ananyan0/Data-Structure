class Program
{
    static void Main()
    {
        MyList<int> list = new MyList<int>();

        Console.WriteLine("=== Adding elements with Push_Back ===");
        list.Push_Back(10);
        list.Push_Back(20);
        list.Push_Back(30);
        list.Push_Back(40);
        list.Push_Back(50);
        PrintList(list);

        Console.WriteLine(" InsertAt");
        list.InsertAt(25, 2);
        PrintList(list);

        Console.WriteLine("DeleteAt");
        list.DeleteAt(3);
        PrintList(list);

        Console.WriteLine("DeleteByValue");
        list.DeleteByValue(25);
        PrintList(list);

        Console.WriteLine("Pop_Back");
        list.Pop_Back();
        PrintList(list);

        Console.WriteLine(" ShrinkToFit");
        list.ShrinkToFit();
        Console.WriteLine($"shrink: Capacity={list.Capacity}");

        Console.WriteLine("\n=== Clean ===");
        list.Clean();
        PrintList(list);
        Console.WriteLine($"Count= {list.Count}, Capacity= {list.Capacity}");

        Console.WriteLine(" Adding elements again");
        for (int i = 1; i <= 5; i++)
            list.Push_Back(i * 10);
        PrintList(list);

        Console.WriteLine("Empty");
        list.Empty();
        PrintList(list);
        Console.WriteLine($"Count={list.Count}, Capacity={list.Capacity}");
    }

    private static void PrintList(MyList<int> list)
    {
        Console.Write("List: ");
        for (int i = 0; i < list.Count; i++)
        {
            Console.Write(list[i] + " -> ");
        }
        Console.WriteLine("null");
    }
}
