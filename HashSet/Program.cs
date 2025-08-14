class Program
{
    static void Main()
    {
        MyHashSet set = new MyHashSet();

        Console.WriteLine("=== Adding elements ===");
        set.Add(10);
        set.Add(20);
        set.Add(30);
        set.Add(15);
        set.Add(25);
        set.Add(35); 
        set.Print();
        Console.WriteLine();

        Console.WriteLine(" Checking contains");
        Console.WriteLine($"Contains 20 {set.Contains(20)}");
        Console.WriteLine($"Contains 50 {set.Contains(50)}");
        Console.WriteLine();

        Console.WriteLine(" Removing elements ");
        set.Remove(15);
        set.Print();
        Console.WriteLine();

        Console.WriteLine(" Adding duplicate elements ");

        set.Add(35); 
        set.Print();
        Console.WriteLine();
    }
}
