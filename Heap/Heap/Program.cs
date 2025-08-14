namespace MaxHeap;

class Program
{
    static void Main(string[] args)
    {
        MyMaxHeap maxHeap = new();

        maxHeap.Insert(1);
        maxHeap.Insert(11);
        maxHeap.Insert(5);
        maxHeap.Insert(75);
        maxHeap.Insert(-1);

        int max = maxHeap.ExtractMax();
        int peek = maxHeap.Peek();

        Console.WriteLine(max);
        Console.WriteLine(peek);

        MyMinHeap minHeap = new();

        minHeap.Insert(14);
        minHeap.Insert(7);
        minHeap.Insert(4);
        minHeap.Insert(24);
        minHeap.Insert(34);

        int min = minHeap.ExtractMin();
        System.Console.WriteLine(min);
    }
}
