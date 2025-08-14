using System;

class Program
{
    static void Main()
    {
        Dictionary<string, int> dict = new Dictionary<string, int>();

        Console.WriteLine("=== Adding key-value pairs ===");
        dict.Add("apple", 5);
        dict.Add("banana", 10);
        dict.Add("orange", 7);
        dict.Add("grape", 12);
        dict.Add("melon", 15);

        dict.Print();

        Console.WriteLine("\n Getting value by key ");
        Console.WriteLine($"Value for 'apple': {dict.Get("apple")}");
        Console.WriteLine($"Value for 'grape': {dict.Get("grape")}");
        Console.WriteLine();
        Console.WriteLine(" Checking if key exists ");
        Console.WriteLine($"Contains 'banana'? {dict.ContainsKey("banana")}");
        Console.WriteLine($"Contains 'pear'? {dict.ContainsKey("pear")}");

        Console.WriteLine("\nRemoving a key ");
        bool removed = dict.Remove("orange");
        Console.WriteLine($"Removed 'orange'? {removed}");
        dict.Print();

        

        Console.WriteLine("\n Adding more to test resize ");
        dict.Add("kiwi", 8);
        dict.Add("peach", 6);

        dict.Print();

        Console.WriteLine($"\nCount: {dict.Count}");
        Console.WriteLine($"Capacity: {dict.Capacity}");
    }
}
