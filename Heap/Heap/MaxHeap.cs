public class MyMaxHeap
{
    private List<int> heap = new();
    public int Count => heap.Count;

    public void Insert(int value)
    {
        heap.Add(value);
        HeapifyUp(heap.Count - 1);
    }

    public int ExtractMax()
    {
        if (heap.Count == 0)
        {
            throw new ArgumentException("The heap is empty");
        }

        int max = heap[0];
        heap[0] = heap[heap.Count - 1];
        heap.RemoveAt(heap.Count - 1);
        HeapifyDown(0);

        return max;
    }

    public int Peek()
    {
        if (heap.Count == 0) throw new ArgumentException("The heap is empty");

        return heap[0];
    }

    public int Size()
    {
        return heap.Count;
    }



    private void HeapifyUp(int index)
    {
        if (index == 0) return;

        int parent = (index - 1) / 2;
        if (heap[index] > heap[parent])
        {
            Swap(index, parent);
            HeapifyUp(parent);
        }

    }

    private void HeapifyDown(int index)
    {
        int left = 2 * index + 1;
        int right = 2 * index + 2;
        int largest = index;

        if (left < heap.Count && heap[left] > heap[largest])
            largest = left;

        if (right < heap.Count && heap[right] > heap[largest])
            largest = right;

        if (largest != index)
        {
            Swap(index, largest);
            HeapifyDown(largest);
        }
        
        
    }

    private void Swap(int i, int j)
    {
        (heap[i], heap[j]) = (heap[j], heap[i]);
    }


}