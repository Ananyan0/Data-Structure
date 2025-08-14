class Program
{
    static void Main()
    {
        // Create a directed graph with 6 vertices (0 to 5)
        MyGraph graph = new MyGraph(6);

        // Add edges
        graph.AddEdge(0, 1);
        graph.AddEdge(0, 2);
        graph.AddEdge(1, 3);
        graph.AddEdge(2, 3);
        graph.AddEdge(3, 4);
        graph.AddEdge(4, 5);
        graph.AddEdge(5, 3);

        Console.WriteLine(" Graph adjacency list ");
        graph.Print();
        Console.WriteLine(" DFS traversal ");
        graph.DFS();
        Console.WriteLine();

        Console.WriteLine(" BFS traversal ");
        graph.BFS();
        Console.WriteLine("");

        Console.WriteLine(" Check reachability ");
        Console.WriteLine($"Can reach 0 -> 4? {graph.CanReach(0, 4)}");

        Console.WriteLine("\n Shortest path from 0 to 4 ");
        var path = graph.GetShortestPathFromSrcToDst(0, 4);
        if (path != null) Console.WriteLine(string.Join(" -> ", path));
        else Console.WriteLine("No path found");

        var nodesLevel2 = graph.GetNodesAtAGivenLevel(0, 2);

        Console.WriteLine(" All paths from 0 to 4 ");
        var allPaths = graph.GetAllPossiblePaths(0, 4);
        foreach (var p in allPaths)
        {
            Console.WriteLine(string.Join(" -> ", p));
        }

        Console.WriteLine(" Check if graph has cycle ");
        Console.WriteLine(graph.HasCycle() ? "Graph has a cycle" : "No cycles");

        Console.WriteLine(" Kahn Topological Sort ");

        var topoSort = graph.KahnToplogicalSort(graph.adjacencyList);
        Console.WriteLine(string.Join(" -> ", topoSort));


        Console.WriteLine(" Kosaraju's SCC ");
        var sccKosaraju = graph.FindSCC();
        foreach (var comp in sccKosaraju)
        {
            Console.WriteLine("{" + string.Join(", ", comp) + "}");
        }

        Console.WriteLine("\n=== Tarjan's SCC ===");
        var sccTarjan = graph.TarjanSCC();
        foreach (var comp in sccTarjan)
        {
            Console.WriteLine();
        }
    }
}
