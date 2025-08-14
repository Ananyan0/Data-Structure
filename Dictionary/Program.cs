using System;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> dict = new Dictionary<string, int>();
        dict.Add("e", 10);
        dict.Add("f", 20);
        dict.Add("q", 30);

        Console.WriteLine();
        dict.Print();

        bool isContains = dict.ContainsKey("f");
        System.Console.WriteLine(isContains);
        

        dict.Remove("a");
        dict.Print();
        dict.Add("a", 40);
        dict.Add("b", 50);
        dict.Add("d", 60);
        dict.Add("c", 70);
        dict.Add("t", 80);
        dict.Add("e", 90); 

        Console.WriteLine();
        dict.Print();
    }
}
