class MyMinHeap
{
    private List<int> heap = new();
    public int Count => heap.Count;

    public void Insert(int value)
    {
        heap.Add(value);
        HeapifyUp(heap.Count - 1);
    }

    public int ExtractMin()
    {
        if(heap.Count == 0)
            throw new InvalidOperationException("Heap is empty");

        int min = heap[0];
        heap[0] = heap[heap.Count - 1];
        heap.RemoveAt(heap.Count - 1);
        HeapifyDown(0);

        return min;
    }

    private void HeapifyUp(int index)
    {
        if (index == 0) return;

        int parent = (index - 1) / 2;

        if (heap[index] < heap[parent])
        {
            Swap(index, parent);
            HeapifyUp(parent);
        }
    }

    private void HeapifyDown(int index)
    {
        int left = 2 * index + 1;
        int right = 2 * index + 2;
        int minimum = index;

        if (left < heap.Count && heap[left] < heap[minimum])
            minimum = left;
        if (right < heap.Count && heap[right] < heap[minimum])
            minimum = right;

        if (index != minimum)
        {
            Swap(index, minimum);
            HeapifyDown(minimum);
        }


    }

    private void Swap(int i, int j)
    {
        (heap[i], heap[j]) = (heap[j], heap[i]);
    }



}