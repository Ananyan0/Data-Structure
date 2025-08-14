namespace Graph;

class Program
{
    static void Main(string[] args)
    {
        MyGraph graph = new(10);

        graph.AddEdge(0, 2);
        graph.AddEdge(0, 3);
        graph.AddEdge(1, 3);
        graph.AddEdge(1, 4);
        graph.AddEdge(2, 5);
        graph.AddEdge(3, 6);
        graph.AddEdge(4, 6);
        graph.AddEdge(5, 7);
        graph.AddEdge(6, 8);
        graph.AddEdge(7, 9);

        var result = graph.KahnToplogicalSort(graph.adjacencyList);

        foreach (var item in result)
            Console.Write($"{item} ->");

        Console.WriteLine();
        graph.Print();
    }
}
