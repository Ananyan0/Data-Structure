class Program
{
    static void Main(string[] args)
    {
        MyHashSet set = new();

        set.Add(14);
        set.Add(243);
        set.Add(3322);
        set.Add(433);
        set.Add(14);
        set.Add(65);

        ////////////
        set.Print();

        bool isContains = set.Contains(21);
        System.Console.WriteLine(isContains);
        
        
        set.Remove(21);
        set.Print();
    }
}
